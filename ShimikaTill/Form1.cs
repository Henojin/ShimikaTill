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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClockTimer.Start();
            this.Location = new Point(0, 0);
            JanTextBox.Text = "JANを入力";
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            Hiduke.Text = date.Month + "月" + date.Day + "日";
            ClockLabel.Text = DateTime.Now.ToShortTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GoToOsiharai_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
