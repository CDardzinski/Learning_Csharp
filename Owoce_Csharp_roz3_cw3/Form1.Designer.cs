namespace Owoce_Csharp_roz3_cw3
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
            this.CarSpeedLabel = new System.Windows.Forms.Label();
            this.CarSpeedTextBox = new System.Windows.Forms.TextBox();
            this.SpeedValLabel = new System.Windows.Forms.Label();
            this.FiveHoursLabel = new System.Windows.Forms.Label();
            this.EightHoursLabel = new System.Windows.Forms.Label();
            this.TwelveHoursLabel = new System.Windows.Forms.Label();
            this.FiveHoursTextBox = new System.Windows.Forms.TextBox();
            this.EightHoursTextBox = new System.Windows.Forms.TextBox();
            this.TwelveHoursTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.CalculeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarSpeedLabel
            // 
            this.CarSpeedLabel.AutoSize = true;
            this.CarSpeedLabel.Location = new System.Drawing.Point(175, 52);
            this.CarSpeedLabel.Name = "CarSpeedLabel";
            this.CarSpeedLabel.Size = new System.Drawing.Size(77, 13);
            this.CarSpeedLabel.TabIndex = 0;
            this.CarSpeedLabel.Text = "Szybkość auta";
            // 
            // CarSpeedTextBox
            // 
            this.CarSpeedTextBox.Location = new System.Drawing.Point(258, 49);
            this.CarSpeedTextBox.Name = "CarSpeedTextBox";
            this.CarSpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.CarSpeedTextBox.TabIndex = 1;
            // 
            // SpeedValLabel
            // 
            this.SpeedValLabel.AutoSize = true;
            this.SpeedValLabel.Location = new System.Drawing.Point(375, 52);
            this.SpeedValLabel.Name = "SpeedValLabel";
            this.SpeedValLabel.Size = new System.Drawing.Size(32, 13);
            this.SpeedValLabel.TabIndex = 2;
            this.SpeedValLabel.Text = "km/h";
            // 
            // FiveHoursLabel
            // 
            this.FiveHoursLabel.AutoSize = true;
            this.FiveHoursLabel.Location = new System.Drawing.Point(52, 80);
            this.FiveHoursLabel.Name = "FiveHoursLabel";
            this.FiveHoursLabel.Size = new System.Drawing.Size(200, 13);
            this.FiveHoursLabel.TabIndex = 3;
            this.FiveHoursLabel.Text = "Odległość przejechana w ciągu 5 godzin";
            // 
            // EightHoursLabel
            // 
            this.EightHoursLabel.AutoSize = true;
            this.EightHoursLabel.Location = new System.Drawing.Point(52, 113);
            this.EightHoursLabel.Name = "EightHoursLabel";
            this.EightHoursLabel.Size = new System.Drawing.Size(200, 13);
            this.EightHoursLabel.TabIndex = 4;
            this.EightHoursLabel.Text = "Odległość przejechana w ciągu 8 godzin";
            // 
            // TwelveHoursLabel
            // 
            this.TwelveHoursLabel.AutoSize = true;
            this.TwelveHoursLabel.Location = new System.Drawing.Point(46, 148);
            this.TwelveHoursLabel.Name = "TwelveHoursLabel";
            this.TwelveHoursLabel.Size = new System.Drawing.Size(206, 13);
            this.TwelveHoursLabel.TabIndex = 5;
            this.TwelveHoursLabel.Text = "Odległość przejechana w ciągu 12 godzin";
            // 
            // FiveHoursTextBox
            // 
            this.FiveHoursTextBox.Location = new System.Drawing.Point(258, 80);
            this.FiveHoursTextBox.Name = "FiveHoursTextBox";
            this.FiveHoursTextBox.ReadOnly = true;
            this.FiveHoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.FiveHoursTextBox.TabIndex = 6;
            // 
            // EightHoursTextBox
            // 
            this.EightHoursTextBox.Location = new System.Drawing.Point(258, 110);
            this.EightHoursTextBox.Name = "EightHoursTextBox";
            this.EightHoursTextBox.ReadOnly = true;
            this.EightHoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.EightHoursTextBox.TabIndex = 7;
            // 
            // TwelveHoursTextBox
            // 
            this.TwelveHoursTextBox.Location = new System.Drawing.Point(258, 145);
            this.TwelveHoursTextBox.Name = "TwelveHoursTextBox";
            this.TwelveHoursTextBox.ReadOnly = true;
            this.TwelveHoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.TwelveHoursTextBox.TabIndex = 8;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(375, 83);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(21, 13);
            this.label.TabIndex = 9;
            this.label.Text = "km";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "km";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "km";
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(332, 198);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 12;
            this.QuitButton.Text = "Zakończ";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // CalculeButton
            // 
            this.CalculeButton.Location = new System.Drawing.Point(121, 198);
            this.CalculeButton.Name = "CalculeButton";
            this.CalculeButton.Size = new System.Drawing.Size(75, 23);
            this.CalculeButton.TabIndex = 13;
            this.CalculeButton.Text = "Oblicz";
            this.CalculeButton.UseVisualStyleBackColor = true;
            this.CalculeButton.Click += new System.EventHandler(this.CalculeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 266);
            this.Controls.Add(this.CalculeButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.TwelveHoursTextBox);
            this.Controls.Add(this.EightHoursTextBox);
            this.Controls.Add(this.FiveHoursTextBox);
            this.Controls.Add(this.TwelveHoursLabel);
            this.Controls.Add(this.EightHoursLabel);
            this.Controls.Add(this.FiveHoursLabel);
            this.Controls.Add(this.SpeedValLabel);
            this.Controls.Add(this.CarSpeedTextBox);
            this.Controls.Add(this.CarSpeedLabel);
            this.Name = "Form1";
            this.Text = "Ćwiczenie 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CarSpeedLabel;
        private System.Windows.Forms.TextBox CarSpeedTextBox;
        private System.Windows.Forms.Label SpeedValLabel;
        private System.Windows.Forms.Label FiveHoursLabel;
        private System.Windows.Forms.Label EightHoursLabel;
        private System.Windows.Forms.Label TwelveHoursLabel;
        private System.Windows.Forms.TextBox FiveHoursTextBox;
        private System.Windows.Forms.TextBox EightHoursTextBox;
        private System.Windows.Forms.TextBox TwelveHoursTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button CalculeButton;
    }
}

