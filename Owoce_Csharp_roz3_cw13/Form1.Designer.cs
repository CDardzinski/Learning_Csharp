namespace Owoce_Csharp_roz3_cw13
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
            this.PropertyValueTextBox = new System.Windows.Forms.TextBox();
            this.PropertyValueLabel = new System.Windows.Forms.Label();
            this.TaxTextBox = new System.Windows.Forms.TextBox();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.CalculeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PropertyValueTextBox
            // 
            this.PropertyValueTextBox.Location = new System.Drawing.Point(182, 53);
            this.PropertyValueTextBox.Name = "PropertyValueTextBox";
            this.PropertyValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.PropertyValueTextBox.TabIndex = 0;
            // 
            // PropertyValueLabel
            // 
            this.PropertyValueLabel.AutoSize = true;
            this.PropertyValueLabel.Location = new System.Drawing.Point(25, 56);
            this.PropertyValueLabel.Name = "PropertyValueLabel";
            this.PropertyValueLabel.Size = new System.Drawing.Size(118, 13);
            this.PropertyValueLabel.TabIndex = 1;
            this.PropertyValueLabel.Text = "Wartość nieruchomości";
            // 
            // TaxTextBox
            // 
            this.TaxTextBox.Location = new System.Drawing.Point(182, 102);
            this.TaxTextBox.Name = "TaxTextBox";
            this.TaxTextBox.ReadOnly = true;
            this.TaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.TaxTextBox.TabIndex = 2;
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(25, 105);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(133, 13);
            this.TaxLabel.TabIndex = 3;
            this.TaxLabel.Text = "Podatek od nieruchomości";
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(206, 183);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(76, 24);
            this.QuitButton.TabIndex = 4;
            this.QuitButton.Text = "Zakończ";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // CalculeButton
            // 
            this.CalculeButton.Location = new System.Drawing.Point(46, 183);
            this.CalculeButton.Name = "CalculeButton";
            this.CalculeButton.Size = new System.Drawing.Size(76, 24);
            this.CalculeButton.TabIndex = 5;
            this.CalculeButton.Text = "Oblicz";
            this.CalculeButton.UseVisualStyleBackColor = true;
            this.CalculeButton.Click += new System.EventHandler(this.CalculeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 259);
            this.Controls.Add(this.CalculeButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.TaxTextBox);
            this.Controls.Add(this.PropertyValueLabel);
            this.Controls.Add(this.PropertyValueTextBox);
            this.Name = "Form1";
            this.Text = "Ćwiczenie 13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PropertyValueTextBox;
        private System.Windows.Forms.Label PropertyValueLabel;
        private System.Windows.Forms.TextBox TaxTextBox;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button CalculeButton;
    }
}

