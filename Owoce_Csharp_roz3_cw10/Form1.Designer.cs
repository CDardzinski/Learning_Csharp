namespace Owoce_Csharp_roz3_cw10
{
    partial class Form1
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
            this.BananaPictureBox = new System.Windows.Forms.PictureBox();
            this.ApplePictureBox = new System.Windows.Forms.PictureBox();
            this.OrangePictureBox = new System.Windows.Forms.PictureBox();
            this.PearPictureBox = new System.Windows.Forms.PictureBox();
            this.BananaKcalLabel = new System.Windows.Forms.Label();
            this.AppleKcalLabel = new System.Windows.Forms.Label();
            this.OrangeKcalLabel = new System.Windows.Forms.Label();
            this.PearKcalLabel = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.KcalSumLabel = new System.Windows.Forms.Label();
            this.SumCaloryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BananaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrangePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PearPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BananaPictureBox
            // 
            this.BananaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BananaPictureBox.Image = global::Owoce_Csharp_roz3_cw10.Properties.Resources.Banana;
            this.BananaPictureBox.Location = new System.Drawing.Point(35, 28);
            this.BananaPictureBox.Name = "BananaPictureBox";
            this.BananaPictureBox.Size = new System.Drawing.Size(130, 130);
            this.BananaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BananaPictureBox.TabIndex = 0;
            this.BananaPictureBox.TabStop = false;
            this.BananaPictureBox.Click += new System.EventHandler(this.BananaPictureBox_Click);
            // 
            // ApplePictureBox
            // 
            this.ApplePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApplePictureBox.Image = global::Owoce_Csharp_roz3_cw10.Properties.Resources.Apple;
            this.ApplePictureBox.Location = new System.Drawing.Point(193, 28);
            this.ApplePictureBox.Name = "ApplePictureBox";
            this.ApplePictureBox.Size = new System.Drawing.Size(130, 130);
            this.ApplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ApplePictureBox.TabIndex = 1;
            this.ApplePictureBox.TabStop = false;
            this.ApplePictureBox.Click += new System.EventHandler(this.ApplePictureBox_Click);
            // 
            // OrangePictureBox
            // 
            this.OrangePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrangePictureBox.Image = global::Owoce_Csharp_roz3_cw10.Properties.Resources.Orange;
            this.OrangePictureBox.Location = new System.Drawing.Point(35, 193);
            this.OrangePictureBox.Name = "OrangePictureBox";
            this.OrangePictureBox.Size = new System.Drawing.Size(130, 130);
            this.OrangePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OrangePictureBox.TabIndex = 2;
            this.OrangePictureBox.TabStop = false;
            this.OrangePictureBox.Click += new System.EventHandler(this.OrangePictureBox_Click);
            // 
            // PearPictureBox
            // 
            this.PearPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PearPictureBox.Image = global::Owoce_Csharp_roz3_cw10.Properties.Resources.Pear;
            this.PearPictureBox.Location = new System.Drawing.Point(193, 193);
            this.PearPictureBox.Name = "PearPictureBox";
            this.PearPictureBox.Size = new System.Drawing.Size(130, 130);
            this.PearPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PearPictureBox.TabIndex = 3;
            this.PearPictureBox.TabStop = false;
            this.PearPictureBox.Click += new System.EventHandler(this.PearPictureBox_Click);
            // 
            // BananaKcalLabel
            // 
            this.BananaKcalLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BananaKcalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BananaKcalLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BananaKcalLabel.Location = new System.Drawing.Point(35, 156);
            this.BananaKcalLabel.Name = "BananaKcalLabel";
            this.BananaKcalLabel.Size = new System.Drawing.Size(130, 23);
            this.BananaKcalLabel.TabIndex = 4;
            this.BananaKcalLabel.Text = "115 kalorii";
            this.BananaKcalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppleKcalLabel
            // 
            this.AppleKcalLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AppleKcalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AppleKcalLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AppleKcalLabel.Location = new System.Drawing.Point(193, 156);
            this.AppleKcalLabel.Name = "AppleKcalLabel";
            this.AppleKcalLabel.Size = new System.Drawing.Size(130, 23);
            this.AppleKcalLabel.TabIndex = 5;
            this.AppleKcalLabel.Text = "80 kalorii";
            this.AppleKcalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrangeKcalLabel
            // 
            this.OrangeKcalLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrangeKcalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrangeKcalLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OrangeKcalLabel.Location = new System.Drawing.Point(35, 321);
            this.OrangeKcalLabel.Name = "OrangeKcalLabel";
            this.OrangeKcalLabel.Size = new System.Drawing.Size(130, 23);
            this.OrangeKcalLabel.TabIndex = 6;
            this.OrangeKcalLabel.Text = "90 kalorii";
            this.OrangeKcalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PearKcalLabel
            // 
            this.PearKcalLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PearKcalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PearKcalLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PearKcalLabel.Location = new System.Drawing.Point(193, 321);
            this.PearKcalLabel.Name = "PearKcalLabel";
            this.PearKcalLabel.Size = new System.Drawing.Size(130, 23);
            this.PearKcalLabel.TabIndex = 7;
            this.PearKcalLabel.Text = "120 kalorii";
            this.PearKcalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(377, 321);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 8;
            this.QuitButton.Text = "Zakończ";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(377, 283);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Wyczyść";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // KcalSumLabel
            // 
            this.KcalSumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KcalSumLabel.Location = new System.Drawing.Point(362, 52);
            this.KcalSumLabel.Name = "KcalSumLabel";
            this.KcalSumLabel.Size = new System.Drawing.Size(100, 23);
            this.KcalSumLabel.TabIndex = 10;
            this.KcalSumLabel.Text = "0";
            this.KcalSumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SumCaloryLabel
            // 
            this.SumCaloryLabel.AutoSize = true;
            this.SumCaloryLabel.Location = new System.Drawing.Point(374, 28);
            this.SumCaloryLabel.Name = "SumCaloryLabel";
            this.SumCaloryLabel.Size = new System.Drawing.Size(70, 13);
            this.SumCaloryLabel.TabIndex = 11;
            this.SumCaloryLabel.Text = "Razem kalorii";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 381);
            this.Controls.Add(this.SumCaloryLabel);
            this.Controls.Add(this.KcalSumLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.PearKcalLabel);
            this.Controls.Add(this.OrangeKcalLabel);
            this.Controls.Add(this.AppleKcalLabel);
            this.Controls.Add(this.BananaKcalLabel);
            this.Controls.Add(this.PearPictureBox);
            this.Controls.Add(this.OrangePictureBox);
            this.Controls.Add(this.ApplePictureBox);
            this.Controls.Add(this.BananaPictureBox);
            this.Name = "Form1";
            this.Text = "Ćwiczenie 10";
            ((System.ComponentModel.ISupportInitialize)(this.BananaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrangePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PearPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BananaPictureBox;
        private System.Windows.Forms.PictureBox ApplePictureBox;
        private System.Windows.Forms.PictureBox OrangePictureBox;
        private System.Windows.Forms.PictureBox PearPictureBox;
        private System.Windows.Forms.Label BananaKcalLabel;
        private System.Windows.Forms.Label AppleKcalLabel;
        private System.Windows.Forms.Label OrangeKcalLabel;
        private System.Windows.Forms.Label PearKcalLabel;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label KcalSumLabel;
        private System.Windows.Forms.Label SumCaloryLabel;
    }
}

