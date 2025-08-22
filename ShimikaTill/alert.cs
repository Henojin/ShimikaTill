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
        public alert(string dialogmess)
        {
            InitializeComponent();
            this.dialogmess = dialogmess;　//プライベートな変数に受け取った引数を代入。
        }

        private void nobutton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void yesbutton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void alert_Load(object sender, EventArgs e)
        {
            this.Location = new Point(120, 200);
            AlertMessage.Text = dialogmess;　//表示
        }
    }
}
