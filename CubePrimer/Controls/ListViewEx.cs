using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;

namespace RobertLw.Interest.CubePrimer.Controls
{
    class ListViewEx : ListView
    {
        #region Windows API
        private class Win32
        {

            public const int LVM_FIRST = 0x1000;
            public const int LVM_INSERTGROUP = LVM_FIRST + 145;
            public const int LVM_HITTEST = LVM_FIRST + 18;
            public const int LVM_SETGROUPINFO = LVM_FIRST + 147;
            public const int LVM_GETGROUPINFO = Win32.LVM_FIRST + 149;
            public const int WM_LBUTTONDOWN = 0x0201;
            public const int WM_LBUTTONUP = 0x0202;
            public const int WM_LBUTTONDBLCLK = 0x0203;
            public const int WM_RBUTTONDOWN = 0x0204;
            public const int WM_RBUTTONDBLCLK = 0x0206;

            public enum GROUPSTATE
            {
                COLLAPSIBLE = 8,
                COLLAPSED = 1,
                EXPANDED = 0
            }

            [StructLayout(LayoutKind.Sequential)]
            public struct LVGROUP
            {
                public int cbSize;
                public int mask;
                [MarshalAs(UnmanagedType.LPTStr)]
                public string pszHeader;
                public int cchHeader;
                [MarshalAs(UnmanagedType.LPTStr)]
                public string pszFooter;
                public int cchFooter;
                public int iGroupId;
                public int stateMask;
                public int state;
                public int uAlign;

                // did not used
                //public IntPtr pszSubtitle;
                //public uint cchSubtitle;
                //[MarshalAs(UnmanagedType.LPWStr)]
                //public string pszTask;
                //public uint cchTask;
                //[MarshalAs(UnmanagedType.LPWStr)]
                //public string pszDescriptionTop;
                //public uint cchDescriptionTop;
                //[MarshalAs(UnmanagedType.LPWStr)]
                //public string pszDescriptionBottom;
                //public uint cchDescriptionBottom;
                //public int iTitleImage;
                //public int iExtendedImage;
                //public int iFirstItem;
                //public IntPtr cItems;
                //public IntPtr pszSubsetTitle;
                //public IntPtr cchSubsetTitle;
            }

            /// <summary>
            /// see http://msdn.microsoft.com/en-us/library/bb774754%28v=VS.85%29.aspx
            /// </summary>
            [StructLayout(LayoutKind.Sequential)]
            public struct LVHITTESTINFO
            {
                public Point pt;
                public uint flags;
                public int iItem;
                public int iSubItem;
                public int iGroup;
            }

            /// <summary>
            /// see http://msdn.microsoft.com/en-us/library/bb774754%28v=VS.85%29.aspx
            /// </summary>
            [Flags]
            public enum LVHITTESTFLAGS : uint
            {
                //LVHT_NOWHERE = 0x00000001,
                //LVHT_ONITEMICON = 0x00000002,
                //LVHT_ONITEMLABEL = 0x00000004,
                //LVHT_ONITEMSTATEICON = 0x00000008,
                //LVHT_ONITEM = (LVHT_ONITEMICON | LVHT_ONITEMLABEL | LVHT_ONITEMSTATEICON),
                //LVHT_ABOVE = 0x00000008,
                //LVHT_BELOW = 0x00000010,
                //LVHT_TORIGHT = 0x00000020,
                //LVHT_TOLEFT = 0x00000040,
                // Vista/Win7+ only
                LVHT_EX_GROUP_HEADER = 0x10000000,
                //LVHT_EX_GROUP_FOOTER = 0x20000000,
                LVHT_EX_GROUP_COLLAPSE = 0x40000000,
                //LVHT_EX_GROUP_BACKGROUND = 0x80000000,
                //LVHT_EX_GROUP_STATEICON = 0x01000000,
                //LVHT_EX_GROUP_SUBSETLINK = 0x02000000,
            }

