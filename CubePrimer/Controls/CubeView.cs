using System;
using System.Drawing;
using System.Windows.Forms;
using RobertLw.Interest.CubePrimer.Data;
using RobertLw.Interest.CubePrimer.Properties;

namespace RobertLw.Interest.CubePrimer.Controls
{
    public partial class CubeView : UserControl
    {
        #region private fields
        private CubeData cubeData;

        #endregion

        #region property
        private bool showSteps;
        public bool ShowSteps
        {
            get { return showSteps; }
            set
            {
                showSteps = value;
                if (value)
                {
                    tlpView.RowStyles[0].Height = 85.0f;
                    tlpView.RowStyles[1].Height = 15.0f;
                }
                else
                {
                    tlpView.RowStyles[0].Height = 100.0f;
                    tlpView.RowStyles[1].Height = 0.0f;
                }
            }
        }

        private bool showPlane;
        public bool ShowPlane
        {
            get { return showPlane; }
            set
            {
                showPlane = value;
                if (value)
                {
                    tlpTop.ColumnStyles[0].Width = 75.0f;
                    tlpTop.ColumnStyles[1].Width = 25.0f;
                }
                else
                {
                    tlpTop.ColumnStyles[0].Width = 100.0f;
                    tlpTop.ColumnStyles[1].Width = 0.0f;
                }
            }
        }

        public float Speed
        {
            get { return aniCube.AnimateSpeed * 5.0f; }
            set
            {
                if (value < 0) value = -value;
                if (Math.Abs(value) < GlobalValue.MinFloat) value = 0.1f;

                aniCube.AnimateSpeed = value / 5.0f;
            }
        }

        public float Zoom
        {
            get { return 100 - (aniCube.Zoom + 5) / -35.0f * 100.0f; }
            set
            {
                if (value < 0) return;

                aniCube.Zoom = (100 - value) / 100.0f * -35.0f - 5;
            }
        }

        public FontFamily StepsFontFamily
        {
            get { return stepView.Font.FontFamily; }
            set
            {
                stepView.Font = new Font(value, stepView.Font.Size);
                stepView.ResizeFont();
            }
        }

        public Color StepsColor
        {
            get { return stepView.ForeColor; }
            set { stepView.ForeColor = value; }
        }

        public Color StepsCurrColor
        {
            get { return stepView.MovingColor; }
            set { stepView.MovingColor = value; }
        }

        public Color StepsNextColor
        {
            get { return stepView.NextColor; }
            set
            {
                stepView.NextColor = value;
                stepView.Refresh();
            }
        }

        public ContextMenuStrip TopContextMenuStrip => aniCube.ContextMenuStrip;

        #endregion

        #region event fields
        public delegate void OptionAnimEvent(object sender, EventArgs e);
        public event OptionAnimEvent OnOptionAnim;

        public delegate void OptionStepsEvent(object sender, EventArgs e);
        public event OptionStepsEvent OnOptionSteps;

        #endregion

        #region constructor methods
        public CubeView()
        {
            InitializeComponent();
            this.MouseWheel += this.CubeView_MouseWheel;
        }

        #endregion

        #region event
        private void AniView_Load(object sender, EventArgs e)
        {
            // unpaint on moving, resizing
            //if (!this.DesignMode)
            //{
            //    var parent = this.Parent;
            //    if (parent == null) return;
            //    while (!(parent is Form)) parent = parent.Parent;
            //    var form = parent as Form;
            //    form.ResizeBegin += (s, ea) => aniCube.Visible = false;
            //    form.ResizeEnd += (s, ea) => aniCube.Visible = true;
            //}

            ShowPlane = true;
            ShowSteps = true;

            trackBar.Maximum = 0;
            buttonBegin.Enabled = false;
            buttonPlay.Enabled = false;
            buttonPrev.Enabled = false;
            buttonNext.Enabled = false;

            int minw = (int)tableLayoutPanel1.ColumnStyles[0].Width +
                       (int)tableLayoutPanel1.ColumnStyles[1].Width +
                       (int)tableLayoutPanel1.ColumnStyles[3].Width +
                       (int)tableLayoutPanel1.ColumnStyles[4].Width;
            tableLayoutPanel1.MinimumSize = new Size(minw, tableLayoutPanel1.Height);

            cubeData = this.DesignMode ? new CubeData(Common.DEF_VALUE) : new CubeData();
            cubeData.OnMoved += cubeData_OnMoved;
            cubeData.OnAtBegin += cubeData_OnAtBegin;
            cubeData.OnAtEnd += cubeData_OnAtEnd;

            aniCube.Data = cubeData;
            stepView.Data = cubeData;
            planeView.Data = cubeData;
        }

