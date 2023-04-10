namespace Owoce_Csharp_roz4_przyklad4_5
{
    partial class ColorTheme
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
            this.ColorGroupBox = new System.Windows.Forms.GroupBox();
            this.NormalRadioButton = new System.Windows.Forms.RadioButton();
            this.WhiteRadioButton = new System.Windows.Forms.RadioButton();
            this.RedRadioButton = new System.Windows.Forms.RadioButton();
            this.YellowRadioButton = new System.Windows.Forms.RadioButton();
            this.QuitButton = new System.Windows.Forms.Button();
            this.ColorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorGroupBox
            // 
            this.ColorGroupBox.Controls.Add(this.NormalRadioButton);
            this.ColorGroupBox.Controls.Add(this.WhiteRadioButton);
            this.ColorGroupBox.Controls.Add(this.RedRadioButton);
            this.ColorGroupBox.Controls.Add(this.YellowRadioButton);
            this.ColorGroupBox.Location = new System.Drawing.Point(52, 44);
            this.ColorGroupBox.Name = "ColorGroupBox";
            this.ColorGroupBox.Size = new System.Drawing.Size(239, 162);
            this.ColorGroupBox.TabIndex = 0;
            this.ColorGroupBox.TabStop = false;
            this.ColorGroupBox.Text = "Wybierz kolor tła";
            // 
            // NormalRadioButton
            // 
            this.NormalRadioButton.AutoSize = true;
            this.NormalRadioButton.Checked = true;
            this.NormalRadioButton.Location = new System.Drawing.Point(65, 104);
            this.NormalRadioButton.Name = "NormalRadioButton";
            this.NormalRadioButton.Size = new System.Drawing.Size(114, 17);
            this.NormalRadioButton.TabIndex = 3;
            this.NormalRadioButton.TabStop = true;
            this.NormalRadioButton.Text = "Przywróć domyślny";
            this.NormalRadioButton.UseVisualStyleBackColor = true;
            this.NormalRadioButton.CheckedChanged += new System.EventHandler(this.NormalRadioButton_CheckedChanged);
            // 
            // WhiteRadioButton
            // 
            this.WhiteRadioButton.AutoSize = true;
            this.WhiteRadioButton.Location = new System.Drawing.Point(65, 81);
            this.WhiteRadioButton.Name = "WhiteRadioButton";
            this.WhiteRadioButton.Size = new System.Drawing.Size(49, 17);
            this.WhiteRadioButton.TabIndex = 2;
            this.WhiteRadioButton.Text = "Biały";
            this.WhiteRadioButton.UseVisualStyleBackColor = true;
            this.WhiteRadioButton.CheckedChanged += new System.EventHandler(this.WhiteRadioButton_CheckedChanged);
            // 
            // RedRadioButton
            // 
            this.RedRadioButton.AutoSize = true;
            this.RedRadioButton.Location = new System.Drawing.Point(65, 58);
            this.RedRadioButton.Name = "RedRadioButton";
            this.RedRadioButton.Size = new System.Drawing.Size(71, 17);
            this.RedRadioButton.TabIndex = 1;
            this.RedRadioButton.Text = "Czerwony";
            this.RedRadioButton.UseVisualStyleBackColor = true;
            this.RedRadioButton.CheckedChanged += new System.EventHandler(this.RedRadioButton_CheckedChanged);
            // 
            // YellowRadioButton
            // 
            this.YellowRadioButton.AutoSize = true;
            this.YellowRadioButton.Location = new System.Drawing.Point(65, 35);
            this.YellowRadioButton.Name = "YellowRadioButton";
            this.YellowRadioButton.Size = new System.Drawing.Size(50, 17);
            this.YellowRadioButton.TabIndex = 0;
            this.YellowRadioButton.Text = "Żółty";
            this.YellowRadioButton.UseVisualStyleBackColor = true;
            this.YellowRadioButton.CheckedChanged += new System.EventHandler(this.YellowRadioButton_CheckedChanged);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(130, 239);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 1;
            this.QuitButton.Text = "Zakończ";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // ColorTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 317);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.ColorGroupBox);
            this.Name = "ColorTheme";
            this.Text = "Color Theme";
            this.ColorGroupBox.ResumeLayout(false);
            this.ColorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ColorGroupBox;
        private System.Windows.Forms.RadioButton RedRadioButton;
        private System.Windows.Forms.RadioButton YellowRadioButton;
        private System.Windows.Forms.RadioButton NormalRadioButton;
        private System.Windows.Forms.RadioButton WhiteRadioButton;
        private System.Windows.Forms.Button QuitButton;
    }
}

