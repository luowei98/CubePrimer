namespace CubePrimer
{
    partial class OptionForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("动画参数");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("步骤参数");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("动画画面设置", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("快捷键");
            this.panelAnim = new System.Windows.Forms.Panel();
            this.numericZoom = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonIgnore = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonBottom = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonFront = new System.Windows.Forms.Button();
            this.buttonTop = new System.Windows.Forms.Button();
            this.checkBoxPlane = new System.Windows.Forms.CheckBox();
            this.numericSpeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSteps = new System.Windows.Forms.Panel();
            this.panelStepSub = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSample = new System.Windows.Forms.Label();
            this.checkBoxMerge = new System.Windows.Forms.CheckBox();
            this.buttonStepColor = new System.Windows.Forms.Button();
            this.buttonCurrStepColor = new System.Windows.Forms.Button();
            this.buttonFont = new System.Windows.Forms.Button();
            this.buttonNextStepColor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNextSample = new System.Windows.Forms.Label();
            this.labelCurrSample = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxStep = new System.Windows.Forms.CheckBox();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.panelShortcuts = new System.Windows.Forms.Panel();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBoxKeys = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listViewKeys = new CubePrimer.ListViewEx();
            this.columnHeaderMethod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKeyAcc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.treeView = new CubePrimer.TreeViewEx();
            this.panelAnim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericZoom)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpeed)).BeginInit();
            this.panelSteps.SuspendLayout();
            this.panelStepSub.SuspendLayout();
            this.panelShortcuts.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAnim
            // 
            this.panelAnim.Controls.Add(this.numericZoom);
            this.panelAnim.Controls.Add(this.label2);
            this.panelAnim.Controls.Add(this.groupBox1);
            this.panelAnim.Controls.Add(this.checkBoxPlane);
            this.panelAnim.Controls.Add(this.numericSpeed);
            this.panelAnim.Controls.Add(this.label1);
            this.panelAnim.Location = new System.Drawing.Point(206, 103);
            this.panelAnim.Name = "panelAnim";
            this.panelAnim.Size = new System.Drawing.Size(434, 422);
            this.panelAnim.TabIndex = 1;
            // 
            // numericZoom
            // 
            this.numericZoom.Location = new System.Drawing.Point(268, 26);
            this.numericZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericZoom.Name = "numericZoom";
            this.numericZoom.Size = new System.Drawing.Size(64, 23);
            this.numericZoom.TabIndex = 6;
            this.numericZoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericZoom.ValueChanged += new System.EventHandler(this.numericZoom_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "缩放：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonIgnore);
            this.groupBox1.Controls.Add(this.buttonBack);
            this.groupBox1.Controls.Add(this.buttonRight);
            this.groupBox1.Controls.Add(this.buttonLeft);
            this.groupBox1.Controls.Add(this.buttonBottom);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.buttonFront);
            this.groupBox1.Controls.Add(this.buttonTop);
            this.groupBox1.Location = new System.Drawing.Point(32, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 204);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "颜色设置";
            // 
            // buttonIgnore
            // 
            this.buttonIgnore.BackColor = System.Drawing.SystemColors.Control;
            this.buttonIgnore.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonIgnore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIgnore.Location = new System.Drawing.Point(288, 66);
            this.buttonIgnore.Name = "buttonIgnore";
            this.buttonIgnore.Size = new System.Drawing.Size(48, 48);
            this.buttonIgnore.TabIndex = 13;
            this.buttonIgnore.Tag = "7";
            this.buttonIgnore.Text = "忽略";
            this.buttonIgnore.UseVisualStyleBackColor = false;
            this.buttonIgnore.Click += new System.EventHandler(this.buttonFaceColor_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(197, 66);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(48, 48);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Tag = "4";
            this.buttonBack.Text = "后";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonFaceColor_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRight.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRight.Location = new System.Drawing.Point(150, 66);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(48, 48);
            this.buttonRight.TabIndex = 10;
            this.buttonRight.Tag = "6";
            this.buttonRight.Text = "右";
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonFaceColor_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLeft.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.Location = new System.Drawing.Point(56, 66);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(48, 48);
            this.buttonLeft.TabIndex = 9;
            this.buttonLeft.Tag = "5";
            this.buttonLeft.Text = "左";
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonFaceColor_Click);
            // 
            // buttonBottom
            // 
            this.buttonBottom.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBottom.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBottom.Location = new System.Drawing.Point(103, 113);
            this.buttonBottom.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBottom.Name = "buttonBottom";
            this.buttonBottom.Size = new System.Drawing.Size(48, 48);
            this.buttonBottom.TabIndex = 8;
            this.buttonBottom.Tag = "2";
            this.buttonBottom.Text = "下";
            this.buttonBottom.UseVisualStyleBackColor = false;
            this.buttonBottom.Click += new System.EventHandler(this.buttonFaceColor_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(279, 166);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "默认";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonFront
            // 
            this.buttonFront.BackColor = System.Drawing.SystemColors.Control;
            this.buttonFront.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonFront.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFront.Location = new System.Drawing.Point(103, 66);
            this.buttonFront.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFront.Name = "buttonFront";
            this.buttonFront.Size = new System.Drawing.Size(48, 48);
            this.buttonFront.TabIndex = 7;
            this.buttonFront.Tag = "3";
            this.buttonFront.Text = "前";
            this.buttonFront.UseVisualStyleBackColor = false;
            this.buttonFront.Click += new System.EventHandler(this.buttonFaceColor_Click);
            // 
            // buttonTop
            // 
            this.buttonTop.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTop.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTop.Location = new System.Drawing.Point(103, 19);
            this.buttonTop.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTop.Name = "buttonTop";
            this.buttonTop.Size = new System.Drawing.Size(48, 48);
            this.buttonTop.TabIndex = 6;
            this.buttonTop.Tag = "1";
            this.buttonTop.Text = "上";
            this.buttonTop.UseVisualStyleBackColor = false;
            this.buttonTop.Click += new System.EventHandler(this.buttonFaceColor_Click);
            // 
            // checkBoxPlane
            // 
            this.checkBoxPlane.AutoSize = true;
            this.checkBoxPlane.Location = new System.Drawing.Point(32, 70);
            this.checkBoxPlane.Name = "checkBoxPlane";
            this.checkBoxPlane.Size = new System.Drawing.Size(87, 21);
            this.checkBoxPlane.TabIndex = 2;
            this.checkBoxPlane.Text = "显示平面图";
            this.checkBoxPlane.UseVisualStyleBackColor = true;
            this.checkBoxPlane.CheckedChanged += new System.EventHandler(this.checkBoxPlane_CheckedChanged);
            // 
            // numericSpeed
            // 
            this.numericSpeed.Location = new System.Drawing.Point(103, 26);
            this.numericSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSpeed.Name = "numericSpeed";
            this.numericSpeed.Size = new System.Drawing.Size(64, 23);
            this.numericSpeed.TabIndex = 1;
            this.numericSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSpeed.ValueChanged += new System.EventHandler(this.numericSpeed_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "动画速度：";
            // 
            // panelSteps
            // 
            this.panelSteps.Controls.Add(this.panelStepSub);
            this.panelSteps.Controls.Add(this.checkBoxStep);
            this.panelSteps.Location = new System.Drawing.Point(238, 49);
            this.panelSteps.Name = "panelSteps";
            this.panelSteps.Size = new System.Drawing.Size(434, 422);
            this.panelSteps.TabIndex = 7;
            // 
            // panelStepSub
            // 
            this.panelStepSub.Controls.Add(this.label3);
            this.panelStepSub.Controls.Add(this.labelSample);
            this.panelStepSub.Controls.Add(this.checkBoxMerge);
            this.panelStepSub.Controls.Add(this.buttonStepColor);
            this.panelStepSub.Controls.Add(this.buttonCurrStepColor);
            this.panelStepSub.Controls.Add(this.buttonFont);
            this.panelStepSub.Controls.Add(this.buttonNextStepColor);
            this.panelStepSub.Controls.Add(this.label6);
            this.panelStepSub.Controls.Add(this.labelNextSample);
            this.panelStepSub.Controls.Add(this.labelCurrSample);
            this.panelStepSub.Controls.Add(this.label8);
            this.panelStepSub.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStepSub.Location = new System.Drawing.Point(0, 67);
            this.panelStepSub.Name = "panelStepSub";
            this.panelStepSub.Size = new System.Drawing.Size(434, 355);
            this.panelStepSub.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "正常样例：";
            // 
            // labelSample
            // 
            this.labelSample.BackColor = System.Drawing.Color.Black;
            this.labelSample.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSample.ForeColor = System.Drawing.Color.White;
            this.labelSample.Location = new System.Drawing.Point(27, 30);
            this.labelSample.Name = "labelSample";
            this.labelSample.Size = new System.Drawing.Size(240, 80);
            this.labelSample.TabIndex = 2;
            this.labelSample.Text = "R U R\' U\'";
            this.labelSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxMerge
            // 
            this.checkBoxMerge.AutoSize = true;
            this.checkBoxMerge.Enabled = false;
            this.checkBoxMerge.Location = new System.Drawing.Point(28, 260);
            this.checkBoxMerge.Name = "checkBoxMerge";
            this.checkBoxMerge.Size = new System.Drawing.Size(153, 21);
            this.checkBoxMerge.TabIndex = 11;
            this.checkBoxMerge.Text = "是否合并 x y z (待开发)";
            this.checkBoxMerge.UseVisualStyleBackColor = true;
            // 
            // buttonStepColor
            // 
            this.buttonStepColor.Location = new System.Drawing.Point(313, 89);
            this.buttonStepColor.Name = "buttonStepColor";
            this.buttonStepColor.Size = new System.Drawing.Size(80, 23);
            this.buttonStepColor.TabIndex = 3;
            this.buttonStepColor.Text = "字体颜色";
            this.buttonStepColor.UseVisualStyleBackColor = true;
            this.buttonStepColor.Click += new System.EventHandler(this.buttonStepColor_Click);
            // 
            // buttonCurrStepColor
            // 
            this.buttonCurrStepColor.Location = new System.Drawing.Point(313, 130);
            this.buttonCurrStepColor.Name = "buttonCurrStepColor";
            this.buttonCurrStepColor.Size = new System.Drawing.Size(80, 23);
            this.buttonCurrStepColor.TabIndex = 10;
            this.buttonCurrStepColor.Text = "当前步颜色";
            this.buttonCurrStepColor.UseVisualStyleBackColor = true;
            this.buttonCurrStepColor.Click += new System.EventHandler(this.buttonCurrStepColor_Click);
            // 
            // buttonFont
            // 
            this.buttonFont.Location = new System.Drawing.Point(313, 48);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(80, 23);
            this.buttonFont.TabIndex = 4;
            this.buttonFont.Text = "选择字体";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // buttonNextStepColor
            // 
            this.buttonNextStepColor.Location = new System.Drawing.Point(313, 171);
            this.buttonNextStepColor.Name = "buttonNextStepColor";
            this.buttonNextStepColor.Size = new System.Drawing.Size(80, 23);
            this.buttonNextStepColor.TabIndex = 9;
            this.buttonNextStepColor.Text = "下一步颜色";
            this.buttonNextStepColor.UseVisualStyleBackColor = true;
            this.buttonNextStepColor.Click += new System.EventHandler(this.buttonNextStepColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "当前步骤样例：";
            // 
            // labelNextSample
            // 
            this.labelNextSample.BackColor = System.Drawing.Color.Black;
            this.labelNextSample.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNextSample.ForeColor = System.Drawing.Color.White;
            this.labelNextSample.Location = new System.Drawing.Point(175, 141);
            this.labelNextSample.Name = "labelNextSample";
            this.labelNextSample.Size = new System.Drawing.Size(92, 80);
            this.labelNextSample.TabIndex = 8;
            this.labelNextSample.Text = "U";
            this.labelNextSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCurrSample
            // 
            this.labelCurrSample.BackColor = System.Drawing.Color.Black;
            this.labelCurrSample.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrSample.ForeColor = System.Drawing.Color.White;
            this.labelCurrSample.Location = new System.Drawing.Point(26, 141);
            this.labelCurrSample.Name = "labelCurrSample";
            this.labelCurrSample.Size = new System.Drawing.Size(92, 80);
            this.labelCurrSample.TabIndex = 6;
            this.labelCurrSample.Text = "R";
            this.labelCurrSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "下一步骤样例：";
            // 
            // checkBoxStep
            // 
            this.checkBoxStep.AutoSize = true;
            this.checkBoxStep.Location = new System.Drawing.Point(28, 36);
            this.checkBoxStep.Name = "checkBoxStep";
            this.checkBoxStep.Size = new System.Drawing.Size(75, 21);
            this.checkBoxStep.TabIndex = 12;
            this.checkBoxStep.Text = "显示步骤";
            this.checkBoxStep.UseVisualStyleBackColor = true;
            this.checkBoxStep.CheckedChanged += new System.EventHandler(this.checkBoxStep_CheckedChanged);
            // 
            // fontDialog
            // 
            this.fontDialog.AllowVerticalFonts = false;
            this.fontDialog.FixedPitchOnly = true;
            this.fontDialog.FontMustExist = true;
            this.fontDialog.ScriptsOnly = true;
            this.fontDialog.ShowEffects = false;
            // 
            // panelShortcuts
            // 
            this.panelShortcuts.Controls.Add(this.buttonClear);
            this.panelShortcuts.Controls.Add(this.buttonApply);
            this.panelShortcuts.Controls.Add(this.textBoxKeys);
            this.panelShortcuts.Controls.Add(this.label5);
            this.panelShortcuts.Controls.Add(this.label4);
            this.panelShortcuts.Controls.Add(this.listViewKeys);
            this.panelShortcuts.Location = new System.Drawing.Point(271, 12);
            this.panelShortcuts.Name = "panelShortcuts";
            this.panelShortcuts.Size = new System.Drawing.Size(434, 422);
            this.panelShortcuts.TabIndex = 8;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(336, 335);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 4;
            this.buttonApply.Text = "应用";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // textBoxKeys
            // 
            this.textBoxKeys.Location = new System.Drawing.Point(70, 335);
            this.textBoxKeys.Name = "textBoxKeys";
            this.textBoxKeys.Size = new System.Drawing.Size(160, 23);
            this.textBoxKeys.TabIndex = 3;
            this.textBoxKeys.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKeys_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "按键：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "快捷键设置：";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(250, 335);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "清除";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // listViewKeys
            // 
            this.listViewKeys.Collapsible = true;
            this.listViewKeys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMethod,
            this.columnHeaderType,
            this.columnHeaderKey,
            this.columnHeaderKeyAcc});
            this.listViewKeys.FullRowSelect = true;
            this.listViewKeys.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewKeys.HideSelection = false;
            this.listViewKeys.Location = new System.Drawing.Point(6, 51);
            this.listViewKeys.MultiSelect = false;
            this.listViewKeys.Name = "listViewKeys";
            this.listViewKeys.Size = new System.Drawing.Size(422, 259);
            this.listViewKeys.TabIndex = 0;
            this.listViewKeys.UseCompatibleStateImageBehavior = false;
            this.listViewKeys.View = System.Windows.Forms.View.Details;
            this.listViewKeys.SelectedIndexChanged += new System.EventHandler(this.listViewKeys_SelectedIndexChanged);
            // 
            // columnHeaderMethod
            // 
            this.columnHeaderMethod.Text = "操作";
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "类型";
            // 
            // columnHeaderKey
            // 
            this.columnHeaderKey.Text = "按键";
            // 
            // columnHeaderKeyAcc
            // 
            this.columnHeaderKeyAcc.Text = "组合键";
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView.HideSelection = false;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            treeNode1.Name = "nodeAnim";
            treeNode1.Text = "动画参数";
            treeNode2.Name = "nodeSteps";
            treeNode2.Text = "步骤参数";
            treeNode3.Name = "nodeView";
            treeNode3.Text = "动画画面设置";
            treeNode4.Name = "nodeShortcuts";
            treeNode4.Text = "快捷键";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.treeView.Size = new System.Drawing.Size(200, 422);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 422);
            this.Controls.Add(this.panelShortcuts);
            this.Controls.Add(this.panelSteps);
            this.Controls.Add(this.panelAnim);
            this.Controls.Add(this.treeView);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "参数设置";
            this.TopMost = true;
            this.panelAnim.ResumeLayout(false);
            this.panelAnim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericZoom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericSpeed)).EndInit();
            this.panelSteps.ResumeLayout(false);
            this.panelSteps.PerformLayout();
            this.panelStepSub.ResumeLayout(false);
            this.panelStepSub.PerformLayout();
            this.panelShortcuts.ResumeLayout(false);
            this.panelShortcuts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CubePrimer.TreeViewEx treeView;
        private System.Windows.Forms.Panel panelAnim;
        private System.Windows.Forms.NumericUpDown numericSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTop;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.CheckBox checkBoxPlane;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonBottom;
        private System.Windows.Forms.Button buttonFront;
        private System.Windows.Forms.Button buttonIgnore;
        private System.Windows.Forms.NumericUpDown numericZoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSteps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonStepColor;
        private System.Windows.Forms.Label labelSample;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.Label labelNextSample;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCurrSample;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCurrStepColor;
        private System.Windows.Forms.Button buttonNextStepColor;
        private System.Windows.Forms.CheckBox checkBoxMerge;
        private System.Windows.Forms.CheckBox checkBoxStep;
        private System.Windows.Forms.Panel panelStepSub;
        private System.Windows.Forms.Panel panelShortcuts;
        private System.Windows.Forms.Label label4;
        private ListViewEx listViewKeys;
        private System.Windows.Forms.ColumnHeader columnHeaderMethod;
        private System.Windows.Forms.ColumnHeader columnHeaderKey;
        private System.Windows.Forms.ColumnHeader columnHeaderKeyAcc;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxKeys;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.Button buttonClear;
    }
}