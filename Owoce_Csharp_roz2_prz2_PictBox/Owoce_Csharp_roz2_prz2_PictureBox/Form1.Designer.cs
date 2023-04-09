namespace Owoce_Csharp_roz2_prz2_PictureBox
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
            this.catPictureBox = new System.Windows.Forms.PictureBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.catPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // catPictureBox
            // 
            this.catPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catPictureBox.Image = global::Owoce_Csharp_roz2_prz2_PictureBox.Properties.Resources.Cat;
            this.catPictureBox.Location = new System.Drawing.Point(61, 59);
            this.catPictureBox.Name = "catPictureBox";
            this.catPictureBox.Size = new System.Drawing.Size(192, 189);
            this.catPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.catPictureBox.TabIndex = 0;
            this.catPictureBox.TabStop = false;
            this.catPictureBox.Click += new System.EventHandler(this.catPictureBox_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(122, 24);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(60, 13);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.Text = "kliknij kota!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 316);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.catPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.catPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox catPictureBox;
        private System.Windows.Forms.Label MessageLabel;
    }
}

