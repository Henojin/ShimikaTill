using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Xml.Linq;

namespace ShimikaTill
{
    
    public partial class ShimikaTillForm : Form
    {
        static string infodialogmessage;
        private Point mousePoint;
        static int SumPrice;
        static int PlusTaxPrice;
        public ShimikaTillForm()
        {
            InitializeComponent();
        }





        string configFilePath;

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
            string FullAppPath = Application.ExecutablePath;
            string dirPath = Path.GetDirectoryName(FullAppPath);
            configFilePath = Path.Combine(dirPath, "Items.xml");
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
            if (alertform.ShowDialog() == DialogResult.OK) // 表示&OKボタンが押された時の処理
            {
                list.Items.Clear(); //アイテムを全て削除
                SumPrice = 0;
                PlusTaxPrice = 0;
                label5.Text = (list.Items.Count + "点");//アイテム数を表示
                label4.Text = (SumPrice + "円"); //小計表示
                label6.Text = (PlusTaxPrice + "円");
            }

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
                //infodialogmessage = "選択項目を取り消しますか？"; //infoダイアログに表示させるメッセージを代入。
                SoundPlayer player = new SoundPlayer(Properties.Resources.sound_alert);
                int mfx = this.Location.X;
                int mfy = this.Location.Y;
                var inputform = new Inputdialo(mfx, mfy);//infoダイアログに情報を渡すように引数を指定。
                player.Play(); // 非同期で再生
                if(inputform.ShowDialog() == DialogResult.OK) { 
                    if(inputform.TextBox1Str == "") {
                        player.Play();
                    } else{

                        XDocument doc = XDocument.Load(configFilePath);
                        IEnumerable<XElement> items = doc.Descendants("Item");
                        foreach (XElement item in items)
                        {
                            string JAN = item.Element("JANCode").Value;
                            if (JAN == inputform.TextBox1Str)
                            {
                                string Iname = item.Element("Name").Value;
                                int PPrice = int.Parse(item.Element("Price").Value);
                                list.Items.Add("ﾄﾘｹｼ:" + Iname + "    @1: -" + PPrice + "円");
                                //Tax
                                double PTax = double.Parse(item.Element("TAX").Value);
                                SumPrice = SumPrice - PPrice;
                                double IncTax = PPrice * PTax;
                                PlusTaxPrice = PlusTaxPrice - (int)(IncTax);
                            }

                        }
                        label4.Text = (SumPrice + "円"); //小計
                        label5.Text = (list.Items.Count + "点");
                        label6.Text = (PlusTaxPrice + "円");//合計
                    }
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
            if (e.KeyCode == Keys.Enter) //ここでスキャン処理
            {
                if (JanTextBox.Text != "")
                {
                    XDocument doc = XDocument.Load(configFilePath);
                    IEnumerable<XElement> items = doc.Descendants("Item");
                    foreach (XElement item in items)
                    {
                        string JAN = item.Element("JANCode").Value;
                        if (JAN == JanTextBox.Text)
                        {
                            string Iname = item.Element("Name").Value;
                            int PPrice = int.Parse(item.Element("Price").Value);
                            list.Items.Add(""+ Iname +"    @1:" + PPrice + "円");
                                    //Tax
                                    double PTax = double.Parse(item.Element("TAX").Value);
                                    SumPrice = SumPrice + PPrice;
                                    double IncTax = PPrice * PTax;
                                    PlusTaxPrice = PlusTaxPrice +  (int)(IncTax);
                        }

                    }
                    label6.Text = (PlusTaxPrice + "円");//合計
                    label4.Text = ( SumPrice + "円"); //小計
                    
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
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }
    }
}
