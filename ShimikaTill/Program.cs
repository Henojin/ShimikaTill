using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShimikaTill
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        
        
         static  void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.Show();
            splashScreen.Refresh();
           
            

            Application.Run(new ShimikaTillForm());
        }
    }
}
