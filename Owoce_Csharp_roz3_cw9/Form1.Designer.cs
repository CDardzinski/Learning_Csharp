namespace Owoce_Csharp_roz3_cw9
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
            this.HowManyEatenLabel = new System.Windows.Forms.Label();
            this.CaloryEatenLabel = new System.Windows.Forms.Label();
            this.HowManyEatenTextBox = new System.Windows.Forms.TextBox();
            this.CaloryEatenTextBox = new System.Windows.Forms.TextBox();
            this.CalculeButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HowManyEatenLabel
            // 
            this.HowManyEatenLabel.AutoSize = true;
            this.HowManyEatenLabel.Location = new System.Drawing.Point(61, 51);
            this.HowManyEatenLabel.Name = "HowManyEatenLabel";
            this.HowManyEatenLabel.Size = new System.Drawing.Size(139, 13);
            this.HowManyEatenLabel.TabIndex = 0;
            this.HowManyEatenLabel.Text = "Ilość zjedzonych ciasteczek";
            // 
            // CaloryEatenLabel
            // 
            this.CaloryEatenLabel.AutoSize = true;
            this.CaloryEatenLabel.Location = new System.Drawing.Point(61, 107);
            this.CaloryEatenLabel.Name = "CaloryEatenLabel";
            this.CaloryEatenLabel.Size = new System.Drawing.Size(79, 13);
            this.CaloryEatenLabel.TabIndex = 1;
            this.CaloryEatenLabel.Text = "Spożyte kalorie";
            // 
            // HowManyEatenTextBox
            // 
            this.HowManyEatenTextBox.Location = new System.Drawing.Point(260, 48);
            this.HowManyEatenTextBox.Name = "HowManyEatenTextBox";
            this.HowManyEatenTextBox.Size = new System.Drawing.Size(100, 20);
            this.HowManyEatenTextBox.TabIndex = 2;
            // 
            // CaloryEatenTextBox
            // 
            this.CaloryEatenTextBox.Location = new System.Drawing.Point(260, 104);
            this.CaloryEatenTextBox.Name = "CaloryEatenTextBox";
            this.CaloryEatenTextBox.ReadOnly = true;
            this.CaloryEatenTextBox.Size = new System.Drawing.Size(100, 20);
            this.CaloryEatenTextBox.TabIndex = 3;
            // 
            // CalculeButton
            // 
            this.CalculeButton.Location = new System.Drawing.Point(89, 180);
            this.CalculeButton.Name = "CalculeButton";
            this.CalculeButton.Size = new System.Drawing.Size(75, 23);
            this.CalculeButton.TabIndex = 4;
            this.CalculeButton.Text = "Oblicz";
            this.CalculeButton.UseVisualStyleBackColor = true;
            this.CalculeButton.Click += new System.EventHandler(this.CalculeButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(269, 180);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 5;
            this.QuitButton.Text = "Zakończ";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 250);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.CalculeButton);
            this.Controls.Add(this.CaloryEatenTextBox);
            this.Controls.Add(this.HowManyEatenTextBox);
            this.Controls.Add(this.CaloryEatenLabel);
            this.Controls.Add(this.HowManyEatenLabel);
            this.Name = "Form1";
            this.Text = "Ćwiczenie 9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HowManyEatenLabel;
        private System.Windows.Forms.Label CaloryEatenLabel;
        private System.Windows.Forms.TextBox HowManyEatenTextBox;
        private System.Windows.Forms.TextBox CaloryEatenTextBox;
        private System.Windows.Forms.Button CalculeButton;
        private System.Windows.Forms.Button QuitButton;
    }
}

