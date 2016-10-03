using System;
using System.Windows.Forms;

namespace RobertLw.Interest.CubePrimer
{
    internal static class Program
    {
        private static FlashForm flashForm;

        /// <summary>
        ///     应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            flashForm = new FlashForm();
            flashForm.Show();

            var mf = new MainForm();
            mf.OnLoaded += MainForm_Loaded;

            Application.Run(mf);
        }

        private static void MainForm_Loaded(object sender, EventArgs e)
        {
            ((MainForm) sender).Visible = true;
            flashForm.Close();
        }
    }
}