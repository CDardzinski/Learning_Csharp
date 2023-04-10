namespace Owoce_Csharp_roz3_przyklad3_2
{
    partial class FuelEconomyPanel
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
            this.MilesPromptLabel = new System.Windows.Forms.Label();
            this.GallonsPromptLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.MilesTextBox = new System.Windows.Forms.TextBox();
            this.GallonsTextBox = new System.Windows.Forms.TextBox();
            this.MPGTextBox = new System.Windows.Forms.TextBox();
            this.CalculateMPGbutton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MilesPromptLabel
            // 
            this.MilesPromptLabel.AutoSize = true;
            this.MilesPromptLabel.Location = new System.Drawing.Point(88, 54);
            this.MilesPromptLabel.Name = "MilesPromptLabel";
            this.MilesPromptLabel.Size = new System.Drawing.Size(151, 13);
            this.MilesPromptLabel.TabIndex = 0;
            this.MilesPromptLabel.Text = "Podaj liczbę przejechanych mil";
            // 
            // GallonsPromptLabel
            // 
            this.GallonsPromptLabel.AutoSize = true;
            this.GallonsPromptLabel.Location = new System.Drawing.Point(48, 92);
            this.GallonsPromptLabel.Name = "GallonsPromptLabel";
            this.GallonsPromptLabel.Size = new System.Drawing.Size(191, 13);
            this.GallonsPromptLabel.TabIndex = 1;
            this.GallonsPromptLabel.Text = "Podaj liczbę spalonych galonów paliwa";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(165, 141);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(74, 13);
            this.outputDescriptionLabel.TabIndex = 2;
            this.outputDescriptionLabel.Text = "Wartość MPG";
            // 
            // MilesTextBox
            // 
            this.MilesTextBox.Location = new System.Drawing.Point(257, 51);
            this.MilesTextBox.Name = "MilesTextBox";
            this.MilesTextBox.Size = new System.Drawing.Size(100, 20);
            this.MilesTextBox.TabIndex = 3;
            // 
            // GallonsTextBox
            // 
            this.GallonsTextBox.Location = new System.Drawing.Point(257, 89);
            this.GallonsTextBox.Name = "GallonsTextBox";
            this.GallonsTextBox.Size = new System.Drawing.Size(100, 20);
            this.GallonsTextBox.TabIndex = 4;
            // 
            // MPGTextBox
            // 
            this.MPGTextBox.Location = new System.Drawing.Point(257, 138);
            this.MPGTextBox.Name = "MPGTextBox";
            this.MPGTextBox.ReadOnly = true;
            this.MPGTextBox.Size = new System.Drawing.Size(100, 20);
            this.MPGTextBox.TabIndex = 5;
            // 
            // CalculateMPGbutton
            // 
            this.CalculateMPGbutton.Location = new System.Drawing.Point(150, 177);
            this.CalculateMPGbutton.Name = "CalculateMPGbutton";
            this.CalculateMPGbutton.Size = new System.Drawing.Size(75, 23);
            this.CalculateMPGbutton.TabIndex = 6;
            this.CalculateMPGbutton.Text = "Oblicz MPG";
            this.CalculateMPGbutton.UseVisualStyleBackColor = true;
            this.CalculateMPGbutton.Click += new System.EventHandler(this.CalculateMPGbutton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(283, 177);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 7;
            this.QuitButton.Text = "Zakończ";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // FuelEconomyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 249);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.CalculateMPGbutton);
            this.Controls.Add(this.MPGTextBox);
            this.Controls.Add(this.GallonsTextBox);
            this.Controls.Add(this.MilesTextBox);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.GallonsPromptLabel);
            this.Controls.Add(this.MilesPromptLabel);
            this.Name = "FuelEconomyPanel";
            this.Text = "Fuel Economy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MilesPromptLabel;
        private System.Windows.Forms.Label GallonsPromptLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.TextBox MilesTextBox;
        private System.Windows.Forms.TextBox GallonsTextBox;
        private System.Windows.Forms.TextBox MPGTextBox;
        private System.Windows.Forms.Button CalculateMPGbutton;
        private System.Windows.Forms.Button QuitButton;
    }
}

