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
    public partial class ShimikaTill : Form
    {
        static string infodialogmessage;
        public static bool exityesorno;
        public ShimikaTill()
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
            ClockLabel.Text = (date.ToString("HH" + ":" + date.ToString("mm")));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            infodialogmessage = "終了しますか？\n店員以外はこの操作を行わないでください。"; //infoダイアログに表示させるメッセージを代入。
            SoundPlayer player = new SoundPlayer(Properties.Resources.sound_alert);
            var alertform = new alert(infodialogmessage);//infoダイアログに情報を渡すように引数を指定。
            player.Play(); // 非同期で再生
            if (alertform.ShowDialog() == DialogResult.OK) { 
                this.Close();
            }
        }

        private void GoToOsiharai_Click(object sender, EventArgs e)
        {
            infodialogmessage = "会計しますか？"; //infoダイアログに表示させるメッセージを代入。
            SoundPlayer player = new SoundPlayer(Properties.Resources.sound_alert);
            var alertform = new alert(infodialogmessage);//infoダイアログに情報を渡すように引数を指定。
            player.Play(); // 非同期で再生
            alertform.ShowDialog(); //表示
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

        private void button3_Click(object sender, EventArgs e)
        {
            infodialogmessage = "値引ダイアログです。"; //infoダイアログに表示させるメッセージを代入。
            SoundPlayer player = new SoundPlayer(Properties.Resources.sound_alert);
            var infoform = new info(infodialogmessage);//infoダイアログに情報を渡すように引数を指定。
            player.Play(); // 非同期で再生
            infoform.ShowDialog();　//表示
        }

        private void button4_Click(object sender, EventArgs e)
        {
            infodialogmessage = "税区分ダイアログです。"; //infoダイアログに表示させるメッセージを代入。
            SoundPlayer player = new SoundPlayer(Properties.Resources.sound_alert);
            var infoform = new info(infodialogmessage);//infoダイアログに情報を渡すように引数を指定。
            player.Play(); // 非同期で再生
            infoform.ShowDialog();　//表示
        }

        private void button5_Click(object sender, EventArgs e)
        {
            infodialogmessage = "領収書ダイアログです。"; //infoダイアログに表示させるメッセージを代入。
            SoundPlayer player = new SoundPlayer(Properties.Resources.sound_alert);
            var infoform = new info(infodialogmessage);//infoダイアログに情報を渡すように引数を指定。
            player.Play(); // 非同期で再生
            infoform.ShowDialog();　//表示
        }

        private void button6_Click(object sender, EventArgs e)
        {
            infodialogmessage = "取消ダイアログです。"; //infoダイアログに表示させるメッセージを代入。
            SoundPlayer player = new SoundPlayer(Properties.Resources.sound_alert);
            var infoform = new info(infodialogmessage);//infoダイアログに情報を渡すように引数を指定。
            player.Play(); // 非同期で再生
            infoform.ShowDialog();　//表示
        }

        private void button7_Click(object sender, EventArgs e)
        {
            infodialogmessage = "返品/返金ダイアログです。"; //infoダイアログに表示させるメッセージを代入。
            SoundPlayer player = new SoundPlayer(Properties.Resources.sound_alert);
            var infoform = new info(infodialogmessage);//infoダイアログに情報を渡すように引数を指定。
            player.Play(); // 非同期で再生
            infoform.ShowDialog();　//表示
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
