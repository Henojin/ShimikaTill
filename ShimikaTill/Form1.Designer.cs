namespace ShimikaTill
{
    partial class ShimikaTillForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShimikaTillForm));
            this.ClockLabel = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.GoToOsiharai = new System.Windows.Forms.Button();
            this.TotalCount = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.JanTextBox = new System.Windows.Forms.TextBox();
            this.Hiduke = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ClockLabel
            // 
            this.ClockLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClockLabel.AutoSize = true;
            this.ClockLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClockLabel.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ClockLabel.ForeColor = System.Drawing.Color.Gray;
            this.ClockLabel.Location = new System.Drawing.Point(23, 47);
            this.ClockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(84, 29);
            this.ClockLabel.TabIndex = 0;
            this.ClockLabel.Text = "00:00";
            // 
            // ClockTimer
            // 
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ShimikaTill.Properties.Resources.close;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(740, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 54);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoToOsiharai
            // 
            this.GoToOsiharai.BackColor = System.Drawing.Color.Transparent;
            this.GoToOsiharai.BackgroundImage = global::ShimikaTill.Properties.Resources.button_orange;
            this.GoToOsiharai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GoToOsiharai.Font = new System.Drawing.Font("BIZ UDPゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GoToOsiharai.ForeColor = System.Drawing.Color.Transparent;
            this.GoToOsiharai.Location = new System.Drawing.Point(667, 546);
            this.GoToOsiharai.Name = "GoToOsiharai";
            this.GoToOsiharai.Size = new System.Drawing.Size(132, 52);
            this.GoToOsiharai.TabIndex = 3;
            this.GoToOsiharai.Text = "会計";
            this.GoToOsiharai.UseVisualStyleBackColor = false;
            this.GoToOsiharai.Click += new System.EventHandler(this.GoToOsiharai_Click);
            // 
            // TotalCount
            // 
            this.TotalCount.AutoSize = true;
            this.TotalCount.BackColor = System.Drawing.Color.Transparent;
            this.TotalCount.Font = new System.Drawing.Font("BIZ UDPゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TotalCount.Location = new System.Drawing.Point(128, 502);
            this.TotalCount.Name = "TotalCount";
            this.TotalCount.Size = new System.Drawing.Size(59, 13);
            this.TotalCount.TabIndex = 4;
            this.TotalCount.Text = "税抜価格";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::ShimikaTill.Properties.Resources.button_grey;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("BIZ UDPゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(10, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "業務選択";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(310, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "合計点数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(491, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "合計金額";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // JanTextBox
            // 
            this.JanTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JanTextBox.Font = new System.Drawing.Font("BIZ UDPゴシック", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JanTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.JanTextBox.Location = new System.Drawing.Point(14, 554);
            this.JanTextBox.Name = "JanTextBox";
            this.JanTextBox.Size = new System.Drawing.Size(622, 36);
            this.JanTextBox.TabIndex = 10;
            this.JanTextBox.TextChanged += new System.EventHandler(this.JanTextBox_TextChanged);
            this.JanTextBox.Enter += new System.EventHandler(this.JanTextBox_Enter);
            this.JanTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JanTextBox_KeyDown);
            this.JanTextBox.Leave += new System.EventHandler(this.JanTextBox_Leave);
            // 
            // Hiduke
            // 
            this.Hiduke.AutoSize = true;
            this.Hiduke.BackColor = System.Drawing.Color.Transparent;
            this.Hiduke.ForeColor = System.Drawing.Color.Gray;
            this.Hiduke.Location = new System.Drawing.Point(37, 24);
            this.Hiduke.Name = "Hiduke";
            this.Hiduke.Size = new System.Drawing.Size(45, 12);
            this.Hiduke.TabIndex = 11;
            this.Hiduke.Text = "1月1日";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::ShimikaTill.Properties.Resources.button_orange2;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("BIZ UDPゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(10, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 42);
            this.button3.TabIndex = 12;
            this.button3.Text = "値引";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::ShimikaTill.Properties.Resources.button_yellow;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("BIZ UDPゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button4.Location = new System.Drawing.Point(10, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 42);
            this.button4.TabIndex = 13;
            this.button4.Text = "税区分";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::ShimikaTill.Properties.Resources.button_blue;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Font = new System.Drawing.Font("BIZ UDPゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5.Location = new System.Drawing.Point(10, 327);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 42);
            this.button5.TabIndex = 14;
            this.button5.Text = "領収書";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::ShimikaTill.Properties.Resources.button_red;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Font = new System.Drawing.Font("BIZ UDPゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button6.Location = new System.Drawing.Point(10, 394);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 42);
            this.button6.TabIndex = 15;
            this.button6.Text = "取消";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = global::ShimikaTill.Properties.Resources.button_red1;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Font = new System.Drawing.Font("BIZ UDPゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button7.Location = new System.Drawing.Point(10, 461);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 42);
            this.button7.TabIndex = 16;
            this.button7.Text = "返品/返金";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("BIZ UDPゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(125, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(514, 48);
            this.label3.TabIndex = 17;
            this.label3.Text = "ShimikaTillへようこそ​\r\n商品をスキャン または JANを入力してください";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("BIZ UDPゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(192, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "0円";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("BIZ UDPゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(368, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "0点";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("BIZ UDPゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(549, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "0円";
            // 
            // list
            // 
            this.list.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 31;
            this.list.Location = new System.Drawing.Point(124, 109);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(667, 376);
            this.list.TabIndex = 21;
            this.list.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ShimikaTillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShimikaTill.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.list);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Hiduke);
            this.Controls.Add(this.JanTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TotalCount);
            this.Controls.Add(this.GoToOsiharai);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClockLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShimikaTillForm";
            this.Text = "ShimikaTill";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShimikaTillForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShimikaTillForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GoToOsiharai;
        private System.Windows.Forms.Label TotalCount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox JanTextBox;
        private System.Windows.Forms.Label Hiduke;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox list;
    }
}

