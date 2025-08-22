using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShimikaTill
{
    public partial class info : Form
    {
        private string dialogmess; //引数を受け取って入れるための変数
        private int mfx;
        private int mfy;

        public info(string dialogmess,int mfx,int mfy) //string値を受け取る
        {
            InitializeComponent();
            this.dialogmess = dialogmess;//プライベートな変数に受け取った引数を代入。
            this.mfx = mfx;
            this.mfy = mfy;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void info_Load(object sender, EventArgs e)
        {
            int sch = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            int scw = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            ShimikaTillForm mainform = new ShimikaTillForm();
            Point mfpoint = mainform.Location;
          
            if (scw == 800 && sch == 600)
            {
                this.Location = new Point(120, 200);
            }
            else {
                
                this.Location = new Point(mfx + 120, mfy+ 200);
            }
                
            InfoMessage.Text = dialogmess;　//表示
        }
    }
}
