using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace EightbornLauncher
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool instanceCountOne = false;

            using (Mutex mtex = new Mutex(true, "MyRunningApp", out instanceCountOne))
            {
                if (instanceCountOne)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());
                    mtex.ReleaseMutex();
                }
                else
                {
                    MessageBox.Show("Launcher zaten çalışıyor!","HATA",MessageBoxButtons.OK);
                }
            }
        }
    }
}
