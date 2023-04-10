namespace Owoce_Csharp_roz3_przyklad3_3
{
    partial class SalesPricePanel
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
            this.OrginalProcePromptLabel = new System.Windows.Forms.Label();
            this.discPercentagePromptLabel = new System.Windows.Forms.Label();
            this.OutputDescriptionLabel = new System.Windows.Forms.Label();
            this.OriginalProceTextBox = new System.Windows.Forms.TextBox();
            this.DiscountPercentageTextBox = new System.Windows.Forms.TextBox();
            this.SalesPriceTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrginalProcePromptLabel
            // 
            this.OrginalProcePromptLabel.AutoSize = true;
            this.OrginalProcePromptLabel.Location = new System.Drawing.Point(28, 35);
            this.OrginalProcePromptLabel.Name = "OrginalProcePromptLabel";
            this.OrginalProcePromptLabel.Size = new System.Drawing.Size(183, 13);
            this.OrginalProcePromptLabel.TabIndex = 0;
            this.OrginalProcePromptLabel.Text = "Podaj dotychczasową cenę produktu";
            // 
            // discPercentagePromptLabel
            // 
            this.discPercentagePromptLabel.AutoSize = true;
            this.discPercentagePromptLabel.Location = new System.Drawing.Point(104, 69);
            this.discPercentagePromptLabel.Name = "discPercentagePromptLabel";
            this.discPercentagePromptLabel.Size = new System.Drawing.Size(107, 13);
            this.discPercentagePromptLabel.TabIndex = 1;
            this.discPercentagePromptLabel.Text = "Podaj wartość rabatu";
            // 
            // OutputDescriptionLabel
            // 
            this.OutputDescriptionLabel.AutoSize = true;
            this.OutputDescriptionLabel.Location = new System.Drawing.Point(122, 126);
            this.OutputDescriptionLabel.Name = "OutputDescriptionLabel";
            this.OutputDescriptionLabel.Size = new System.Drawing.Size(89, 13);
            this.OutputDescriptionLabel.TabIndex = 2;
            this.OutputDescriptionLabel.Text = "Cena promocyjna";
            // 
            // OriginalProceTextBox
            // 
            this.OriginalProceTextBox.Location = new System.Drawing.Point(257, 32);
            this.OriginalProceTextBox.Name = "OriginalProceTextBox";
            this.OriginalProceTextBox.Size = new System.Drawing.Size(100, 20);
            this.OriginalProceTextBox.TabIndex = 3;
            // 
            // DiscountPercentageTextBox
            // 
            this.DiscountPercentageTextBox.Location = new System.Drawing.Point(257, 66);
            this.DiscountPercentageTextBox.Name = "DiscountPercentageTextBox";
            this.DiscountPercentageTextBox.Size = new System.Drawing.Size(100, 20);
            this.DiscountPercentageTextBox.TabIndex = 4;
            // 
            // SalesPriceTextBox
            // 
            this.SalesPriceTextBox.Location = new System.Drawing.Point(257, 123);
            this.SalesPriceTextBox.Name = "SalesPriceTextBox";
            this.SalesPriceTextBox.ReadOnly = true;
            this.SalesPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalesPriceTextBox.TabIndex = 5;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(136, 178);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 38);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Oblicz cenę promocyjną";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(257, 178);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 38);
            this.QuitButton.TabIndex = 7;
            this.QuitButton.Text = "Zakończ";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // SalesPricePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 250);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SalesPriceTextBox);
            this.Controls.Add(this.DiscountPercentageTextBox);
            this.Controls.Add(this.OriginalProceTextBox);
            this.Controls.Add(this.OutputDescriptionLabel);
            this.Controls.Add(this.discPercentagePromptLabel);
            this.Controls.Add(this.OrginalProcePromptLabel);
            this.Name = "SalesPricePanel";
            this.Text = "Sales Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrginalProcePromptLabel;
        private System.Windows.Forms.Label discPercentagePromptLabel;
        private System.Windows.Forms.Label OutputDescriptionLabel;
        private System.Windows.Forms.TextBox OriginalProceTextBox;
        private System.Windows.Forms.TextBox DiscountPercentageTextBox;
        private System.Windows.Forms.TextBox SalesPriceTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button QuitButton;
    }
}

