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
    public partial class Inputdialo : Form
    {
        private int mfx;
        private int mfy;
        public string TextBox1Str { get; private set; } = "";
        public Inputdialo(int mfx, int mfy)
        {
            InitializeComponent();
            this.mfx = mfx;
            this.mfy = mfy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             TextBox1Str = textBox1.Text;
            this.DialogResult = DialogResult.OK;
             

        }

        private void Inputdialo_Load(object sender, EventArgs e)
        {
            int sch = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            int scw = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            ShimikaTillForm mainform = new ShimikaTillForm();
            Point mfpoint = mainform.Location;
            

            if (scw == 800 && sch == 600)
            {
                this.Location = new Point(120, 200);
            }
            else
            {

                this.Location = new Point(mfx + 120, mfy + 200);
            }

            textBox1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox1Str = textBox1.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