        private void buttonBegin_Click(object sender, EventArgs e)
        {
            this.Set2Begin();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            this.AniPlay();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.Ani2Next();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            this.Ani2Back();
        }

        private void cubeData_OnMoved(object sender, EventArgs e)
        {
            trackBar.Value = cubeData.StepNo;

            if (aniCube.ContinueFlag == MOVE_DIREC.NONE)
                EnableControl(true);
        }

        private void cubeData_OnAtBegin(object sender, EventArgs e)
        {
            trackBar.Value = cubeData.StepNo;

            EnableControl(true,
                          new Control[] { buttonBegin, buttonPrev },
                          new[] { menuItemAni2Back, 
                                  menuItemAni2Begin, 
                                  menuItemSet2Back, 
                                  menuItemSet2Begin });
        }

        private void cubeData_OnAtEnd(object sender, EventArgs e)
        {
            buttonPlay.BackgroundImage = Resources.playback_play;
            trackBar.Value = cubeData.StepNo;

            EnableControl(true,
                          new Control[] { buttonNext },
                          new[] { menuItemAni2Next, 
                                  menuItemAni2End, 
                                  menuItemSet2Next, 
                                  menuItemSet2End });
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            int n = trackBar.Value;
            if (n > cubeData.StepNo)
                while (cubeData.StepNo < n) this.Set2Next();
            else if (n < cubeData.StepNo)
                while (cubeData.StepNo > n) this.Set2Back();
        }

        private void CubeView_MouseWheel(object sender, MouseEventArgs e)
        {
            trackBar.Focus();
        }

        private void menuItemAni2Back_Click(object sender, EventArgs e)
        {
            Ani2Back();
        }

        private void menuItemAni2Next_Click(object sender, EventArgs e)
        {
            Ani2Next();
        }

        private void menuItemAni2Begin_Click(object sender, EventArgs e)
        {
            if (!AniPause()) this.Ani2Begin();
        }

        private void menuItemAni2End_Click(object sender, EventArgs e)
        {
            if (!AniPause()) this.Ani2End();
        }

        private void menuItemSet2Back_Click(object sender, EventArgs e)
        {
            Set2Back();
        }

        private void menuItemSet2Next_Click(object sender, EventArgs e)
        {
            Set2Next();
        }

        private void menuItemSet2Begin_Click(object sender, EventArgs e)
        {
            Set2Begin();
        }

        private void menuItemSet2End_Click(object sender, EventArgs e)
        {
            Set2End();
        }

        private void menuItemOptionAnim_Click(object sender, EventArgs e)
        {
            OnOptionAnim?.Invoke(this, new EventArgs());
        }

        private void menuItemOptionSteps_Click(object sender, EventArgs e)
        {
            OnOptionSteps?.Invoke(this, new EventArgs());
        }

        #endregion

        #region public methods
        public void SetCube(string value = Common.DEF_VALUE, string steps = "")
        {
            cubeData.Value = value;
            cubeData.StepString = steps;

            if (cubeData.StepsCount > 0)
            {
                trackBar.Maximum = cubeData.StepsCount;

                this.Set2Begin();
            }
        }

        public void Ani2Next()
        {
            if (aniCube.ContinueFlag != MOVE_DIREC.NONE) return;

            EnableControl(false);

            if (aniCube.Ready && cubeData.GoNext())
            {
                stepView.MovingFlag = MOVE_DIREC.NEXT;
                aniCube.Animate();
            }
        }