            [DllImport("user32.dll")]
            public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, ref LVHITTESTINFO lParam);
            [DllImport("user32.dll")]
            public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, ref Win32.LVGROUP lParam);
            [DllImport("user32.dll")]
            public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, IntPtr lParam);
        }

        #endregion

        //private static bool IsWindows7orNewer
        //{
        //    get
        //    {
        //        return
        //            (Environment.OSVersion.Platform == PlatformID.Win32NT) &&
        //            (
        //                (Environment.OSVersion.Version.Major > 6) ||
        //                (
        //                    (Environment.OSVersion.Version.Major == 6) &&
        //                    (Environment.OSVersion.Version.Minor >= 1)
        //                )
        //            );
        //    }
        //}

        public bool Collapsible { get; set; }

        public ListViewEx()
        {
            SetStyle(ControlStyles.DoubleBuffer |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint,
                     true);
            UpdateStyles();

            Collapsible = true;
        }

        public void ExpandCollapseGroup(ListViewGroup grp)
        {
            // get group id
            int? nulli = GetGroupID(grp);
            if (nulli == null) return;
            int i = (int)nulli;

            // test location of group
            Point p = new Point(1, 0);
            for (int y = 0; y < this.ClientSize.Height; y += 10)
            {
                p.Y = y;
                if (TestItem(p, Win32.LVHITTESTFLAGS.LVHT_EX_GROUP_HEADER) == i)
                    break;
            }

            // send click event to group header, so it can expand or collapse
            IntPtr lParam = PointToLParam(p);
            Win32.SendMessage(this.Handle, Win32.WM_LBUTTONDOWN, 0x1, lParam);
        }

        public bool IsExpandedGroup(ListViewGroup grp)
        {
            int? i = GetGroupID(grp);
            if (i != null)
                return GetGrpState((int)i) == Win32.GROUPSTATE.EXPANDED;
            else
                return false;
        }

        #region use windows 7 theme
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        internal static extern int SetWindowTheme(IntPtr hWnd, string appName, string partList);

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetWindowTheme(this.Handle, "explorer", null);
        }

        #endregion

        #region set collapsible
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case Win32.LVM_INSERTGROUP:
                    if (Collapsible)
                    {
                        Win32.LVGROUP grp = (Win32.LVGROUP)Marshal.PtrToStructure(m.LParam, typeof(Win32.LVGROUP));
                        grp.state = (int)(Win32.GROUPSTATE.COLLAPSIBLE | Win32.GROUPSTATE.COLLAPSED);
                        // LVGS_COLLAPSIBLE
                        grp.mask = grp.mask ^ 4;
                        // LVGF_STATE
                        Marshal.StructureToPtr(grp, m.LParam, true);
                    }

                    base.WndProc(ref m);
                    break;

                case Win32.WM_LBUTTONUP:
                    if (TestItem(LParamToPoint(m.LParam),
                                 Win32.LVHITTESTFLAGS.LVHT_EX_GROUP_COLLAPSE |
                                 Win32.LVHITTESTFLAGS.LVHT_EX_GROUP_HEADER
                                ) != -1)
                        base.DefWndProc(ref m);
                    base.WndProc(ref m);
                    break;

                case Win32.WM_LBUTTONDOWN:
                    {
                        if (TestItem(LParamToPoint(m.LParam),
                                     Win32.LVHITTESTFLAGS.LVHT_EX_GROUP_HEADER
                                    ) != -1)
                        {
                            m.Msg = Win32.WM_LBUTTONDBLCLK;
                            base.WndProc(ref m);
                        }

                        ListViewHitTestInfo htInfo = this.HitTest(LParamToPoint(m.LParam));
                        if (htInfo.Item != null) base.WndProc(ref m);

                        break;
                    }

                case Win32.WM_LBUTTONDBLCLK:
                case Win32.WM_RBUTTONDOWN:
                case Win32.WM_RBUTTONDBLCLK:
                    {
                        ListViewHitTestInfo htInfo = this.HitTest(LParamToPoint(m.LParam));
                        if (htInfo.Item != null) base.WndProc(ref m);
                        break;
                    }

                default:
                    base.WndProc(ref m);
                    break;

            }
        }

        private static Point LParamToPoint(IntPtr lparam)
        {
            return new Point(lparam.ToInt32() & 0xFFFF, lparam.ToInt32() >> 16);
        }

        private static IntPtr PointToLParam(Point point)
        {
            return new IntPtr(point.X | (point.Y << 16));
        }

        private int TestItem(Point pt, Win32.LVHITTESTFLAGS flags)
        {
            Win32.LVHITTESTINFO htInfoEx = new Win32.LVHITTESTINFO();
            htInfoEx.pt = pt;
            int id = Win32.SendMessage(this.Handle, Win32.LVM_HITTEST, -1, ref htInfoEx);
            return htInfoEx.flags == (int)flags ? id : -1;
        }

        #region bug in function
        //private void SetGrpState(int grpIdx, Win32.GROUPSTATE state)
        //{
        //    Win32.LVGROUP group = new Win32.LVGROUP();
        //    group.cbSize = Marshal.SizeOf(typeof(Win32.LVGROUP));
        //    group.state = (int)(Win32.GROUPSTATE.COLLAPSIBLE | state); // LVGS_COLLAPSIBLE
        //    group.mask = 4; // LVGF_STATE
        //    group.iGroupId = grpIdx;
        //    IntPtr ip = IntPtr.Zero;

        //    try
        //    {
        // Error!!!       ip = Marshal.AllocHGlobal(group.cbSize);
        //        Marshal.StructureToPtr(group, ip, true);
        //        Win32.SendMessage(this.Handle, Win32.LVM_SETGROUPINFO, grpIdx, ip);
        //    }
        //    catch (Exception) { }
        //    finally
        //    {
        //        if (null != ip) Marshal.FreeHGlobal(ip);
        //    }
        //}

        #endregion

        private Win32.GROUPSTATE GetGrpState(int grpIdx)
        {
            Win32.LVGROUP lvg = new Win32.LVGROUP();
            lvg.cbSize = Marshal.SizeOf(lvg);
            lvg.iGroupId = grpIdx;
            lvg.mask = 4; // LVGF_STATE;
            lvg.stateMask = 1;

            Win32.SendMessage(this.Handle, Win32.LVM_GETGROUPINFO, 0, ref lvg);

            return (Win32.GROUPSTATE)lvg.state;
        }

        private int? GetGroupID(ListViewGroup group)
        {
            Type GrpTp = group.GetType();
            if (GrpTp != null)
            {
                PropertyInfo pi = GrpTp.GetProperty("ID", BindingFlags.NonPublic | BindingFlags.Instance);
                if (pi != null)
                {
                    object obj = pi.GetValue(group, null);
                    return obj as int?;
                }
            }
            return null;
        }

        #endregion
    }
}
