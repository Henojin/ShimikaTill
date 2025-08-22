using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace ShimikaTill
{
    public partial class Form1 : Form
    {
        static string infodialogmessage;
        public Form1()
        {
            InitializeComponent();
        }

        bool isformopen = false;



      

        private void Form1_Load(object sender, EventArgs e)
        {
            ClockTimer.Interval = 1000; //1秒に1回実行
            ClockTimer.Start(); //タイマーを開始
            this.Location = new Point(0, 0);
            JanTextBox.Text = "JANを入力";
        }

        private void ClockTimer_Tick(object sender, EventArgs e)　//タイマーによる時刻＆日付表示
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

        private void button2_Click(object sender, EventArgs e)
        {
            infodialogmessage = "業務選択ダイアログです。"; //infoダイアログに表示させるメッセージを代入。
            SoundPlayer player = new SoundPlayer(Properties.Resources.sound_alert);
            var infoform = new info(infodialogmessage);//infoダイアログに情報を渡すように引数を指定。
            player.Play(); // 非同期で再生
            infoform.ShowDialog();　//表示

        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }
    }
}
