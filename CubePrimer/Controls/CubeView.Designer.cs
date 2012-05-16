namespace CubePrimer
{
    partial class CubeView
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CubeView));
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.aniCube = new CubePrimer.AniCube();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemAni2Back = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAni2Next = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemAni2Begin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAni2End = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSet2Back = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSet2Next = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSet2Begin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSet2End = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemOptionAnim = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOptionSteps = new System.Windows.Forms.ToolStripMenuItem();
            this.planeView = new CubePrimer.PlaneView();
            this.tlpView = new System.Windows.Forms.TableLayoutPanel();
            this.stepView = new CubePrimer.StepView();
            this.tlpAll = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBegin = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.tlpTop.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.tlpView.SuspendLayout();
            this.tlpAll.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpTop
            // 
            this.tlpTop.ColumnCount = 2;
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTop.Controls.Add(this.aniCube, 0, 0);
            this.tlpTop.Controls.Add(this.planeView, 1, 0);
            this.tlpTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTop.Location = new System.Drawing.Point(0, 0);
            this.tlpTop.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.RowCount = 1;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.Size = new System.Drawing.Size(640, 380);
            this.tlpTop.TabIndex = 0;
            // 
            // aniCube
            // 
            this.aniCube.AccumBits = ((byte)(0));
            this.aniCube.AnimateSpeed = 5F;
            this.aniCube.AutoCheckErrors = false;
            this.aniCube.AutoFinish = false;
            this.aniCube.AutoMakeCurrent = true;
            this.aniCube.AutoSwapBuffers = true;
            this.aniCube.BackColor = System.Drawing.Color.Black;
            this.aniCube.ColorBits = ((byte)(32));
            this.aniCube.ContextMenuStrip = this.contextMenu;
            this.aniCube.ContinueFlag = CubePrimer.MOVE_DIREC.NONE;
            this.aniCube.Data = null;
            this.aniCube.DepthBits = ((byte)(16));
            this.aniCube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aniCube.Location = new System.Drawing.Point(0, 0);
            this.aniCube.Margin = new System.Windows.Forms.Padding(0);
            this.aniCube.Name = "aniCube";
            this.aniCube.Size = new System.Drawing.Size(480, 380);
            this.aniCube.StencilBits = ((byte)(0));
            this.aniCube.TabIndex = 0;
            this.aniCube.TabStop = false;
            this.aniCube.Zoom = -20F;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAni2Back,
            this.menuItemAni2Next,
            this.toolStripSeparator1,
            this.menuItemAni2Begin,
            this.menuItemAni2End,
            this.toolStripSeparator2,
            this.menuItemSet2Back,
            this.menuItemSet2Next,
            this.toolStripSeparator3,
            this.menuItemSet2Begin,
            this.menuItemSet2End,
            this.toolStripSeparator4,
            this.menuItemOptionAnim,
            this.menuItemOptionSteps});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(174, 270);
            // 
            // menuItemAni2Back
            // 
            this.menuItemAni2Back.Name = "menuItemAni2Back";
            this.menuItemAni2Back.Size = new System.Drawing.Size(173, 22);
            this.menuItemAni2Back.Text = "动画上一步";
            this.menuItemAni2Back.Click += new System.EventHandler(this.menuItemAni2Back_Click);
            // 
            // menuItemAni2Next
            // 
            this.menuItemAni2Next.Name = "menuItemAni2Next";
            this.menuItemAni2Next.Size = new System.Drawing.Size(173, 22);
            this.menuItemAni2Next.Text = "动画下一步";
            this.menuItemAni2Next.Click += new System.EventHandler(this.menuItemAni2Next_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // menuItemAni2Begin
            // 
            this.menuItemAni2Begin.Name = "menuItemAni2Begin";
            this.menuItemAni2Begin.Size = new System.Drawing.Size(173, 22);
            this.menuItemAni2Begin.Text = "动画至开头 / 暂停";
            this.menuItemAni2Begin.Click += new System.EventHandler(this.menuItemAni2Begin_Click);
            // 
            // menuItemAni2End
            // 
            this.menuItemAni2End.Name = "menuItemAni2End";
            this.menuItemAni2End.Size = new System.Drawing.Size(173, 22);
            this.menuItemAni2End.Text = "动画至结尾 / 暂停";
            this.menuItemAni2End.Click += new System.EventHandler(this.menuItemAni2End_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // menuItemSet2Back
            // 
            this.menuItemSet2Back.Name = "menuItemSet2Back";
            this.menuItemSet2Back.Size = new System.Drawing.Size(173, 22);
            this.menuItemSet2Back.Text = "显示上一步";
            this.menuItemSet2Back.Click += new System.EventHandler(this.menuItemSet2Back_Click);
            // 
            // menuItemSet2Next
            // 
            this.menuItemSet2Next.Name = "menuItemSet2Next";
            this.menuItemSet2Next.Size = new System.Drawing.Size(173, 22);
            this.menuItemSet2Next.Text = "显示下一步";
            this.menuItemSet2Next.Click += new System.EventHandler(this.menuItemSet2Next_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(170, 6);
            // 
            // menuItemSet2Begin
            // 
            this.menuItemSet2Begin.Name = "menuItemSet2Begin";
            this.menuItemSet2Begin.Size = new System.Drawing.Size(173, 22);
            this.menuItemSet2Begin.Text = "显示开头";
            this.menuItemSet2Begin.Click += new System.EventHandler(this.menuItemSet2Begin_Click);
            // 
            // menuItemSet2End
            // 
            this.menuItemSet2End.Name = "menuItemSet2End";
            this.menuItemSet2End.Size = new System.Drawing.Size(173, 22);
            this.menuItemSet2End.Text = "显示结尾";
            this.menuItemSet2End.Click += new System.EventHandler(this.menuItemSet2End_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(170, 6);
            // 
            // menuItemOptionAnim
            // 
            this.menuItemOptionAnim.Name = "menuItemOptionAnim";
            this.menuItemOptionAnim.Size = new System.Drawing.Size(173, 22);
            this.menuItemOptionAnim.Text = "设置动画参数...";
            this.menuItemOptionAnim.Click += new System.EventHandler(this.menuItemOptionAnim_Click);
            // 
            // menuItemOptionSteps
            // 
            this.menuItemOptionSteps.Name = "menuItemOptionSteps";
            this.menuItemOptionSteps.Size = new System.Drawing.Size(173, 22);
            this.menuItemOptionSteps.Text = "设置步骤参数...";
            this.menuItemOptionSteps.Click += new System.EventHandler(this.menuItemOptionSteps_Click);
            // 
            // planeView
            // 
            this.planeView.BackColor = System.Drawing.Color.Black;
            this.planeView.ContextMenuStrip = this.contextMenu;
            this.planeView.Data = null;
            this.planeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.planeView.Location = new System.Drawing.Point(480, 0);
            this.planeView.Margin = new System.Windows.Forms.Padding(0);
            this.planeView.Name = "planeView";
            this.planeView.Size = new System.Drawing.Size(160, 380);
            this.planeView.TabIndex = 0;
            this.planeView.TabStop = false;
            // 
            // tlpView
            // 
            this.tlpView.BackColor = System.Drawing.Color.Black;
            this.tlpView.ColumnCount = 1;
            this.tlpView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpView.Controls.Add(this.tlpTop, 0, 0);
            this.tlpView.Controls.Add(this.stepView, 0, 1);
            this.tlpView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpView.Location = new System.Drawing.Point(0, 0);
            this.tlpView.Margin = new System.Windows.Forms.Padding(0);
            this.tlpView.Name = "tlpView";
            this.tlpView.RowCount = 2;
            this.tlpView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlpView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpView.Size = new System.Drawing.Size(640, 448);
            this.tlpView.TabIndex = 1;
            // 
            // stepView
            // 
            this.stepView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.stepView.BackColor = System.Drawing.Color.Black;
            this.stepView.ContextMenuStrip = this.contextMenu;
            this.stepView.Data = null;
            this.stepView.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepView.ForeColor = System.Drawing.Color.White;
            this.stepView.IsContinue = false;
            this.stepView.Location = new System.Drawing.Point(0, 380);
            this.stepView.Margin = new System.Windows.Forms.Padding(0);
            this.stepView.MovingColor = System.Drawing.Color.Red;
            this.stepView.MovingFlag = CubePrimer.MOVE_DIREC.NONE;
            this.stepView.Name = "stepView";
            this.stepView.NextColor = System.Drawing.Color.Yellow;
            this.stepView.Size = new System.Drawing.Size(640, 68);
            this.stepView.TabIndex = 0;
            this.stepView.TabStop = false;
            // 
            // tlpAll
            // 
            this.tlpAll.ColumnCount = 1;
            this.tlpAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAll.Controls.Add(this.tlpView, 0, 0);
            this.tlpAll.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlpAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAll.Location = new System.Drawing.Point(0, 0);
            this.tlpAll.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAll.Name = "tlpAll";
            this.tlpAll.RowCount = 2;
            this.tlpAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAll.Size = new System.Drawing.Size(640, 480);
            this.tlpAll.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Controls.Add(this.buttonBegin, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPlay, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackBar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPrev, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonNext, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 448);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 32);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonBegin
            // 
            this.buttonBegin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBegin.BackgroundImage")));
            this.buttonBegin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBegin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBegin.Enabled = false;
            this.buttonBegin.Location = new System.Drawing.Point(3, 3);
            this.buttonBegin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.Size = new System.Drawing.Size(27, 27);
            this.buttonBegin.TabIndex = 0;
            this.buttonBegin.UseVisualStyleBackColor = true;
            this.buttonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlay.BackgroundImage")));
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPlay.Location = new System.Drawing.Point(36, 3);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(27, 27);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // trackBar
            // 
            this.trackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar.LargeChange = 1;
            this.trackBar.Location = new System.Drawing.Point(69, 3);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(502, 26);
            this.trackBar.TabIndex = 2;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // buttonPrev
            // 
            this.buttonPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPrev.BackgroundImage")));
            this.buttonPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPrev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(577, 3);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(27, 27);
            this.buttonPrev.TabIndex = 3;
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNext.BackgroundImage")));
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNext.Location = new System.Drawing.Point(610, 3);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(27, 27);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // CubeView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tlpAll);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "CubeView";
            this.Size = new System.Drawing.Size(640, 480);
            this.Load += new System.EventHandler(this.AniView_Load);
            this.tlpTop.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.tlpView.ResumeLayout(false);
            this.tlpAll.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private System.Windows.Forms.TableLayoutPanel tlpView;
        private AniCube aniCube;
        private PlaneView planeView;
        private StepView stepView;
        private System.Windows.Forms.TableLayoutPanel tlpAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonBegin;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemAni2Next;
        private System.Windows.Forms.ToolStripMenuItem menuItemAni2Back;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemAni2Begin;
        private System.Windows.Forms.ToolStripMenuItem menuItemAni2End;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuItemSet2Back;
        private System.Windows.Forms.ToolStripMenuItem menuItemSet2Next;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuItemSet2Begin;
        private System.Windows.Forms.ToolStripMenuItem menuItemSet2End;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuItemOptionAnim;
        private System.Windows.Forms.ToolStripMenuItem menuItemOptionSteps;
    }
}
