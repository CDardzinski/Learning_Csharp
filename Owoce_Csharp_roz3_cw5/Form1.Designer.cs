namespace Owoce_Csharp_roz3_cw5
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
            this.TempEntryValLabel = new System.Windows.Forms.Label();
            this.TempEntredTextBox = new System.Windows.Forms.TextBox();
            this.ConvertTempTextBox = new System.Windows.Forms.TextBox();
            this.ConvertToCelsiusButton = new System.Windows.Forms.Button();
            this.ConvertToFahrenheitButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.TempValLabel = new System.Windows.Forms.Label();
            this.TempValBeforLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TempEntryValLabel
            // 
            this.TempEntryValLabel.AutoSize = true;
            this.TempEntryValLabel.Location = new System.Drawing.Point(56, 46);
            this.TempEntryValLabel.Name = "TempEntryValLabel";
            this.TempEntryValLabel.Size = new System.Drawing.Size(93, 13);
            this.TempEntryValLabel.TabIndex = 0;
            this.TempEntryValLabel.Text = "Podaj temperature";
            // 
            // TempEntredTextBox
            // 
            this.TempEntredTextBox.Location = new System.Drawing.Point(177, 43);
            this.TempEntredTextBox.Name = "TempEntredTextBox";
            this.TempEntredTextBox.Size = new System.Drawing.Size(100, 20);
            this.TempEntredTextBox.TabIndex = 1;
            // 
            // ConvertTempTextBox
            // 
            this.ConvertTempTextBox.Location = new System.Drawing.Point(255, 110);
            this.ConvertTempTextBox.Name = "ConvertTempTextBox";
            this.ConvertTempTextBox.ReadOnly = true;
            this.ConvertTempTextBox.Size = new System.Drawing.Size(100, 20);
            this.ConvertTempTextBox.TabIndex = 2;
            // 
            // ConvertToCelsiusButton
            // 
            this.ConvertToCelsiusButton.AutoSize = true;
            this.ConvertToCelsiusButton.Location = new System.Drawing.Point(59, 89);
            this.ConvertToCelsiusButton.Name = "ConvertToCelsiusButton";
            this.ConvertToCelsiusButton.Size = new System.Drawing.Size(163, 23);
            this.ConvertToCelsiusButton.TabIndex = 3;
            this.ConvertToCelsiusButton.Text = "Konwertuj na stopnie Celsjusza";
            this.ConvertToCelsiusButton.UseVisualStyleBackColor = true;
            this.ConvertToCelsiusButton.Click += new System.EventHandler(this.ConvertToCelsiusButton_Click);
            // 
            // ConvertToFahrenheitButton
            // 
            this.ConvertToFahrenheitButton.AutoSize = true;
            this.ConvertToFahrenheitButton.Location = new System.Drawing.Point(59, 137);
            this.ConvertToFahrenheitButton.Name = "ConvertToFahrenheitButton";
            this.ConvertToFahrenheitButton.Size = new System.Drawing.Size(175, 23);
            this.ConvertToFahrenheitButton.TabIndex = 4;
            this.ConvertToFahrenheitButton.Text = "Konwertuj na stopnie Fahrenheita";
            this.ConvertToFahrenheitButton.UseVisualStyleBackColor = true;
            this.ConvertToFahrenheitButton.Click += new System.EventHandler(this.ConvertToFahrenheitButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(280, 191);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 5;
            this.QuitButton.Text = "Zakończ";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // TempValLabel
            // 
            this.TempValLabel.AutoSize = true;
            this.TempValLabel.Location = new System.Drawing.Point(373, 113);
            this.TempValLabel.Name = "TempValLabel";
            this.TempValLabel.Size = new System.Drawing.Size(28, 13);
            this.TempValLabel.TabIndex = 6;
            this.TempValLabel.Text = "st. C";
            // 
            // TempValBeforLabel
            // 
            this.TempValBeforLabel.AutoSize = true;
            this.TempValBeforLabel.Location = new System.Drawing.Point(304, 46);
            this.TempValBeforLabel.Name = "TempValBeforLabel";
            this.TempValBeforLabel.Size = new System.Drawing.Size(0, 13);
            this.TempValBeforLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 245);
            this.Controls.Add(this.TempValBeforLabel);
            this.Controls.Add(this.TempValLabel);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.ConvertToFahrenheitButton);
            this.Controls.Add(this.ConvertToCelsiusButton);
            this.Controls.Add(this.ConvertTempTextBox);
            this.Controls.Add(this.TempEntredTextBox);
            this.Controls.Add(this.TempEntryValLabel);
            this.Name = "Form1";
            this.Text = "Ćwiczenie 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TempEntryValLabel;
        private System.Windows.Forms.TextBox TempEntredTextBox;
        private System.Windows.Forms.TextBox ConvertTempTextBox;
        private System.Windows.Forms.Button ConvertToCelsiusButton;
        private System.Windows.Forms.Button ConvertToFahrenheitButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label TempValLabel;
        private System.Windows.Forms.Label TempValBeforLabel;
    }
}

