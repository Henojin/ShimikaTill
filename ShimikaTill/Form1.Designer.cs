namespace ShimikaTill
{
    partial class Form1
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
            this.ClockLabel = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.TaxFreeKakaku = new System.Windows.Forms.TextBox();
            this.GoToOsiharai = new System.Windows.Forms.Button();
            this.TotalCount = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SumCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SumKakaku = new System.Windows.Forms.TextBox();
            this.JanTextBox = new System.Windows.Forms.TextBox();
            this.Hiduke = new System.Windows.Forms.Label();
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
            this.button1.BackgroundImage = global::ShimikaTill.Properties.Resources.閉じる;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(726, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 64);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TaxFreeKakaku
            // 
            this.TaxFreeKakaku.BackColor = System.Drawing.Color.White;
            this.TaxFreeKakaku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaxFreeKakaku.Font = new System.Drawing.Font("BIZ UDPゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TaxFreeKakaku.Location = new System.Drawing.Point(191, 491);
            this.TaxFreeKakaku.Name = "TaxFreeKakaku";
            this.TaxFreeKakaku.ReadOnly = true;
            this.TaxFreeKakaku.Size = new System.Drawing.Size(146, 31);
            this.TaxFreeKakaku.TabIndex = 2;
            // 
            // GoToOsiharai
            // 
            this.GoToOsiharai.BackColor = System.Drawing.Color.Transparent;
            this.GoToOsiharai.BackgroundImage = global::ShimikaTill.Properties.Resources.okaikei;
            this.GoToOsiharai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GoToOsiharai.Location = new System.Drawing.Point(656, 545);
            this.GoToOsiharai.Name = "GoToOsiharai";
            this.GoToOsiharai.Size = new System.Drawing.Size(132, 52);
            this.GoToOsiharai.TabIndex = 3;
            this.GoToOsiharai.UseVisualStyleBackColor = false;
            // 
            // TotalCount
            // 
            this.TotalCount.AutoSize = true;
            this.TotalCount.BackColor = System.Drawing.Color.Transparent;
            this.TotalCount.Font = new System.Drawing.Font("BIZ UDPゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TotalCount.Location = new System.Drawing.Point(126, 499);
            this.TotalCount.Name = "TotalCount";
            this.TotalCount.Size = new System.Drawing.Size(59, 13);
            this.TotalCount.TabIndex = 4;
            this.TotalCount.Text = "税抜価格";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::ShimikaTill.Properties.Resources.ItemBt;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("BIZ UDPゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(13, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "業務選択";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "合計点数";
            // 
            // SumCount
            // 
            this.SumCount.BackColor = System.Drawing.Color.White;
            this.SumCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SumCount.Font = new System.Drawing.Font("BIZ UDPゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SumCount.Location = new System.Drawing.Point(402, 491);
            this.SumCount.Name = "SumCount";
            this.SumCount.ReadOnly = true;
            this.SumCount.Size = new System.Drawing.Size(106, 31);
            this.SumCount.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "合計金額";
            // 
            // SumKakaku
            // 
            this.SumKakaku.BackColor = System.Drawing.Color.White;
            this.SumKakaku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SumKakaku.Font = new System.Drawing.Font("BIZ UDPゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SumKakaku.Location = new System.Drawing.Point(573, 491);
            this.SumKakaku.Name = "SumKakaku";
            this.SumKakaku.ReadOnly = true;
            this.SumKakaku.Size = new System.Drawing.Size(214, 31);
            this.SumKakaku.TabIndex = 9;
            // 
            // JanTextBox
            // 
            this.JanTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JanTextBox.Font = new System.Drawing.Font("BIZ UDPゴシック", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JanTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.JanTextBox.Location = new System.Drawing.Point(4, 552);
            this.JanTextBox.Name = "JanTextBox";
            this.JanTextBox.Size = new System.Drawing.Size(646, 36);
            this.JanTextBox.TabIndex = 10;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShimikaTill.Properties.Resources.back2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Hiduke);
            this.Controls.Add(this.JanTextBox);
            this.Controls.Add(this.SumKakaku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SumCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TotalCount);
            this.Controls.Add(this.GoToOsiharai);
            this.Controls.Add(this.TaxFreeKakaku);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClockLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TaxFreeKakaku;
        private System.Windows.Forms.Button GoToOsiharai;
        private System.Windows.Forms.Label TotalCount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SumCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SumKakaku;
        private System.Windows.Forms.TextBox JanTextBox;
        private System.Windows.Forms.Label Hiduke;
    }
}

