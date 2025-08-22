using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ShimikaTill
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SplashScreen splashScreen = new SplashScreen();
            splashScreen.Show();
            splashScreen.Refresh();
            Thread.Sleep(2000);
            splashScreen.Close();

            Application.Run(new ShimikaTill());
        }
    }
}