        public void Ani2Back()
        {
            if (aniCube.ContinueFlag != MOVE_DIREC.NONE) return;

            EnableControl(false);

            if (aniCube.Ready && cubeData.GoBack())
            {
                stepView.MovingFlag = MOVE_DIREC.BACK;
                aniCube.Animate();
            }
        }

        public void Ani2Begin()
        {
            if (aniCube.ContinueFlag != MOVE_DIREC.NONE) return;

            EnableControl(false,
                          new Control[] { buttonPlay },
                          new[] { menuItemAni2Begin, menuItemAni2End });
            buttonPlay.BackgroundImage = Resources.playback_pause;

            if (aniCube.Ready && cubeData.GoBack())
            {
                stepView.MovingFlag = MOVE_DIREC.BACK;
                stepView.IsContinue = true;
                aniCube.ContinueFlag = MOVE_DIREC.BACK;
                aniCube.Animate();
            }
        }

        public void Ani2End()
        {
            if (aniCube.ContinueFlag != MOVE_DIREC.NONE) return;

            EnableControl(false,
                          new Control[] { buttonPlay },
                          new[] { menuItemAni2Begin, menuItemAni2End });
            buttonPlay.BackgroundImage = Resources.playback_pause;

            if (aniCube.Ready && cubeData.GoNext())
            {
                stepView.MovingFlag = MOVE_DIREC.NEXT;
                stepView.IsContinue = true;
                aniCube.ContinueFlag = MOVE_DIREC.NEXT;
                aniCube.Animate();
            }
        }

        public bool AniPause()
        {
            if (aniCube.ContinueFlag != MOVE_DIREC.NONE)
            {
                aniCube.ContinueFlag = MOVE_DIREC.NONE;
                stepView.IsContinue = false;

                EnableControl(true);
                buttonPlay.BackgroundImage = Resources.playback_play;

                return true;
            }

            return false;
        }

        public void AniPlay()
        {
            if (cubeData.StepNo == cubeData.StepsCount)
                this.Set2Begin();

            if (!AniPause()) this.Ani2End();
        }

        public void Set2Next()
        {
            if (cubeData.GoNext()) cubeData.Move();
        }

        public void Set2Back()
        {
            if (cubeData.GoBack()) cubeData.Move();
        }

        public void Set2Begin()
        {
            while (cubeData.GoBack()) cubeData.CalcMove();
        }

        public void Set2End()
        {
            while (cubeData.GoNext()) cubeData.CalcMove();

        }

        public void Rotate(float x, float y, float z)
        {
            aniCube.Rotate(x, y, z);
        }

        public void RotateLeftY()
        {
            Rotate(0.0f, -10.0f, 0.0f);
        }

        public void RotateRightY()
        {
            Rotate(0.0f, 10.0f, 0.0f);
        }

        public void ZoomDelta(float dz)
        {
            aniCube.ZoomDelta(dz);
        }

        public void ZoomUp3()
        {
            ZoomDelta(3.0f);
        }

        public void ZoomDown3()
        {
            ZoomDelta(-3.0f);
        }

        #endregion

        #region private methods
        private void EnableControl(bool val, Control[] ctrls = null, ToolStripMenuItem[] menus = null)
        {
            buttonBegin.Enabled = val;
            buttonPlay.Enabled = val;
            buttonPrev.Enabled = val;
            buttonNext.Enabled = val;

            menuItemAni2Back.Enabled = val;
            menuItemAni2Next.Enabled = val;
            menuItemAni2Begin.Enabled = val;
            menuItemAni2End.Enabled = val;
            menuItemSet2Back.Enabled = val;
            menuItemSet2Next.Enabled = val;
            menuItemSet2Begin.Enabled = val;
            menuItemSet2End.Enabled = val;

            if (ctrls != null)
                foreach (Control c in ctrls)
                {
                    c.Enabled = !val;
                }
            if (menus != null)
                foreach (ToolStripMenuItem m in menus)
                {
                    m.Enabled = !val;
                }
        }

        #endregion

    }
}
