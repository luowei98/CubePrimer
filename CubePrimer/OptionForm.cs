using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobertLw.Interest.CubePrimer.Controls;
using RobertLw.Interest.CubePrimer.Data;

namespace RobertLw.Interest.CubePrimer
{
    public partial class OptionForm : Form
    {
        #region private readonly fields
        private readonly string[] BASIC_COLOR = {
                                    "ffff8080","Red","ff804040","Maroon","ff400000","Black",
                                    "ffffff80","Yellow","ffff8040","ffff8000","ff804000","Olive",
                                    "ff80ff80","ff80ff00","Lime","Green","ff004000","ff808040",
                                    "ff00ff80","ff00ff40","Teal","ff008040","ff004040","Gray",
                                    "ff80ffff","Aqua","ff004080","Blue","Navy","ff408080",
                                    "ff0080ff","ff0080c0","ff8080ff","ff0000a0","ff000040","Silver",
                                    "ffff80c0","ff8080c0","ff800040","Purple","ff400040","ff400040",
                                    "ffff80ff","Fuchsia","ffff0080","ff8000ff","ff400080","White"};

        #endregion

        #region private fields
        private CubeView cubeView;

        private ShortcutsSaver shortcuts;
        private Data.Shortcut currShortcut;

        #endregion

        #region constructor methods
        //public OptionForm()
        //{
        //    InitializeComponent();
        //}

        public OptionForm(MainForm parent, string sel)
        {
            InitializeComponent();

            cubeView = parent.cubeView;
            shortcuts = parent.shortcuts;

            treeView.SelectedNode = GetNode(treeView.Nodes, sel);
        }

        #endregion

        #region event
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (treeView.SelectedNode.Name)
            {
                case "nodeAnim": // 动画设置
                    panelAnim.Dock = DockStyle.Fill;
                    panelAnim.BringToFront();
                    LoadAniOption();
                    break;
                case "nodeSteps": // 步骤设置
                    panelSteps.Dock = DockStyle.Fill;
                    panelSteps.BringToFront();
                    LoadStpOption();
                    break;
                case "nodeShortcuts": // 快捷键设置
                    panelShortcuts.Dock = DockStyle.Fill;
                    panelShortcuts.BringToFront();
                    LoadStcOption();
                    break;
                default:
                    break;
            }
        }

        private void numericSpeed_ValueChanged(object sender, EventArgs e)
        {
            cubeView.Speed = (float)numericSpeed.Value;
        }

        private void numericZoom_ValueChanged(object sender, EventArgs e)
        {
            cubeView.Zoom = (float)numericZoom.Value;
        }

        private void checkBoxPlane_CheckedChanged(object sender, EventArgs e)
        {
            cubeView.ShowPlane = checkBoxPlane.Checked;
        }

        private void buttonFaceColor_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            ColorDialog colorDialog = GetColorDialog(btn.BackColor);

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Common.CurColor[Convert.ToInt32(btn.Tag)] = btn.BackColor = colorDialog.Color;
                cubeView.Refresh();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Common.CurColor = (Color[])Common.DEF_COLOR.Clone();

            buttonTop.BackColor = Common.CurColor[(int)POSITION.TOP];
            buttonBottom.BackColor = Common.CurColor[(int)POSITION.BOTTOM];
            buttonFront.BackColor = Common.CurColor[(int)POSITION.FRONT];
            buttonBack.BackColor = Common.CurColor[(int)POSITION.BACK];
            buttonLeft.BackColor = Common.CurColor[(int)POSITION.LEFT];
            buttonRight.BackColor = Common.CurColor[(int)POSITION.RIGHT];
            buttonIgnore.BackColor = Common.CurColor[(int)POSITION.IGNORE];

