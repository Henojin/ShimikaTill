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
    public partial class alert : Form
    {
        private string dialogmess; //引数を受け取って入れるための変数
        int mfx;
        int mfy;

        public alert(string dialogmess,int mfx ,int mfy)
        {
            InitializeComponent();
            this.dialogmess = dialogmess;　//プライベートな変数に受け取った引数を代入。
            this.mfx = mfx;
            this.mfy = mfy;
        }

        private void nobutton_Click(object sender, EventArgs e)
        {
            /* 没
            KeyEventArgs keyEventArgs = new KeyEventArgs(Keys.Enter);
            nobutton_KeyDown(sender, keyEventArgs);
            */
            this.DialogResult = DialogResult.No;
        }

        private void yesbutton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void alert_Load(object sender, EventArgs e)
        {
            int sch = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            int scw = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            if (scw == 800 && sch == 600) { 
                this.Location = new Point(120, 200);
            }
            else
            {
                this.Location = new Point(mfx + 120, mfy + 200);
            }
            AlertMessage.Text = dialogmess;　//表示
        }

        private void nobutton_KeyDown(object sender, KeyEventArgs e)
        {
            /*没予定
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            */
        }

        private void alert_KeyDown(object sender, KeyEventArgs e)
        {
            

        }
    }
}
