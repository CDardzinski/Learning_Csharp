namespace Owoce_Csharp_roz3_cw6
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
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightValueLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightValueLabel = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.CalculeBmiButton = new System.Windows.Forms.Button();
            this.BmiTextBox = new System.Windows.Forms.TextBox();
            this.BmiLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(36, 38);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(36, 13);
            this.WeightLabel.TabIndex = 0;
            this.WeightLabel.Text = "Waga";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(36, 84);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(40, 13);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "Wzrost";
            // 
            // WeightValueLabel
            // 
            this.WeightValueLabel.AutoSize = true;
            this.WeightValueLabel.Location = new System.Drawing.Point(210, 38);
            this.WeightValueLabel.Name = "WeightValueLabel";
            this.WeightValueLabel.Size = new System.Drawing.Size(19, 13);
            this.WeightValueLabel.TabIndex = 2;
            this.WeightValueLabel.Text = "kg";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(93, 35);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.WeightTextBox.TabIndex = 3;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(93, 81);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.HeightTextBox.TabIndex = 4;
            // 
            // HeightValueLabel
            // 
            this.HeightValueLabel.AutoSize = true;
            this.HeightValueLabel.Location = new System.Drawing.Point(210, 84);
            this.HeightValueLabel.Name = "HeightValueLabel";
            this.HeightValueLabel.Size = new System.Drawing.Size(15, 13);
            this.HeightValueLabel.TabIndex = 5;
            this.HeightValueLabel.Text = "m";
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(108, 200);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 6;
            this.QuitButton.Text = "Zakończ";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // CalculeBmiButton
            // 
            this.CalculeBmiButton.Location = new System.Drawing.Point(108, 157);
            this.CalculeBmiButton.Name = "CalculeBmiButton";
            this.CalculeBmiButton.Size = new System.Drawing.Size(75, 23);
            this.CalculeBmiButton.TabIndex = 7;
            this.CalculeBmiButton.Text = "Oblicz BMI";
            this.CalculeBmiButton.UseVisualStyleBackColor = true;
            this.CalculeBmiButton.Click += new System.EventHandler(this.CalculeBmiButton_Click);
            // 
            // BmiTextBox
            // 
            this.BmiTextBox.Location = new System.Drawing.Point(93, 120);
            this.BmiTextBox.Name = "BmiTextBox";
            this.BmiTextBox.ReadOnly = true;
            this.BmiTextBox.Size = new System.Drawing.Size(100, 20);
            this.BmiTextBox.TabIndex = 8;
            // 
            // BmiLabel
            // 
            this.BmiLabel.AutoSize = true;
            this.BmiLabel.Location = new System.Drawing.Point(36, 123);
            this.BmiLabel.Name = "BmiLabel";
            this.BmiLabel.Size = new System.Drawing.Size(26, 13);
            this.BmiLabel.TabIndex = 9;
            this.BmiLabel.Text = "BMI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 265);
            this.Controls.Add(this.BmiLabel);
            this.Controls.Add(this.BmiTextBox);
            this.Controls.Add(this.CalculeBmiButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.HeightValueLabel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.WeightValueLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WeightLabel);
            this.Name = "Form1";
            this.Text = "Ćwiczenie 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightValueLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label HeightValueLabel;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button CalculeBmiButton;
        private System.Windows.Forms.TextBox BmiTextBox;
        private System.Windows.Forms.Label BmiLabel;
    }
}

