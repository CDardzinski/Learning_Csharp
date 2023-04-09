namespace Owoce_Csharp_roz2_cw1
{
    partial class translatorPanel
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
            this.sinisterButton = new System.Windows.Forms.Button();
            this.dexterButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.translateLabel = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sinisterButton
            // 
            this.sinisterButton.Location = new System.Drawing.Point(72, 43);
            this.sinisterButton.Name = "sinisterButton";
            this.sinisterButton.Size = new System.Drawing.Size(75, 23);
            this.sinisterButton.TabIndex = 0;
            this.sinisterButton.Text = "sinister";
            this.sinisterButton.UseVisualStyleBackColor = true;
            this.sinisterButton.Click += new System.EventHandler(this.sinisterButton_Click);
            // 
            // dexterButton
            // 
            this.dexterButton.Location = new System.Drawing.Point(72, 92);
            this.dexterButton.Name = "dexterButton";
            this.dexterButton.Size = new System.Drawing.Size(75, 23);
            this.dexterButton.TabIndex = 1;
            this.dexterButton.Text = "dexter";
            this.dexterButton.UseVisualStyleBackColor = true;
            this.dexterButton.Click += new System.EventHandler(this.dexterButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.Location = new System.Drawing.Point(72, 147);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(75, 23);
            this.mediumButton.TabIndex = 2;
            this.mediumButton.Text = "medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // translateLabel
            // 
            this.translateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.translateLabel.Location = new System.Drawing.Point(199, 43);
            this.translateLabel.Name = "translateLabel";
            this.translateLabel.Size = new System.Drawing.Size(127, 127);
            this.translateLabel.TabIndex = 3;
            this.translateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(148, 232);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 4;
            this.QuitButton.Text = "Wyjście";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // translatorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 298);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.translateLabel);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.dexterButton);
            this.Controls.Add(this.sinisterButton);
            this.Name = "translatorPanel";
            this.Text = "Translator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sinisterButton;
        private System.Windows.Forms.Button dexterButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Label translateLabel;
        private System.Windows.Forms.Button QuitButton;
    }
}

