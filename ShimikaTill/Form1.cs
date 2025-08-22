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
    
    public partial class ShimikaTillForm : Form
    {
        static string infodialogmessage;
        private Point mousePoint;
        public ShimikaTillForm()
        {
            InitializeComponent();
        }

     



      

        private void Form1_Load(object sender, EventArgs e)
        {
            int sch = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            int scw = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
           if (scw == 800 && sch == 600)
            {
                this.Location = new Point(0, 0);
             
            }
            ClockTimer.Interval = 1000; //1秒に1回実行
            ClockTimer.Start(); //タイマーを開始
            JanTextBox.Text = "JANを入力";
        }

        private void ClockTimer_Tick(object sender, EventArgs e)　//タイマーによる時刻＆日付表示
        {
            DateTime date = DateTime.Now;
            Hiduke.Text = date.Month + "月" + date.Day + "日";
            ClockLabel.Text = (date.ToString("HH" + ":" + date.ToString("mm")));
            //力技解決の例、ﾖｸﾅｲﾖ
            int sch = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            int scw = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            if (scw == 800 && sch == 600)
            {
                this.Location = new Point(0, 0);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            infodialogmessage = "終了しますか？\n店員以外はこの操作を行わないでください。"; //infoダイアログに表示させるメッセージを代入。
            SoundPlayer player = new SoundPlayer(Properties.Resources.sound_alert);
            int mfx = this.Location.X;
            int mfy = this.Location.Y;
            var alertform = new alert(infodialogmessage,mfx,mfy);//infoダイアログに情報を渡すように引数を指定。
            player.Play(); // 非同期で再生
            if (alertform.ShowDialog() == DialogResult.OK) { 
                this.Close();
            }
        }

        private void GoToOsiharai_Click(object sender, EventArgs e)
        {
            infodialogmessage = "会計しますか？"; //infoダイアログに表示させるメッセージを代入。
            SoundPlayer player = new SoundPlayer(Properties.Resources.sound_alert);
            int mfx = this.Location.X;
            int mfy = this.Location.Y;
            var alertform = new alert(infodialogmessage, mfx, mfy);//infoダイアログに情報を渡すように引数を指定。
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
            int mfx = this.Location.X;
            int mfy = this.Location.Y;
            var infoform = new info(infodialogmessage,mfx, mfy);//infoダイアログに情報を渡すように引数を指定。
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
            int mfx = this.Location.X;
            int mfy = this.Location.Y;
            var infoform = new info(infodialogmessage, mfx, mfy);//infoダイアログに情報を渡すように引数を指定。
            player.Play(); // 非同期で再生
            infoform.ShowDialog();　//表示
        }

        private void button4_Click(object sender, EventArgs e)
        {
            infodialogmessage = "税区分ダイアログです。"; //infoダイアログに表示させるメッセージを代入。
            SoundPlayer player = new SoundPlayer(Properties.Resources.sound_alert);
            int mfx = this.Location.X;
            int mfy = this.Location.Y;
            var infoform = new info(infodialogmessage, mfx, mfy);//infoダイアログに情報を渡すように引数を指定。
            player.Play(); // 非同期で再生
            infoform.ShowDialog();　//表示
        }

        private void button5_Click(object sender, EventArgs e)
        {
            infodialogmessage = "領収書ダイアログです。"; //infoダイアログに表示させるメッセージを代入。
            SoundPlayer player = new SoundPlayer(Properties.Resources.sound_alert);
            int mfx = this.Location.X;
            int mfy = this.Location.Y;
            var infoform = new info(infodialogmessage, mfx, mfy);//infoダイアログに情報を渡すように引数を指定。
            player.Play(); // 非同期で再生
            infoform.ShowDialog();　//表示
        }

        private void button6_Click(object sender, EventArgs e)
        {
           if(list.SelectedIndex != -1)
            {
                infodialogmessage = "選択項目を取り消しますか？"; //infoダイアログに表示させるメッセージを代入。
                SoundPlayer player = new SoundPlayer(Properties.Resources.sound_alert);
                int mfx = this.Location.X;
                int mfy = this.Location.Y;
                var alertform = new alert(infodialogmessage, mfx, mfy);//infoダイアログに情報を渡すように引数を指定。
                player.Play(); // 非同期で再生
                if (alertform.ShowDialog() == DialogResult.OK)
                {
                    list.Items.Remove(list.SelectedItem);
                    label5.Text = (list.Items.Count + "点");
                }
            }
            else
            {

                infodialogmessage = "取消する項目がありません。"; //infoダイアログに表示させるメッセージを代入。
                SoundPlayer player = new SoundPlayer(Properties.Resources.sound_alert);
                int mfx = this.Location.X;
                int mfy = this.Location.Y;
                var infoform = new info(infodialogmessage, mfx, mfy);//infoダイアログに情報を渡すように引数を指定。
                player.Play(); // 非同期で再生
                infoform.ShowDialog();　//表示
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            infodialogmessage = "返品/返金ダイアログです。"; //infoダイアログに表示させるメッセージを代入。
            SoundPlayer player = new SoundPlayer(Properties.Resources.sound_alert);
            int mfx = this.Location.X;
            int mfy = this.Location.Y;
            var infoform = new info(infodialogmessage, mfx, mfy);//infoダイアログに情報を渡すように引数を指定。
            player.Play(); // 非同期で再生
            infoform.ShowDialog();　//表示
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void JanTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void JanTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (JanTextBox.Text != "")
                {
                    list.Items.Add(JanTextBox.Text);//アイテムついか
                    JanTextBox.Text = null; //テキストボックスを空にする
                    list.SelectedIndex = list.Items.Count - 1; //最後に入力したアイテムにフォーカスを合わせ、スクロール。
                    label5.Text = (list.Items.Count + "点");
                }
                else
                {
                    SoundPlayer player = new SoundPlayer(Properties.Resources.sound_alert);
                    player.Play();
                }
            }
        }

        private void JanTextBox_Leave(object sender, EventArgs e)
        {
            JanTextBox.Text = "JANを入力";
        }

        private void JanTextBox_Enter(object sender, EventArgs e)
        {
            JanTextBox.Text = null;
        }

        private void ShimikaTillForm_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                mousePoint = new Point(e.X, e.Y);
            }
        }

        private void ShimikaTillForm_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left){
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }
    }
}
