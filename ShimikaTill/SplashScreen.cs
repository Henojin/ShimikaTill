using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ShimikaTill
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            int sch = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            int scw = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            int windowx = scw / 2 - 320;
            int windowy = sch / 2 - 180;
            this.Location = new Point(windowx, windowy);
            timer1.Interval = 2000;
            timer1.Start();
        }

        int vx;

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
            
        }
    }
}
