namespace ShimikaTill
{
    partial class alert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nobutton = new System.Windows.Forms.Button();
            this.yesbutton = new System.Windows.Forms.Button();
            this.AlertMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nobutton
            // 
            this.nobutton.BackColor = System.Drawing.Color.Transparent;
            this.nobutton.BackgroundImage = global::ShimikaTill.Properties.Resources.button_grey;
            this.nobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nobutton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nobutton.Location = new System.Drawing.Point(401, 147);
            this.nobutton.Name = "nobutton";
            this.nobutton.Size = new System.Drawing.Size(121, 35);
            this.nobutton.TabIndex = 1;
            this.nobutton.Text = "いいえ";
            this.nobutton.UseVisualStyleBackColor = false;
            this.nobutton.Click += new System.EventHandler(this.nobutton_Click);
            // 
            // yesbutton
            // 
            this.yesbutton.BackColor = System.Drawing.Color.Transparent;
            this.yesbutton.BackgroundImage = global::ShimikaTill.Properties.Resources.button_grey;
            this.yesbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesbutton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.yesbutton.Location = new System.Drawing.Point(274, 147);
            this.yesbutton.Name = "yesbutton";
            this.yesbutton.Size = new System.Drawing.Size(121, 35);
            this.yesbutton.TabIndex = 2;
            this.yesbutton.Text = "はい";
            this.yesbutton.UseVisualStyleBackColor = false;
            this.yesbutton.Click += new System.EventHandler(this.yesbutton_Click);
            // 
            // AlertMessage
            // 
            this.AlertMessage.AutoSize = true;
            this.AlertMessage.BackColor = System.Drawing.Color.Transparent;
            this.AlertMessage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AlertMessage.Location = new System.Drawing.Point(142, 57);
            this.AlertMessage.Name = "AlertMessage";
            this.AlertMessage.Size = new System.Drawing.Size(66, 21);
            this.AlertMessage.TabIndex = 3;
            this.AlertMessage.Text = "label1";
            // 
            // alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShimikaTill.Properties.Resources.dialog;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 194);
            this.Controls.Add(this.AlertMessage);
            this.Controls.Add(this.yesbutton);
            this.Controls.Add(this.nobutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "alert";
            this.Text = "alert";
            this.Load += new System.EventHandler(this.alert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nobutton;
        private System.Windows.Forms.Button yesbutton;
        private System.Windows.Forms.Label AlertMessage;
    }
}