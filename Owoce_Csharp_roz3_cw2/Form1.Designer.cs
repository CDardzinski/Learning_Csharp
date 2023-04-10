namespace Owoce_Csharp_roz3_cw2
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
            this.MealPriceLabel = new System.Windows.Forms.Label();
            this.MealPriceTextBox = new System.Windows.Forms.TextBox();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.TaxTextBox = new System.Windows.Forms.TextBox();
            this.TipsLabel = new System.Windows.Forms.Label();
            this.TipsTextBox = new System.Windows.Forms.TextBox();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.SumLabel = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.CalculeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MealPriceLabel
            // 
            this.MealPriceLabel.AutoSize = true;
            this.MealPriceLabel.Location = new System.Drawing.Point(33, 35);
            this.MealPriceLabel.Name = "MealPriceLabel";
            this.MealPriceLabel.Size = new System.Drawing.Size(71, 13);
            this.MealPriceLabel.TabIndex = 0;
            this.MealPriceLabel.Text = "Koszt posiłku";
            // 
            // MealPriceTextBox
            // 
            this.MealPriceTextBox.Location = new System.Drawing.Point(137, 35);
            this.MealPriceTextBox.Name = "MealPriceTextBox";
            this.MealPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.MealPriceTextBox.TabIndex = 1;
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(49, 105);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(47, 13);
            this.TaxLabel.TabIndex = 2;
            this.TaxLabel.Text = "Podatek";
            // 
            // TaxTextBox
            // 
            this.TaxTextBox.Location = new System.Drawing.Point(23, 121);
            this.TaxTextBox.Name = "TaxTextBox";
            this.TaxTextBox.ReadOnly = true;
            this.TaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.TaxTextBox.TabIndex = 3;
            // 
            // TipsLabel
            // 
            this.TipsLabel.AutoSize = true;
            this.TipsLabel.Location = new System.Drawing.Point(190, 105);
            this.TipsLabel.Name = "TipsLabel";
            this.TipsLabel.Size = new System.Drawing.Size(49, 13);
            this.TipsLabel.TabIndex = 4;
            this.TipsLabel.Text = "Napiwek";
            // 
            // TipsTextBox
            // 
            this.TipsTextBox.Location = new System.Drawing.Point(165, 121);
            this.TipsTextBox.Name = "TipsTextBox";
            this.TipsTextBox.ReadOnly = true;
            this.TipsTextBox.Size = new System.Drawing.Size(100, 20);
            this.TipsTextBox.TabIndex = 5;
            // 
            // SumTextBox
            // 
            this.SumTextBox.Location = new System.Drawing.Point(91, 188);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.ReadOnly = true;
            this.SumTextBox.Size = new System.Drawing.Size(100, 20);
            this.SumTextBox.TabIndex = 7;
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Location = new System.Drawing.Point(123, 172);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(34, 13);
            this.SumLabel.TabIndex = 6;
            this.SumLabel.Text = "Suma";
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(177, 262);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 8;
            this.QuitButton.Text = "Zakończ";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // CalculeButton
            // 
            this.CalculeButton.Location = new System.Drawing.Point(48, 262);
            this.CalculeButton.Name = "CalculeButton";
            this.CalculeButton.Size = new System.Drawing.Size(75, 23);
            this.CalculeButton.TabIndex = 9;
            this.CalculeButton.Text = "Oblicz";
            this.CalculeButton.UseVisualStyleBackColor = true;
            this.CalculeButton.Click += new System.EventHandler(this.CalculeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 337);
            this.Controls.Add(this.CalculeButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.TipsTextBox);
            this.Controls.Add(this.TipsLabel);
            this.Controls.Add(this.TaxTextBox);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.MealPriceTextBox);
            this.Controls.Add(this.MealPriceLabel);
            this.Name = "Form1";
            this.Text = "Cwiczenie 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MealPriceLabel;
        private System.Windows.Forms.TextBox MealPriceTextBox;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.TextBox TaxTextBox;
        private System.Windows.Forms.Label TipsLabel;
        private System.Windows.Forms.TextBox TipsTextBox;
        private System.Windows.Forms.TextBox SumTextBox;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button CalculeButton;
    }
}

