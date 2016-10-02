using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Globalization;
//using CubePrimer.Properties;

namespace RobertLw.Interest.CubePrimer
{
    static class Program
    {
        static FlashForm flashForm;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //if (Net4Installed())
            //{
            //    MessageBox.Show("please download .net frameword 4", 
            //                    "", 
            //                    MessageBoxButtons.OK, 
            //                    MessageBoxIcon.Exclamation);
            //    return;
            //}

            flashForm = new FlashForm();
            flashForm.Show();

            MainForm mf = new MainForm();
            mf.OnLoaded += new MainForm.LoadedEvent(MainForm_Loaded);

            Application.Run(mf);
        }

        static void MainForm_Loaded(object sender, EventArgs e)
        {
            ((MainForm)sender).Visible = true;
            flashForm.Close();
        }

        //static bool Net4Installed()
        //{
        //    RegistryKey installedVer =
        //        Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP");
        //    if (installedVer == null) return false;

        //    string[] verNames = installedVer.GetSubKeyNames();
        //    // highest installed version
        //    double Framework = Convert.ToDouble(
        //        verNames[verNames.Length - 1].Remove(0, 1), CultureInfo.InvariantCulture);
        //    // service pack
        //    //int SP = Convert.ToInt32(
        //    //    installedVer.OpenSubKey(verNames[verNames.Length - 1]).GetValue("SP", 0));

        //    return Framework >= 4.0;
        //}
    }
}
