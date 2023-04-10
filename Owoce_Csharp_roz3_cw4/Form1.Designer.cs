namespace Owoce_Csharp_roz3_cw4
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
            this.ItemValueLabel = new System.Windows.Forms.Label();
            this.ItemValueTextBox = new System.Windows.Forms.TextBox();
            this.TaxStateLabel = new System.Windows.Forms.Label();
            this.ShireTaxLabel = new System.Windows.Forms.Label();
            this.TaxSumLabel = new System.Windows.Forms.Label();
            this.SumItemTaxLabel = new System.Windows.Forms.Label();
            this.TaxStateTextBox = new System.Windows.Forms.TextBox();
            this.ShireTaxTextBox = new System.Windows.Forms.TextBox();
            this.TaxSumTextBox = new System.Windows.Forms.TextBox();
            this.SumItemTaxTextBox = new System.Windows.Forms.TextBox();
            this.QuitButton = new System.Windows.Forms.Button();
            this.CalculeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemValueLabel
            // 
            this.ItemValueLabel.AutoSize = true;
            this.ItemValueLabel.Location = new System.Drawing.Point(46, 43);
            this.ItemValueLabel.Name = "ItemValueLabel";
            this.ItemValueLabel.Size = new System.Drawing.Size(93, 13);
            this.ItemValueLabel.TabIndex = 0;
            this.ItemValueLabel.Text = "Wartość zakupów";
            // 
            // ItemValueTextBox
            // 
            this.ItemValueTextBox.Location = new System.Drawing.Point(172, 36);
            this.ItemValueTextBox.Name = "ItemValueTextBox";
            this.ItemValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemValueTextBox.TabIndex = 1;
            // 
            // TaxStateLabel
            // 
            this.TaxStateLabel.AutoSize = true;
            this.TaxStateLabel.Location = new System.Drawing.Point(50, 77);
            this.TaxStateLabel.Name = "TaxStateLabel";
            this.TaxStateLabel.Size = new System.Drawing.Size(89, 13);
            this.TaxStateLabel.TabIndex = 2;
            this.TaxStateLabel.Text = "Podatek w stanie";
            // 
            // ShireTaxLabel
            // 
            this.ShireTaxLabel.AutoSize = true;
            this.ShireTaxLabel.Location = new System.Drawing.Point(33, 106);
            this.ShireTaxLabel.Name = "ShireTaxLabel";
            this.ShireTaxLabel.Size = new System.Drawing.Size(106, 13);
            this.ShireTaxLabel.TabIndex = 3;
            this.ShireTaxLabel.Text = "Podatek w hrabstwie";
            // 
            // TaxSumLabel
            // 
            this.TaxSumLabel.AutoSize = true;
            this.TaxSumLabel.Location = new System.Drawing.Point(54, 139);
            this.TaxSumLabel.Name = "TaxSumLabel";
            this.TaxSumLabel.Size = new System.Drawing.Size(85, 13);
            this.TaxSumLabel.TabIndex = 4;
            this.TaxSumLabel.Text = "Suma Podatków";
            // 
            // SumItemTaxLabel
            // 
            this.SumItemTaxLabel.AutoSize = true;
            this.SumItemTaxLabel.Location = new System.Drawing.Point(14, 172);
            this.SumItemTaxLabel.Name = "SumItemTaxLabel";
            this.SumItemTaxLabel.Size = new System.Drawing.Size(125, 13);
            this.SumItemTaxLabel.TabIndex = 5;
            this.SumItemTaxLabel.Text = "Suma Zakupy + Podatek";
            // 
            // TaxStateTextBox
            // 
            this.TaxStateTextBox.Location = new System.Drawing.Point(172, 70);
            this.TaxStateTextBox.Name = "TaxStateTextBox";
            this.TaxStateTextBox.ReadOnly = true;
            this.TaxStateTextBox.Size = new System.Drawing.Size(100, 20);
            this.TaxStateTextBox.TabIndex = 6;
            // 
            // ShireTaxTextBox
            // 
            this.ShireTaxTextBox.Location = new System.Drawing.Point(172, 103);
            this.ShireTaxTextBox.Name = "ShireTaxTextBox";
            this.ShireTaxTextBox.ReadOnly = true;
            this.ShireTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShireTaxTextBox.TabIndex = 7;
            // 
            // TaxSumTextBox
            // 
            this.TaxSumTextBox.Location = new System.Drawing.Point(172, 136);
            this.TaxSumTextBox.Name = "TaxSumTextBox";
            this.TaxSumTextBox.ReadOnly = true;
            this.TaxSumTextBox.Size = new System.Drawing.Size(100, 20);
            this.TaxSumTextBox.TabIndex = 8;
            // 
            // SumItemTaxTextBox
            // 
            this.SumItemTaxTextBox.Location = new System.Drawing.Point(172, 169);
            this.SumItemTaxTextBox.Name = "SumItemTaxTextBox";
            this.SumItemTaxTextBox.ReadOnly = true;
            this.SumItemTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.SumItemTaxTextBox.TabIndex = 9;
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(197, 224);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 10;
            this.QuitButton.Text = "Zakończ";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // CalculeButton
            // 
            this.CalculeButton.Location = new System.Drawing.Point(64, 224);
            this.CalculeButton.Name = "CalculeButton";
            this.CalculeButton.Size = new System.Drawing.Size(75, 23);
            this.CalculeButton.TabIndex = 11;
            this.CalculeButton.Text = "Oblicz";
            this.CalculeButton.UseVisualStyleBackColor = true;
            this.CalculeButton.Click += new System.EventHandler(this.CalculeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 298);
            this.Controls.Add(this.CalculeButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.SumItemTaxTextBox);
            this.Controls.Add(this.TaxSumTextBox);
            this.Controls.Add(this.ShireTaxTextBox);
            this.Controls.Add(this.TaxStateTextBox);
            this.Controls.Add(this.SumItemTaxLabel);
            this.Controls.Add(this.TaxSumLabel);
            this.Controls.Add(this.ShireTaxLabel);
            this.Controls.Add(this.TaxStateLabel);
            this.Controls.Add(this.ItemValueTextBox);
            this.Controls.Add(this.ItemValueLabel);
            this.Name = "Form1";
            this.Text = "Ćwiczenie 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemValueLabel;
        private System.Windows.Forms.TextBox ItemValueTextBox;
        private System.Windows.Forms.Label TaxStateLabel;
        private System.Windows.Forms.Label ShireTaxLabel;
        private System.Windows.Forms.Label TaxSumLabel;
        private System.Windows.Forms.Label SumItemTaxLabel;
        private System.Windows.Forms.TextBox TaxStateTextBox;
        private System.Windows.Forms.TextBox ShireTaxTextBox;
        private System.Windows.Forms.TextBox TaxSumTextBox;
        private System.Windows.Forms.TextBox SumItemTaxTextBox;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button CalculeButton;
    }
}

