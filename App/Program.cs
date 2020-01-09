using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            List<string> argsList = args.ToList();
            bool isBackgroundMode = argsList.Exists(s => s.Equals("/background"));

            MainForm mainForm = new MainForm(isBackgroundMode);

            if (isBackgroundMode)
            {
                Application.Run();
            }
            else
            {
                Application.Run(mainForm);
            }
        }
    }
}