            cubeView.Refresh();
        }

        private void checkBoxStep_CheckedChanged(object sender, EventArgs e)
        {
            cubeView.ShowSteps = checkBoxStep.Checked;
            panelStepSub.Enabled = checkBoxStep.Checked;
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            fontDialog.Font = labelSample.Font;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Font ft = new Font(fontDialog.Font.FontFamily, labelSample.Font.Size);
                labelSample.Font = labelCurrSample.Font = labelNextSample.Font = ft;
                cubeView.StepsFontFamily = fontDialog.Font.FontFamily;
            }
        }

        private void buttonStepColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = GetColorDialog(labelSample.ForeColor);

            if (colorDialog.ShowDialog() == DialogResult.OK)
                cubeView.StepsColor = labelSample.ForeColor = colorDialog.Color;
        }

        private void buttonCurrStepColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = GetColorDialog(labelCurrSample.ForeColor);

            if (colorDialog.ShowDialog() == DialogResult.OK)
                cubeView.StepsCurrColor = labelCurrSample.ForeColor = colorDialog.Color;
        }

        private void buttonNextStepColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = GetColorDialog(labelNextSample.ForeColor);

            if (colorDialog.ShowDialog() == DialogResult.OK)
                cubeView.StepsNextColor = labelNextSample.ForeColor = colorDialog.Color;
        }

        private void listViewKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewKeys.SelectedItems.Count == 0) return;

            currShortcut = new Data.Shortcut(shortcuts[listViewKeys.SelectedItems[0].Text]);
            textBoxKeys.Text = ShortcutKey2String(currShortcut.Key,
                                                  currShortcut.Alt,
                                                  currShortcut.Ctrl,
                                                  currShortcut.Shift);
        }

        private void textBoxKeys_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;

            if (currShortcut == null) return;

            textBoxKeys.Text = ShortcutKey2String(e.KeyCode,
                                                  e.Alt,
                                                  e.Control,
                                                  e.Shift);

            currShortcut.Key = e.KeyCode;
            currShortcut.Alt = e.Alt;
            currShortcut.Ctrl = e.Control;
            currShortcut.Shift = e.Shift;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxKeys.Text = "";

            if (currShortcut == null) return;
            currShortcut.Key = Keys.None;
            currShortcut.Alt = false;
            currShortcut.Ctrl = false;
            currShortcut.Shift = false;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (listViewKeys.SelectedItems.Count == 0) return;

            ListViewItem lvi = listViewKeys.SelectedItems[0];

            shortcuts[lvi.Text].Key = currShortcut.Key;
            shortcuts[lvi.Text].Alt = currShortcut.Alt;
            shortcuts[lvi.Text].Ctrl = currShortcut.Ctrl;
            shortcuts[lvi.Text].Shift = currShortcut.Shift;

            lvi.SubItems[2].Text = Key2String(currShortcut.Key);
            lvi.SubItems[3].Text = KeyAcc2String(currShortcut.Alt,
                                                 currShortcut.Ctrl,
                                                 currShortcut.Shift);
        }

        #endregion

        #region private methods
        private void LoadAniOption()
        {
            numericSpeed.Value = (decimal)cubeView.Speed;
            numericZoom.Value = (decimal)cubeView.Zoom;
            checkBoxPlane.Checked = cubeView.ShowPlane;

            buttonTop.BackColor = Common.CurColor[(int)POSITION.TOP];
            buttonBottom.BackColor = Common.CurColor[(int)POSITION.BOTTOM];
            buttonFront.BackColor = Common.CurColor[(int)POSITION.FRONT];
            buttonBack.BackColor = Common.CurColor[(int)POSITION.BACK];
            buttonLeft.BackColor = Common.CurColor[(int)POSITION.LEFT];
            buttonRight.BackColor = Common.CurColor[(int)POSITION.RIGHT];
            buttonIgnore.BackColor = Common.CurColor[(int)POSITION.IGNORE];
        }

        private void LoadStpOption()
        {
            checkBoxStep.Checked = cubeView.ShowSteps;

            Font ft = new Font(cubeView.StepsFontFamily, labelSample.Font.Size);
            labelSample.Font = labelCurrSample.Font = labelNextSample.Font = ft;

            labelSample.ForeColor = cubeView.StepsColor;
            labelCurrSample.ForeColor = cubeView.StepsCurrColor;
            labelNextSample.ForeColor = cubeView.StepsNextColor;
        }

        private void LoadStcOption()
        {
            foreach (Data.Shortcut stc in shortcuts)
            {
                string key = Key2String(stc.Key);

                string typ = stc.IsMenu ? "菜单" : "其他";

                string keyacc = KeyAcc2String(stc.Alt, stc.Ctrl, stc.Shift);

                ListViewItem lvi = new ListViewItem(new[] { stc.Text, typ, key, keyacc });
                listViewKeys.Items.Add(lvi);
            }

            columnHeaderType.Width = -1;
            columnHeaderMethod.Width = -1;
            columnHeaderKey.Width = -1;
            columnHeaderKeyAcc.Width = -2;
        }

        private string Key2String(Keys key)
        {
            if (key == Keys.None ||
                key == Keys.Menu ||
                key == Keys.ControlKey ||
                key == Keys.ShiftKey)
                return "";
            return key.ToString();
        }

        private string KeyAcc2String(bool alt, bool ctrl, bool shift)
        {
            if (!alt && !ctrl && !shift) return "";

            List<string> keyacc = new List<string>();
            if (alt) keyacc.Add("Alt");
            if (ctrl) keyacc.Add("Ctrl");
            if (shift) keyacc.Add("Shift");

            return string.Join(" + ", keyacc);
        }

        private string ShortcutKey2String(Keys key, bool alt, bool ctrl, bool shift)
        {
            string keyStr = Key2String(key);
            if (string.IsNullOrEmpty(keyStr)) return "";

            string keyaccStr = KeyAcc2String(alt, ctrl, shift);
            if (string.IsNullOrEmpty(keyaccStr)) return keyStr;

            return keyaccStr + " + " + keyStr;
        }

        private TreeNode GetNode(TreeNodeCollection nodes, string s)
        {
            if (nodes[s] != null)
                return nodes[s];
            else
                foreach (TreeNode n in nodes)
                {
                    TreeNode tn = GetNode(n.Nodes, s);
                    if (tn != null)
                        return tn;
                }
            return null;
        }

        private ColorDialog GetColorDialog(Color c)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = c;

            if (BASIC_COLOR.Contains(c.Name))
                cd.FullOpen = false;
            else
            {
                int i = (c.B << 16) | (c.G << 8) | c.R;
                cd.CustomColors = new int[] { i };
                cd.FullOpen = true;
            }

            return cd;
        }

        #endregion
    }
}
