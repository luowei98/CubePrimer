using System;
using System.Drawing;
using System.Windows.Forms;
using RobertLw.Interest.CubePrimer.Data;

namespace RobertLw.Interest.CubePrimer.Controls
{
    public partial class StepView : UserControl
    {
        #region private fields
        private SizeF textArea;
        private PointF origin;

        #endregion

        #region property
        private CubeData cubeData;
        public CubeData Data
        {
            get { return cubeData; }
            set
            {
                cubeData = value;
                if (cubeData != null)
                {
                    cubeData.OnStepChanged += (s, ea) => { ResizeFont(); this.Refresh(); };
                    cubeData.OnMoved += (s, ea) =>
                    {
                        MovingFlag = MOVE_DIREC.NONE;
                        this.Refresh();
                    };
                    cubeData.OnAtBegin += (s, ea) =>
                    {
                        IsContinue = false;
                        this.Refresh();
                    };
                    cubeData.OnAtEnd += (s, ea) =>
                    {
                        IsContinue = false;
                        this.Refresh();
                    };
                }
            }
        }

        private MOVE_DIREC movingFlg;
        public MOVE_DIREC MovingFlag
        {
            get { return movingFlg; }
            set
            {
                movingFlg = value;
                this.Refresh();
            }
        }

        public Color MovingColor { get; set; }

        public Color NextColor { get; set; }

        public bool IsContinue { get; set; }

        #endregion

        #region constructor methods
        public StepView()
        {
            InitializeComponent();
            MovingColor = Color.Red;
            NextColor = Color.Yellow;
        }

        #endregion

        #region override methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Data == null || string.IsNullOrEmpty(Data.StepString))
                return;

            string step;
            int stepIdx;
            if (MovingFlag == MOVE_DIREC.BACK)
            {
                step = Data.LastStep;
                stepIdx = Data.LastStepStrIdx;
            }
            else
            {
                step = Data.NextStep;
                stepIdx = Data.NextStepStrIdx;
            }

            // 显示除下一步字符串外的所有步骤字符串
            string s = Data.StepString.Substring(0, stepIdx) +
                       "".PadRight(step.Length) +
                       Data.StepString.Substring(stepIdx + step.Length);
            e.Graphics.DrawString(s, this.Font, new SolidBrush(this.ForeColor), origin);

            // 已走步骤字符串大小
            SizeF szDone = MeasureSize(e.Graphics,
                                       this.Font,
                                       Data.StepString.Substring(0, stepIdx));
            Color c;
            if (MovingFlag != MOVE_DIREC.NONE || IsContinue)
                c = MovingColor;
            else
                c = NextColor;
            e.Graphics.DrawString(step,
                                  this.Font,
                                  new SolidBrush(c),
                                  new PointF(origin.X + szDone.Width, origin.Y));

            //Pen pen = new Pen(Color.Red);
            //e.Graphics.DrawRectangle(pen,
            //    new Rectangle(
            //        new Point((int)origin.X, (int)origin.Y),
            //        new Size((int)textArea.Width, (int)textArea.Height)));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ResizeFont();
        }

        #endregion

        #region event
        private void StepView_Load(object sender, EventArgs e)
        {
            MovingFlag = MOVE_DIREC.NONE;
        }

        #endregion

        #region public methods
        public void ResizeFont()
        {
            if (Data == null || string.IsNullOrEmpty(Data.StepString))
                return;

            using (Graphics gc = this.CreateGraphics())
            {
                // 计算可以使用最大的字体
                for (int i = 1; i < 100; i++)
                {
                    SizeF sz = MeasureSize(gc, new Font(this.Font.Name, i), Data.StepString);
                    // 左右空 4.0f,所以 - 8.0f
                    if (sz.Width > this.ClientSize.Width - 8.0f || sz.Height > this.ClientSize.Height)
                    {
                        this.Font = new Font(this.Font.Name, i == 1 ? 1.0f : (i - 1.0f));
                        break;
                    }
                }
                // 步骤字符串大小、开始位置
                textArea = MeasureSize(gc, this.Font, Data.StepString);
                origin = new PointF((this.ClientSize.Width - textArea.Width) / 2.0f,
                                    (this.ClientSize.Height - textArea.Height) / 2.0f);
            }

        }

        #endregion

        #region private function
        private SizeF MeasureSize(Graphics graphics, Font font, string text)
        {
            if (string.IsNullOrEmpty(text))
                return new SizeF(0.0f, 0.0f);

            StringFormat format = new StringFormat();
            RectangleF rect = new RectangleF(0.0f, 0.0f, 10000.0f, 1000.0f);
            CharacterRange[] ranges = { new CharacterRange(0, text.Length) };
            Region[] regions;

            format.SetMeasurableCharacterRanges(ranges);
            format.FormatFlags = StringFormatFlags.MeasureTrailingSpaces;

            regions = graphics.MeasureCharacterRanges(text, font, rect, format);
            rect = regions[0].GetBounds(graphics);

            return new SizeF(rect.Width, rect.Height);
        }

        #endregion
    }
}
