namespace RobertLw.Interest.CubePrimer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReload = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClearHistroy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.comboContents = new System.Windows.Forms.ToolStripComboBox();
            this.menuItemOption = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAnim = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSteps = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemShortcuts = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitAll = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.listView = new RobertLw.Interest.CubePrimer.Controls.ListViewEx();
            this.cubeView = new RobertLw.Interest.CubePrimer.Controls.CubeView();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitAll)).BeginInit();
            this.splitAll.Panel1.SuspendLayout();
            this.splitAll.Panel2.SuspendLayout();
            this.splitAll.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.comboContents,
            this.menuItemOption});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(784, 29);
            this.menu.TabIndex = 3;
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLoad,
            this.menuItemReload,
            this.toolStripSeparator1,
            this.menuItemHistory});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(70, 25);
            this.menuItemFile.Text = "手法库(&F)";
            // 
            // menuItemLoad
            // 
            this.menuItemLoad.Name = "menuItemLoad";
            this.menuItemLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.menuItemLoad.Size = new System.Drawing.Size(157, 22);
            this.menuItemLoad.Text = "读入(&L)";
            this.menuItemLoad.Click += new System.EventHandler(this.menuItemLoad_Click);
            // 
            // menuItemReload
            // 
            this.menuItemReload.Name = "menuItemReload";
            this.menuItemReload.Size = new System.Drawing.Size(157, 22);
            this.menuItemReload.Text = "重新读入(&R)";
            this.menuItemReload.Click += new System.EventHandler(this.menuItemReload_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // menuItemHistory
            // 
            this.menuItemHistory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemClearHistroy,
            this.toolStripSeparator});
            this.menuItemHistory.Name = "menuItemHistory";
            this.menuItemHistory.Size = new System.Drawing.Size(157, 22);
            this.menuItemHistory.Text = "最近使用的库";
            // 
            // menuItemClearHistroy
            // 
            this.menuItemClearHistroy.Name = "menuItemClearHistroy";
            this.menuItemClearHistroy.Size = new System.Drawing.Size(148, 22);
            this.menuItemClearHistroy.Text = "清除历史记录";
            this.menuItemClearHistroy.Click += new System.EventHandler(this.menuItemClearHistroy_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(145, 6);
            // 
            // comboContents
            // 
            this.comboContents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboContents.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.comboContents.Name = "comboContents";
            this.comboContents.Size = new System.Drawing.Size(121, 25);
            this.comboContents.SelectedIndexChanged += new System.EventHandler(this.comboContents_SelectedIndexChanged);
            // 
            // menuItemOption
            // 
            this.menuItemOption.BackColor = System.Drawing.SystemColors.Control;
            this.menuItemOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAnim,
            this.menuItemSteps,
            this.toolStripSeparator2,
            this.menuItemShortcuts});
            this.menuItemOption.Name = "menuItemOption";
            this.menuItemOption.Size = new System.Drawing.Size(62, 25);
            this.menuItemOption.Text = "设置(&O)";
            // 
            // menuItemAnim
            // 
            this.menuItemAnim.Name = "menuItemAnim";
            this.menuItemAnim.Size = new System.Drawing.Size(152, 22);
            this.menuItemAnim.Tag = "nodeAnim";
            this.menuItemAnim.Text = "动画参数(&A)...";
            this.menuItemAnim.Click += new System.EventHandler(this.menuItemOptionSub_Click);
            // 
            // menuItemSteps
            // 
            this.menuItemSteps.Name = "menuItemSteps";
            this.menuItemSteps.Size = new System.Drawing.Size(152, 22);
            this.menuItemSteps.Tag = "nodeSteps";
            this.menuItemSteps.Text = "步骤参数(&S)...";
            this.menuItemSteps.Click += new System.EventHandler(this.menuItemOptionSub_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // menuItemShortcuts
            // 
            this.menuItemShortcuts.Name = "menuItemShortcuts";
            this.menuItemShortcuts.Size = new System.Drawing.Size(152, 22);
            this.menuItemShortcuts.Tag = "nodeShortcuts";
            this.menuItemShortcuts.Text = "快捷键(&C)...";
            this.menuItemShortcuts.Click += new System.EventHandler(this.menuItemOptionSub_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.status.Location = new System.Drawing.Point(0, 390);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(784, 22);
            this.status.TabIndex = 6;
            this.status.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "cube");
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog.RestoreDirectory = true;
            // 
            // splitAll
            // 
            this.splitAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitAll.DataBindings.Add(new System.Windows.Forms.Binding("SplitterDistance", global::RobertLw.Interest.CubePrimer.Properties.Settings.Default, "SplitAllDistance", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.splitAll.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitAll.Location = new System.Drawing.Point(0, 32);
            this.splitAll.Name = "splitAll";
            // 
            // splitAll.Panel1
            // 
            this.splitAll.Panel1.Controls.Add(this.listView);
            // 
            // splitAll.Panel2
            // 
            this.splitAll.Panel2.Controls.Add(this.tabControl);
            this.splitAll.Size = new System.Drawing.Size(784, 358);
            this.splitAll.SplitterDistance = global::RobertLw.Interest.CubePrimer.Properties.Settings.Default.SplitAllDistance;
            this.splitAll.TabIndex = 0;
            this.splitAll.TabStop = false;
            this.splitAll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitAll_MouseDown);
            this.splitAll.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitAll_MouseMove);
            this.splitAll.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitAll_MouseUp);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(480, 358);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.cubeView);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(472, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "动画";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "视频";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.AllowNavigation = false;
            this.webBrowser.AllowWebBrowserDrop = false;
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(466, 326);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.webBrowser_PreviewKeyDown);
            // 
            // listView
            // 
            this.listView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView.Collapsible = true;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HideSelection = false;
            this.listView.LargeImageList = this.imageList;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.ShowItemToolTips = true;
            this.listView.Size = new System.Drawing.Size(300, 358);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_ItemSelectionChanged);
            // 
            // cubeView
            // 
            this.cubeView.BackColor = System.Drawing.SystemColors.Control;
            this.cubeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cubeView.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cubeView.HoverColor = System.Drawing.Color.Aqua;
            this.cubeView.Location = new System.Drawing.Point(0, 0);
            this.cubeView.Margin = new System.Windows.Forms.Padding(0);
            this.cubeView.Name = "cubeView";
            this.cubeView.ShowPlane = true;
            this.cubeView.ShowSteps = true;
            this.cubeView.Size = new System.Drawing.Size(472, 328);
            this.cubeView.Speed = 25F;
            this.cubeView.StepsColor = System.Drawing.Color.White;
            this.cubeView.StepsCurrColor = System.Drawing.Color.Red;
            this.cubeView.StepsNextColor = System.Drawing.Color.Yellow;
            this.cubeView.TabIndex = 2;
            this.cubeView.Zoom = 57.14286F;
            this.cubeView.OnOptionAnim += new RobertLw.Interest.CubePrimer.Controls.CubeView.OptionAnimEvent(this.cubeView_OnOptionAnim);
            this.cubeView.OnOptionSteps += new RobertLw.Interest.CubePrimer.Controls.CubeView.OptionStepsEvent(this.cubeView_OnOptionSteps);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.splitAll);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "魔方初学者";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.splitAll.Panel1.ResumeLayout(false);
            this.splitAll.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitAll)).EndInit();
            this.splitAll.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.SplitContainer splitAll;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemLoad;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStripComboBox comboContents;
        private Controls.ListViewEx listView;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem menuItemHistory;
        private System.Windows.Forms.ToolStripMenuItem menuItemClearHistroy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem menuItemOption;
        private System.Windows.Forms.ToolStripMenuItem menuItemAnim;
        private System.Windows.Forms.ToolStripMenuItem menuItemSteps;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuItemShortcuts;
        private System.Windows.Forms.WebBrowser webBrowser;
        internal Controls.CubeView cubeView;
        private System.Windows.Forms.ToolStripMenuItem menuItemReload;
    }
}