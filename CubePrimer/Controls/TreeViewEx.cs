﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CubePrimer
{
    class TreeViewEx : TreeView
    {
        public TreeViewEx() { }

        #region use windows 7 theme
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        internal static extern int SetWindowTheme(IntPtr hWnd, string appName, string partList);

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetWindowTheme(this.Handle, "explorer", null);
        }

        #endregion
    }
}
