using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DASPClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginFrm loginFrm = new LoginFrm();
            loginFrm.ShowDialog();
            if (loginFrm.DialogResult == DialogResult.OK)
            {
                MainFrm mainFrm = new MainFrm(loginFrm.CurrentLoginUser);
                Application.Run(mainFrm);
            }
            else
            {
                return;
            }
        }
    }
}
