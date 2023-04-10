namespace Owoce_Csharp_roz3_cw8
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
            this.SetPropertyValueLabel = new System.Windows.Forms.Label();
            this.LowestInsuraneValueLabel = new System.Windows.Forms.Label();
            this.PropertyValueTextBox = new System.Windows.Forms.TextBox();
            this.MinInsuranePropertyValueTextBox = new System.Windows.Forms.TextBox();
            this.QuitButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SetPropertyValueLabel
            // 
            this.SetPropertyValueLabel.AutoSize = true;
            this.SetPropertyValueLabel.Location = new System.Drawing.Point(46, 54);
            this.SetPropertyValueLabel.Name = "SetPropertyValueLabel";
            this.SetPropertyValueLabel.Size = new System.Drawing.Size(145, 13);
            this.SetPropertyValueLabel.TabIndex = 0;
            this.SetPropertyValueLabel.Text = "Podaj wartość nieruchomości";
            // 
            // LowestInsuraneValueLabel
            // 
            this.LowestInsuraneValueLabel.AutoSize = true;
            this.LowestInsuraneValueLabel.Location = new System.Drawing.Point(46, 118);
            this.LowestInsuraneValueLabel.Name = "LowestInsuraneValueLabel";
            this.LowestInsuraneValueLabel.Size = new System.Drawing.Size(165, 13);
            this.LowestInsuraneValueLabel.TabIndex = 1;
            this.LowestInsuraneValueLabel.Text = "Minimalna wartość ubezpieczenia";
            // 
            // PropertyValueTextBox
            // 
            this.PropertyValueTextBox.Location = new System.Drawing.Point(266, 51);
            this.PropertyValueTextBox.Name = "PropertyValueTextBox";
            this.PropertyValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.PropertyValueTextBox.TabIndex = 2;
            // 
            // MinInsuranePropertyValueTextBox
            // 
            this.MinInsuranePropertyValueTextBox.Location = new System.Drawing.Point(266, 115);
            this.MinInsuranePropertyValueTextBox.Name = "MinInsuranePropertyValueTextBox";
            this.MinInsuranePropertyValueTextBox.ReadOnly = true;
            this.MinInsuranePropertyValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.MinInsuranePropertyValueTextBox.TabIndex = 3;
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(291, 196);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 4;
            this.QuitButton.Text = "Zakończ";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(116, 196);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Oblicz";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 283);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.MinInsuranePropertyValueTextBox);
            this.Controls.Add(this.PropertyValueTextBox);
            this.Controls.Add(this.LowestInsuraneValueLabel);
            this.Controls.Add(this.SetPropertyValueLabel);
            this.Name = "Form1";
            this.Text = "Ćwiczenie 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SetPropertyValueLabel;
        private System.Windows.Forms.Label LowestInsuraneValueLabel;
        private System.Windows.Forms.TextBox PropertyValueTextBox;
        private System.Windows.Forms.TextBox MinInsuranePropertyValueTextBox;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button CalculateButton;
    }
}

