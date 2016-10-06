using System;
using System.Drawing;
using System.Windows.Forms;
using RobertLw.Interest.CubePrimer.Data;

namespace RobertLw.Interest.CubePrimer.Controls
{
    public partial class StepView : UserControl
    {
        #region private fields
        // 步法区域
        private SizeF textArea;
        // 步法起始位置
        private PointF origin;
        // 每一步的区域
        private RectangleF[] stepsLocation;
        // 鼠标所指步数
        private int hoverIdx = -1;
        #endregion

        #region event fields
        public delegate void Move2Event(object sender, Move2EventArgs e);
        public event Move2Event OnMove2Event;

        public class Move2EventArgs : EventArgs
        {
            public int Move2StepIdx;

            public Move2EventArgs(int index)
            {
                Move2StepIdx = index;
            }
        }

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
                    cubeData.OnStepChanged += (s, ea) =>
                    {
                        ResizeFont();
                        this.Refresh();
                    };
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

        public Color HoverColor { get; set; }

        public bool IsContinue { get; set; }

        #endregion

        #region constructor methods
        public StepView()
        {
            InitializeComponent();
            MovingColor = Color.Red;
            NextColor = Color.Yellow;
            HoverColor = Color.Aqua;
        }

        #endregion

        #region override methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (string.IsNullOrEmpty(Data?.StepString))
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

            // 显示除下一步字符串外的所有步骤字符串，如果有鼠标覆盖，也跳过鼠标覆盖步法
            //string s = Data.StepString.Substring(0, stepIdx) +
            //           "".PadRight(step.Length) +
            //           Data.StepString.Substring(stepIdx + step.Length);
            string s = BuildPaintStep(Data.StepString, stepIdx, step.Length);
            if (hoverIdx != -1)
            {
                s = BuildPaintStep(s, Data.StepIndexs[hoverIdx], Data.Steps[hoverIdx].Length);
            }
            e.Graphics.DrawString(s, this.Font, new SolidBrush(this.ForeColor), origin);

            // 区别颜色画当前步法
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

            // 如果有鼠标覆盖，区别颜色画出
            if (hoverIdx != -1)
            {
                e.Graphics.DrawString(Data.Steps[hoverIdx],
                                      this.Font,
                                      new SolidBrush(HoverColor),
                                      new PointF(stepsLocation[hoverIdx].X, stepsLocation[hoverIdx].Y));
            }
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

        private void StepView_MouseClick(object sender, MouseEventArgs e)
        {
            var idx = Point2StepIdx(new PointF(e.X, e.Y));
            if (idx < Data.StepsCount && idx != Data.StepNo)
            {
                OnMove2Event?.Invoke(sender, new Move2EventArgs(idx));
            }
        }

        private void StepView_MouseMove(object sender, MouseEventArgs e)
        {
            var idx = Point2StepIdx(new PointF(e.X, e.Y));
            if (idx < Data.StepsCount && idx != Data.StepNo)
            {
                if (idx != hoverIdx)
                {
                    hoverIdx = idx;
                    this.Refresh();
                }
            }
            else
            {
                hoverIdx = -1;
                this.Refresh();
            }
        }

        #endregion

        #region public methods
        public void ResizeFont()
        {
            if (string.IsNullOrEmpty(Data?.StepString))
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
                stepsLocation = MeasureLocaltion(gc);
            }

        }

        #endregion

        #region private function
        private SizeF MeasureSize(Graphics graphics, Font font, string text)
        {
            if (string.IsNullOrEmpty(text))
                return new SizeF(0.0f, 0.0f);

            var format = new StringFormat();
            var rect = new RectangleF(0.0f, 0.0f, 10000.0f, 1000.0f);
            CharacterRange[] ranges = { new CharacterRange(0, text.Length) };

            format.SetMeasurableCharacterRanges(ranges);
            format.FormatFlags = StringFormatFlags.MeasureTrailingSpaces;

            var regions = graphics.MeasureCharacterRanges(text, font, rect, format);
            rect = regions[0].GetBounds(graphics);

            return new SizeF(rect.Width, rect.Height);
        }

        private RectangleF[] MeasureLocaltion(Graphics graphics)
        {
            if (Data.Steps == null) return null;

            var rect = new RectangleF[Data.StepsCount];

            for (int i = 0; i < Data.StepsCount; i++)
            {
                // 上一步为止的大小
                SizeF lastSize;
                if (i == 0)
                {
                    var size = MeasureSize(graphics, this.Font, Data.Steps[0]);
                    rect[i] = new RectangleF(origin.X, origin.Y, size.Width, size.Height);
                }
                else
                {
                    // 上一步为止的步法字符串
                    var s = Data.StepString.Substring(0, Data.StepIndexs[i]);
                    lastSize = MeasureSize(graphics, this.Font, s);
                    var size = MeasureSize(graphics, this.Font, Data.Steps[i]);
                    rect[i] = new RectangleF(origin.X + lastSize.Width, origin.Y, size.Width, size.Height);
                }
            }

            return rect;
        }

        private int Point2StepIdx(PointF point)
        {
            if (point.X < origin.X || point.Y < origin.Y ||
                point.X > origin.X + textArea.Width || point.Y > origin.Y + textArea.Height)
            {
                return Data.StepsCount;
            }

            int i = 0;
            for (; i < stepsLocation.Length; i++)
            {
                if (point.X >= stepsLocation[i].Left &&
                    point.X <= stepsLocation[i].Right &&
                    point.Y >= stepsLocation[i].Top &&
                    point.Y <= stepsLocation[i].Bottom)
                {
                    return i;
                }
            }

            return i;
        }

        private string BuildPaintStep(string steps, int idx, int len)
        {
            var s1 = steps.Substring(0, idx);
            var s2 = steps.Substring(idx + len);

            return s1 + "".PadRight(len) + s2;
        }

        #endregion
    }
}
