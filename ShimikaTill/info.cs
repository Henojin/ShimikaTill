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
        public info(string dialogmess) //string値を受け取る
        {
            InitializeComponent();
            this.dialogmess = dialogmess;　//プライベートな変数に受け取った引数を代入。
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void info_Load(object sender, EventArgs e)
        {
            this.Location = new Point(120, 200);
            InfoMessage.Text = dialogmess;　//表示
        }
    }
}
