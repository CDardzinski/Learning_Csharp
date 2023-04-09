namespace Owoce_Csharp_roz2_cw5
{
    partial class CoinSidePanel
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
            this.HeadsPictureBox = new System.Windows.Forms.PictureBox();
            this.TailsPictureBox = new System.Windows.Forms.PictureBox();
            this.ShowTailsButton = new System.Windows.Forms.Button();
            this.ShowHeadButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HeadsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TailsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadsPictureBox
            // 
            this.HeadsPictureBox.Image = global::Owoce_Csharp_roz2_cw5.Properties.Resources.Heads2;
            this.HeadsPictureBox.Location = new System.Drawing.Point(56, 45);
            this.HeadsPictureBox.Name = "HeadsPictureBox";
            this.HeadsPictureBox.Size = new System.Drawing.Size(278, 274);
            this.HeadsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HeadsPictureBox.TabIndex = 0;
            this.HeadsPictureBox.TabStop = false;
            // 
            // TailsPictureBox
            // 
            this.TailsPictureBox.Image = global::Owoce_Csharp_roz2_cw5.Properties.Resources.Tails2;
            this.TailsPictureBox.Location = new System.Drawing.Point(453, 45);
            this.TailsPictureBox.Name = "TailsPictureBox";
            this.TailsPictureBox.Size = new System.Drawing.Size(278, 274);
            this.TailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TailsPictureBox.TabIndex = 1;
            this.TailsPictureBox.TabStop = false;
            this.TailsPictureBox.Visible = false;
            // 
            // ShowTailsButton
            // 
            this.ShowTailsButton.Location = new System.Drawing.Point(104, 350);
            this.ShowTailsButton.Name = "ShowTailsButton";
            this.ShowTailsButton.Size = new System.Drawing.Size(137, 64);
            this.ShowTailsButton.TabIndex = 2;
            this.ShowTailsButton.Text = "Pokaż orła";
            this.ShowTailsButton.UseVisualStyleBackColor = true;
            this.ShowTailsButton.Click += new System.EventHandler(this.ShowTailsButton_Click);
            // 
            // ShowHeadButton
            // 
            this.ShowHeadButton.Location = new System.Drawing.Point(321, 350);
            this.ShowHeadButton.Name = "ShowHeadButton";
            this.ShowHeadButton.Size = new System.Drawing.Size(137, 64);
            this.ShowHeadButton.TabIndex = 3;
            this.ShowHeadButton.Text = "Pokaż reszkę";
            this.ShowHeadButton.UseVisualStyleBackColor = true;
            this.ShowHeadButton.Click += new System.EventHandler(this.ShowHeadButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(554, 350);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(137, 64);
            this.QuitButton.TabIndex = 4;
            this.QuitButton.Text = "Wyjście";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // CoinSidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.ShowHeadButton);
            this.Controls.Add(this.ShowTailsButton);
            this.Controls.Add(this.TailsPictureBox);
            this.Controls.Add(this.HeadsPictureBox);
            this.Name = "CoinSidePanel";
            this.Text = "Heads or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.HeadsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TailsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HeadsPictureBox;
        private System.Windows.Forms.PictureBox TailsPictureBox;
        private System.Windows.Forms.Button ShowTailsButton;
        private System.Windows.Forms.Button ShowHeadButton;
        private System.Windows.Forms.Button QuitButton;
    }
}

