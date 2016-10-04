using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using RobertLw.Interest.CubePrimer.Data;
using RobertLw.Interest.CubePrimer.Properties;
// ReSharper disable LocalizableElement

namespace RobertLw.Interest.CubePrimer
{
    public partial class MainForm : Form
    {
        #region private fields

        private string fileDir = "";
        private ArrayList loadedFiles = new ArrayList();

        private string playerDoc;
        private string errDoc;

        private string loadedAni;
        private string loadedFlv;

        private OptionForm optionForm;

        private class CmbItem
        {
            public string Text { get; set; }
            public List<List<string>> Value { get; set; }
            public bool ImgLoaded { get; set; }

            public CmbItem(string t)
            {
                Text = t;
                Value = new List<List<string>>();
                ImgLoaded = false;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        #endregion

        #region public, internal fields
        internal ShortcutsSaver shortcuts;

        public delegate void LoadedEvent(object sender, EventArgs e);
        public event LoadedEvent OnLoaded;

        #endregion

        #region constructor methods
        public MainForm()
        {
            InitializeComponent();

            // 恢复窗口状态
            this.WindowState = Settings.Default.MainFormState;
            this.Size = Settings.Default.MainFormSize;
            if (Settings.Default.FirstRun)
            {
                this.StartPosition = FormStartPosition.CenterScreen;
                Settings.Default.FirstRun = false;
            }
            else
                this.Location = Settings.Default.MainFormLocation;
        }

        #endregion

        #region event
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            // 恢复打开文件历史
            loadedFiles = Settings.Default.LoadedFiles ?? new ArrayList();
            SetLoadedMenu();

            // 初始化 Flash 播放器
            InitFlvPlayer();

            // 读取最后一次打开的文件
            if (loadedFiles.Count > 0)
            {
                if (!LoadFile((string)loadedFiles[loadedFiles.Count - 1],
                              Settings.Default.ContentsIndex,
                              true))
                {
                    MessageBox.Show("最后一次打开的文件不存在。",
                                    "文件错误",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    loadedFiles.RemoveAt(loadedFiles.Count - 1);
                    SetLoadedMenu();
                }
            }

            // 读取动画设置
            LoadViewSetting();
            LoadStepsSetting();

            // 读取快捷键设置
            LoadShortcuts();

            OnLoaded?.Invoke(this, new EventArgs());

            if (listView.SelectedItems.Count > 0)
                listView.SelectedItems[0].Focused = true;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveViewSetting();
            SaveStepsSetting();

            SaveShortcuts();

            Settings.Default.MainFormState = this.WindowState != FormWindowState.Minimized ? this.WindowState : FormWindowState.Normal;

            if (this.WindowState == FormWindowState.Normal)
            {
                Settings.Default.MainFormSize = this.Size;
                Settings.Default.MainFormLocation = this.Location;
            }
            else
            {
                Settings.Default.MainFormSize = this.RestoreBounds.Size;
                Settings.Default.MainFormLocation = this.RestoreBounds.Location;
            }

            Settings.Default.Save();
        }

        private void menuItemLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 判断是否在历史文件列表里
                int i = loadedFiles.IndexOf(openFileDialog.FileName);
                if (i != -1)
                {
                    menuItemFiles_Click(menuItemHistory.DropDownItems[i + 2], new EventArgs());
                    return;
                }

                // 载入文件
                if (LoadFile(openFileDialog.FileName))
                {
                    loadedFiles.Add(openFileDialog.FileName);
                    SetLoadedMenu();
                    Settings.Default.LoadedFiles = loadedFiles;
                }
                else
                {
                    MessageBox.Show("指定文件不存在。",
                                    "文件错误",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
            }
        }

        private void menuItemReload_Click(object sender, EventArgs e)
        {
            if (loadedFiles.Count > 0)
            {
                if (!LoadFile((string)loadedFiles[loadedFiles.Count - 1],
                              Settings.Default.ContentsIndex,
                              true))
                {
                    MessageBox.Show("最后一次打开的文件不存在。",
                                    "文件错误",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    loadedFiles.RemoveAt(loadedFiles.Count - 1);
                    SetLoadedMenu();
                }

                // reload ani & flv
                int selIdx = (int)Settings.Default.ListSelectedIndex[comboContents.SelectedIndex];
                listView.Items[0].Selected = true;
                if (listView.Items.Count > selIdx)
                    listView.Items[selIdx].Selected = true;
            }
            else
                MessageBox.Show("无法重新读入文件，是否已被删除？",
                                "文件错误",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
        }

        private void menuItemClearHistroy_Click(object sender, EventArgs e)
        {
            loadedFiles.Clear();
            Settings.Default.LoadedFiles.Clear();
            ClearHistoryMenu();
        }

        private void menuItemFiles_Click(object sender, EventArgs e)
        {
            string s = ((ToolStripItem)sender).Text;

            int i = int.Parse(s.Substring(0, s.IndexOf(' '))) - 1;
            string fn = (string)loadedFiles[i];

            if (LoadFile(fn))
            {
                if (i != loadedFiles.Count - 1)
                {
                    loadedFiles.RemoveAt(i);
                    loadedFiles.Add(fn);
                    SetLoadedMenu();
                }
            }
            else
            {
                MessageBox.Show("指定文件不存在。", "文件错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                loadedFiles.RemoveAt(i);
                SetLoadedMenu();
            }

        }

        private void comboContents_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            statusLabel.Text = "载入手法库";

            string fn;

            CmbItem val = (CmbItem)comboContents.SelectedItem;
            if (!val.ImgLoaded)
            {
                foreach (var ss in val.Value)
                {
                    fn = comboContents.Text + Path.DirectorySeparatorChar + ss[0].Trim();
                    try
                    {
                        Image img = new Bitmap(fileDir + Path.DirectorySeparatorChar + fn + ".png");
                        imageList.Images.Add(fn, img);
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                }
                val.ImgLoaded = true;
            }

            listView.BeginUpdate();
            listView.Groups.Clear();
            listView.Items.Clear();

            // 设置组
            List<string> grpkey = val.Value.Select(ss => ss.Count >= 4 ? ss[3] : "未分组").ToList();

            grpkey.Sort();
            foreach (var g in grpkey.Distinct())
                listView.Groups.Add(g, g);

            // 添加显示项目
            foreach (var ss in val.Value)
            {
                fn = comboContents.Text + Path.DirectorySeparatorChar + ss[0].Trim();
                string txt = imageList.Images.IndexOfKey(fn) != -1 ? fn : "cube";
                string grp = ss.Count >= 4 ? ss[3] : "未分组";

                var lvi = new ListViewItem(ss[0] + "\r" + ss[2], txt, listView.Groups[grp])
                {
                    ToolTipText = ss[2],
                    Tag = new[] {ss[0], ss[1], ss[2]}
                };

                listView.Items.Add(lvi);
                //listView.Update();
                //Application.DoEvents();
            }
            listView.EndUpdate();

            Settings.Default.ContentsIndex = comboContents.SelectedIndex;

            // 设置左侧项目选择
            int selIdx = (int)Settings.Default.ListSelectedIndex[comboContents.SelectedIndex];
            listView.ExpandCollapseGroup(listView.Items[selIdx].Group);
            listView.EnsureVisible(selIdx);
            listView.Items[selIdx].Selected = true;

            this.Cursor = Cursors.Default;
            statusLabel.Text = "";
        }

        private void listView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                string selectedNo = GetSelectedNo();

                if (loadedAni != selectedNo)
                {
                    cubeView.AniPause();

                    // 设置动画
                    string[] tag = (string[])e.Item.Tag;
                    try
                    {
                        cubeView.SetCube(tag[1], tag[2]);
                    }
                    catch (BadCubeValueException)
                    {
                        cubeView.SetCube();
                        MessageBox.Show("错误的魔方初始颜色：\n" + tag[1],
                                        "设置魔方颜色",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (BadCubeStepException)
                    {
                        cubeView.SetCube();
                        MessageBox.Show("错误的魔方手法步骤：\n" + tag[2],
                                        "设置魔方手法",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    // 保存选择位置
                    loadedAni = selectedNo;
                }

                if (tabControl.SelectedIndex == 1 && loadedFlv != selectedNo)
                {
                    // 设置 Flash
                    SetFlash(selectedNo);
                    // 保存选择位置
                    loadedFlv = selectedNo;
                }

                // 保存选择位置
                Settings.Default.ListSelectedIndex[comboContents.SelectedIndex] = e.ItemIndex;
            }
        }

        private void splitAll_MouseDown(object sender, MouseEventArgs e)
        {
            ((SplitContainer)sender).IsSplitterFixed = true;
        }

        private void splitAll_MouseUp(object sender, MouseEventArgs e)
        {
            ((SplitContainer)sender).IsSplitterFixed = false;
        }

        private void splitAll_MouseMove(object sender, MouseEventArgs e)
        {
            if (((SplitContainer)sender).IsSplitterFixed)
            {
                if (e.Button.Equals(MouseButtons.Left))
                {
                    if (((SplitContainer)sender).Orientation.Equals(Orientation.Vertical))
                    {
                        if (e.X > 0 && e.X < ((SplitContainer)sender).Width)
                        {
                            ((SplitContainer)sender).SplitterDistance = e.X;
                            ((SplitContainer)sender).Refresh();
                        }
                    }
                    else
                    {
                        if (e.Y > 0 && e.Y < ((SplitContainer)sender).Height)
                        {
                            ((SplitContainer)sender).SplitterDistance = e.Y;
                            ((SplitContainer)sender).Refresh();
                        }
                    }
                }
                else
                {
                    ((SplitContainer)sender).IsSplitterFixed = false;
                }
            }

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
                listView.EnsureVisible(listView.SelectedItems[0].Index);

            if (optionForm != null && !optionForm.IsDisposed)
                optionForm.Visible = this.WindowState != FormWindowState.Minimized;
        }

        private void menuItemOptionSub_Click(object sender, EventArgs e)
        {
            optionForm = new OptionForm(this, (string)((ToolStripMenuItem)sender).Tag);
            optionForm.Show();
        }

        private void cubeView_OnOptionAnim(object sender, EventArgs e)
        {
            optionForm = new OptionForm(this, "nodeAnim");
            optionForm.Show();
        }

        private void cubeView_OnOptionSteps(object sender, EventArgs e)
        {
            optionForm = new OptionForm(this, "nodeSteps");
            optionForm.Show();
        }

        private void webBrowser_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Left || e.KeyData == Keys.Right)
            {
                HtmlElement element = webBrowser.Document?.GetElementById("keyctrl");
                element?.InvokeMember("click");
            }

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            string obj;
            string method;
            if (shortcuts.GetMethod(e.KeyCode, e.Alt, e.Shift, e.Control, out obj, out method))
            {
                Control ctrl = FindControl(obj, this);
                if (ctrl != null)
                {
                    ExeMethod(ctrl, method);
                    e.Handled = true;
                }
            }
        }

        #endregion

        #region private function
        private bool LoadFile(string file, int subLib = 0, bool isInit = false)
        {
            // 读取文件
            if (!File.Exists(file)) return false;

            fileDir = Path.GetDirectoryName(file);

            //// calc file line, set process form, open it
            ////int lines = File.ReadAllLines(file).Length;
            //int lines = 0;
            //using (TextReader reader = File.OpenText(file))
            //{
            //    while (reader.ReadLine() != null) { lines++; }
            //}

            comboContents.Items.Clear();
            //int i = 0;
            foreach (var l in LineReader(file))
            {
                //i++;
                //// set process form

                if (char.IsWhiteSpace(l, 0))
                {
                    if (comboContents.Items.Count != 0)
                    {
                        CmbItem v = (CmbItem)comboContents.Items[comboContents.Items.Count - 1];
                        v.Value.Add(new List<string>(l.Split(',')));
                    }
                }
                else
                    comboContents.Items.Add(new CmbItem(l));
            }

            // 设置子库选择
            if (!isInit ||
                Settings.Default.ListSelectedIndex == null ||
                Settings.Default.ListSelectedIndex.Count != comboContents.Items.Count)
                Settings.Default.ListSelectedIndex = new ArrayList(new int[comboContents.Items.Count]);
            comboContents.SelectedIndex = comboContents.Items.Count > subLib ? subLib : 0;

            return true;
        }

        private static IEnumerable<string> LineReader(string file)
        {
            using (var reader = new StreamReader(file, Encoding.Default, true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    if (line.Length > 0 && !line.StartsWith(Common.COMM_CHAR))
                        yield return line.TrimEnd();
            }
        }

        private void SetLoadedMenu()
        {
            while (loadedFiles.Count > 8) loadedFiles.RemoveAt(0);
            ClearHistoryMenu();

            int i = 1;
            foreach (string item in loadedFiles)
            {
                ToolStripItem mnu = new ToolStripMenuItem();
                mnu.Text = i++ + " " + CutPath(item, 48);
                mnu.Click += menuItemFiles_Click;
                menuItemHistory.DropDownItems.AddRange(new[] { mnu });
            }
        }

        private void ClearHistoryMenu()
        {
            menuItemHistory.DropDownItems.Clear();
            menuItemHistory.DropDownItems.AddRange(
                loadedFiles.Count > 0
                    ? new ToolStripItem[] {menuItemClearHistroy, toolStripSeparator}
                    : new ToolStripItem[] {menuItemClearHistroy});
        }

        private string CutPath(string path, int len)
        {
            if (path.Length <= len)
                return path;

            string l = path.Substring(0, 3) + "...";
            len -= 3;

            StringBuilder r = new StringBuilder();
            int n = 0;
            foreach (var c in path.Reverse())
            {
                if (c <= 255)
                    n++;
                else
                    n += 2;
                if (n <= len)
                    r.Append(c);
                else
                    break;
            }

            return l + new string(r.ToString().Reverse().ToArray());
        }

        private void LoadViewSetting()
        {
            if (Math.Abs(Settings.Default.ViewSpeed) > GlobalValue.MinFloat)
                cubeView.Speed = Settings.Default.ViewSpeed;
            if (Math.Abs(Settings.Default.ViewZoom) > GlobalValue.MinFloat)
                cubeView.Zoom = Settings.Default.ViewZoom;

            cubeView.ShowPlane = Settings.Default.ViewShowPlane;

            if (!Settings.Default.ViewTopColor.IsEmpty)
                Common.CurColor[(int)POSITION.TOP] = Settings.Default.ViewTopColor;
            if (!Settings.Default.ViewBottomColor.IsEmpty)
                Common.CurColor[(int)POSITION.BOTTOM] = Settings.Default.ViewBottomColor;
            if (!Settings.Default.ViewFrontColor.IsEmpty)
                Common.CurColor[(int)POSITION.FRONT] = Settings.Default.ViewFrontColor;
            if (!Settings.Default.ViewBackColor.IsEmpty)
                Common.CurColor[(int)POSITION.BACK] = Settings.Default.ViewBackColor;
            if (!Settings.Default.ViewLeftColor.IsEmpty)
                Common.CurColor[(int)POSITION.LEFT] = Settings.Default.ViewLeftColor;
            if (!Settings.Default.ViewRightColor.IsEmpty)
                Common.CurColor[(int)POSITION.RIGHT] = Settings.Default.ViewRightColor;
            if (!Settings.Default.ViewIgnoreColor.IsEmpty)
                Common.CurColor[(int)POSITION.IGNORE] = Settings.Default.ViewIgnoreColor;
        }

        private void SaveViewSetting()
        {
            Settings.Default.ViewSpeed = cubeView.Speed;
            Settings.Default.ViewZoom = cubeView.Zoom;

            Settings.Default.ViewShowPlane = cubeView.ShowPlane;

            Settings.Default.ViewTopColor = Common.CurColor[(int)POSITION.TOP];
            Settings.Default.ViewBottomColor = Common.CurColor[(int)POSITION.BOTTOM];
            Settings.Default.ViewFrontColor = Common.CurColor[(int)POSITION.FRONT];
            Settings.Default.ViewBackColor = Common.CurColor[(int)POSITION.BACK];
            Settings.Default.ViewLeftColor = Common.CurColor[(int)POSITION.LEFT];
            Settings.Default.ViewRightColor = Common.CurColor[(int)POSITION.RIGHT];
            Settings.Default.ViewIgnoreColor = Common.CurColor[(int)POSITION.IGNORE];
        }

        private void LoadStepsSetting()
        {
            cubeView.ShowSteps = Settings.Default.ViewShowSteps;

            if (Settings.Default.StepsFont != null)
                cubeView.StepsFontFamily = Settings.Default.StepsFont.FontFamily;

            if (!Settings.Default.StepsColor.IsEmpty)
                cubeView.StepsColor = Settings.Default.StepsColor;
            if (!Settings.Default.StepsCurrColor.IsEmpty)
                cubeView.StepsCurrColor = Settings.Default.StepsCurrColor;
            if (!Settings.Default.StepsNextColor.IsEmpty)
                cubeView.StepsNextColor = Settings.Default.StepsNextColor;
        }

        private void SaveStepsSetting()
        {
            Settings.Default.ViewShowSteps = cubeView.ShowSteps;

            Settings.Default.StepsFont = new Font(cubeView.StepsFontFamily, 20.0f);

            Settings.Default.StepsColor = cubeView.StepsColor;
            Settings.Default.StepsCurrColor = cubeView.StepsCurrColor;
            Settings.Default.StepsNextColor = cubeView.StepsNextColor;

        }

        private void InitFlvPlayer()
        {
            string fp = Application.StartupPath + @"\flvplayer\";

            if (!File.Exists(fp + "error.html") || !File.Exists(fp + "player.html"))
            {
                errDoc = "<HTML>some file are missing!</HTML>";
                return;
            }
            errDoc = File.ReadAllText(fp + "error.html", Encoding.Default);
            playerDoc = File.ReadAllText(fp + "player.html", Encoding.Default);

            //string swfObject = Uri.UnescapeDataString((new Uri(fp + "swfobject.js")).AbsoluteUri);    // js直接直接写到在html中
            // 插件需全目录路径，并且无法包含中文目录！
            string swfPlugins = Uri.EscapeDataString((new Uri(fp + "shortcuts.swf")).AbsoluteUri);
            string swfPlayer = Uri.UnescapeDataString((new Uri(fp + "player.swf")).AbsoluteUri);

            //playerDoc = playerDoc.Replace("<%swfobject%>", swfObject);
            playerDoc = playerDoc.Replace("<%plugins%>", swfPlugins);
            playerDoc = playerDoc.Replace("<%player%>", swfPlayer);
        }

        private void LoadFlv(string fn)
        {
            string doc;

            if (playerDoc != null)
            {
                string no = fn.Substring(0, fn.Length - 4);
                if (!File.Exists(no + ".png"))
                    CreatePreviewImage(no);

                if (File.Exists(fn))
                {
                    string flv = (new Uri(fn)).AbsoluteUri;
                    doc = playerDoc.Replace("<%file%>", flv);
                    string img = (new Uri(no + ".png")).AbsoluteUri;
                    doc = doc.Replace("<%image%>", img);
                }
                else
                {
                    doc = errDoc;
                }
            }
            else
                doc = errDoc;

            if (webBrowser.Document == null)
                webBrowser.Navigate("about:blank");
            else
            {
                webBrowser.Document.OpenNew(true);
                webBrowser.Document.Write(doc);
                webBrowser.Refresh();
                webBrowser.Focus();
                webBrowser.Document?.Focus();
            }
        }

        private void CreatePreviewImage(string fn)
        {
            Thread t = new Thread(() =>
                ExeCommand(
                    $"\"{Application.StartupPath}\\flvplayer\\ffmpeg.exe\"",
                    string.Format("-i \"{0}.flv\" -vframes 1 -ss 00:00:01 -y -f image2 \"{0}.png\"", fn)));
            t.Start();
        }

        private void ExeCommand(string command, string arguments)
        {
            using (Process p = new Process())
            {
                p.StartInfo.FileName = command;
                p.StartInfo.Arguments = arguments;

                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;

                try
                {
                    p.Start();
                    p.WaitForExit();
                    p.Close();
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedNo = GetSelectedNo();
            if (tabControl.SelectedIndex == 1)
            {
                cubeView.AniPause();

                if (loadedFlv != selectedNo)
                {
                    // 设置 Flash
                    SetFlash(selectedNo);
                    // 保存选择位置
                    loadedFlv = selectedNo;
                }
            }
            else
            {
                PauseFlv();
            }
        }

        private void SetFlash(string no)
        {
            string fn = $@"{fileDir}\flv\{no}.flv";
            LoadFlv(fn);
        }

        private void PauseFlv()
        {
            HtmlElement element = webBrowser.Document?.GetElementById("jwplayer");
            element?.InvokeMember("sendEvent", "PLAY", false);
        }

        private string GetSelectedNo()
        {
            CmbItem cmbItem = (CmbItem)comboContents.SelectedItem;
            if (cmbItem == null) return "";

            ListView.SelectedListViewItemCollection lsvItems = listView.SelectedItems;
            if (lsvItems.Count == 0) return "";

            string[] tag = (string[])lsvItems[0].Tag;
            return $"{cmbItem}{tag[0].Trim()}";
        }

        private void ExeMethod(Control obj, string methodName)
        {
            Type type = obj.GetType();
            MethodInfo method = type.GetMethod(methodName);
            method.Invoke(obj, null);
        }

        private Control FindControl(string name, Control container)
        {
            if (container.Name == name)
                return container;

            return (from Control control in container.Controls select FindControl(name, control)).FirstOrDefault(c => c != null);
        }

        private IEnumerable<ToolStripMenuItem> MenuEnumerable(ToolStripItemCollection toolStripItems)
        {
            foreach (var tsi in toolStripItems)
            {
                ToolStripMenuItem m = tsi as ToolStripMenuItem;

                // 去掉数字开头的菜单是为了取消动态生成的打开文件履历
                if (string.IsNullOrEmpty(m?.Text) || char.IsDigit(m.Text[0]))
                    continue;

                yield return m;

                foreach (ToolStripMenuItem sm in MenuEnumerable(m.DropDownItems))
                    if (sm != null) yield return sm;
            }
        }

        private ToolStripMenuItem FindMenu(string name)
        {
            foreach (var m in MenuEnumerable(this.menu.Items))
                if (m.Text == name) return m;

            foreach (var m in MenuEnumerable(cubeView.TopContextMenuStrip.Items))
                if (m.Text == name) return m;

            return null;
        }

        private void LoadShortcuts()
        {
            // 初始化快捷键设置，如果没有则使用默认值
            if (string.IsNullOrEmpty(Settings.Default.Shortcuts))
            {
                InitShortcuts();
                return;
            }

            // 如果有设置则读取，并设置菜单快捷键
            byte[] bytes = Convert.FromBase64String(Settings.Default.Shortcuts);
            MemoryStream ms = new MemoryStream(bytes);
            BinaryFormatter bf = new BinaryFormatter();

            shortcuts = (ShortcutsSaver)bf.Deserialize(ms);

            // 将所有菜单快捷键设置进菜单
            foreach (Data.Shortcut stc in shortcuts.Menus())
            {
                ToolStripMenuItem m = FindMenu(stc.Text);
                if (m == null) continue;

                if (stc.Key != Keys.None)
                {
                    Keys key = stc.Key;
                    if (stc.Alt) key |= Keys.Alt;
                    if (stc.Ctrl) key |= Keys.Control;
                    if (stc.Shift) key |= Keys.Shift;
                    m.ShortcutKeys = key;
                }
            }
        }

        private void SaveShortcuts()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, shortcuts);

            Settings.Default.Shortcuts = Convert.ToBase64String(ms.ToArray());
        }

        public void InitShortcuts()
        {
            shortcuts = new ShortcutsSaver();

            foreach (var m in MenuEnumerable(this.menu.Items))
                shortcuts.AddMenu(m.Text, m.ShortcutKeys);

            foreach (var m in MenuEnumerable(cubeView.TopContextMenuStrip.Items))
                shortcuts.AddMenu(m.Text, m.ShortcutKeys);

            shortcuts.Add("下一步动画", "cubeView", "Ani2Next", Keys.N);
            shortcuts.Add("退一步动画", "cubeView", "Ani2Back", Keys.B);
            shortcuts.Add("播放动画", "cubeView", "AniPlay", Keys.Space);
            shortcuts.Add("退到开头动画", "cubeView", "Ani2Begin");
            shortcuts.Add("连续动画时暂停", "cubeView", "AniPause");
            shortcuts.Add("设置到下一步", "cubeView", "Set2Next");
            shortcuts.Add("设置到上一步", "cubeView", "Set2Back");
            shortcuts.Add("设置到开头", "cubeView", "Set2Begin");
            shortcuts.Add("设置到结尾", "cubeView", "Set2End");

            shortcuts.Add("左旋魔方", "cubeView", "RotateLeftY", Keys.Left);
            shortcuts.Add("右旋魔方", "cubeView", "RotateRightY", Keys.Right);

            shortcuts.Add("放大魔方", "cubeView", "ZoomUp3", Keys.Up);
            shortcuts.Add("缩小魔方", "cubeView", "ZoomDown3", Keys.Down);
        }

        #endregion

    }

}
