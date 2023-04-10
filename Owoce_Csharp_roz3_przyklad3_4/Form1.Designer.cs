namespace Owoce_Csharp_roz3_przyklad3_4
{
    partial class TestAveragePanel
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
            this.Test1PromptLabel = new System.Windows.Forms.Label();
            this.Test2PromptLabel = new System.Windows.Forms.Label();
            this.Test3PromptLabel = new System.Windows.Forms.Label();
            this.OutputDescriptionLabel = new System.Windows.Forms.Label();
            this.Test1TextBox = new System.Windows.Forms.TextBox();
            this.Test2TextBox = new System.Windows.Forms.TextBox();
            this.Test3TextBox = new System.Windows.Forms.TextBox();
            this.AverageTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Test1PromptLabel
            // 
            this.Test1PromptLabel.AutoSize = true;
            this.Test1PromptLabel.Location = new System.Drawing.Point(79, 37);
            this.Test1PromptLabel.Name = "Test1PromptLabel";
            this.Test1PromptLabel.Size = new System.Drawing.Size(40, 13);
            this.Test1PromptLabel.TabIndex = 0;
            this.Test1PromptLabel.Text = "Test 1:";
            // 
            // Test2PromptLabel
            // 
            this.Test2PromptLabel.AutoSize = true;
            this.Test2PromptLabel.Location = new System.Drawing.Point(79, 73);
            this.Test2PromptLabel.Name = "Test2PromptLabel";
            this.Test2PromptLabel.Size = new System.Drawing.Size(40, 13);
            this.Test2PromptLabel.TabIndex = 1;
            this.Test2PromptLabel.Text = "Test 2:";
            // 
            // Test3PromptLabel
            // 
            this.Test3PromptLabel.AutoSize = true;
            this.Test3PromptLabel.Location = new System.Drawing.Point(79, 108);
            this.Test3PromptLabel.Name = "Test3PromptLabel";
            this.Test3PromptLabel.Size = new System.Drawing.Size(40, 13);
            this.Test3PromptLabel.TabIndex = 2;
            this.Test3PromptLabel.Text = "Test 3:";
            // 
            // OutputDescriptionLabel
            // 
            this.OutputDescriptionLabel.AutoSize = true;
            this.OutputDescriptionLabel.Location = new System.Drawing.Point(79, 168);
            this.OutputDescriptionLabel.Name = "OutputDescriptionLabel";
            this.OutputDescriptionLabel.Size = new System.Drawing.Size(105, 13);
            this.OutputDescriptionLabel.TabIndex = 3;
            this.OutputDescriptionLabel.Text = "Average Test Score:";
            // 
            // Test1TextBox
            // 
            this.Test1TextBox.Location = new System.Drawing.Point(155, 30);
            this.Test1TextBox.Name = "Test1TextBox";
            this.Test1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Test1TextBox.TabIndex = 4;
            // 
            // Test2TextBox
            // 
            this.Test2TextBox.Location = new System.Drawing.Point(155, 70);
            this.Test2TextBox.Name = "Test2TextBox";
            this.Test2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Test2TextBox.TabIndex = 5;
            // 
            // Test3TextBox
            // 
            this.Test3TextBox.Location = new System.Drawing.Point(155, 105);
            this.Test3TextBox.Name = "Test3TextBox";
            this.Test3TextBox.Size = new System.Drawing.Size(100, 20);
            this.Test3TextBox.TabIndex = 6;
            // 
            // AverageTextBox
            // 
            this.AverageTextBox.Location = new System.Drawing.Point(210, 165);
            this.AverageTextBox.Name = "AverageTextBox";
            this.AverageTextBox.ReadOnly = true;
            this.AverageTextBox.Size = new System.Drawing.Size(100, 20);
            this.AverageTextBox.TabIndex = 7;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(49, 221);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 40);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate Averege";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(155, 221);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 40);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.ExitButton.Location = new System.Drawing.Point(262, 221);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 40);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TestAveragePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 295);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.AverageTextBox);
            this.Controls.Add(this.Test3TextBox);
            this.Controls.Add(this.Test2TextBox);
            this.Controls.Add(this.Test1TextBox);
            this.Controls.Add(this.OutputDescriptionLabel);
            this.Controls.Add(this.Test3PromptLabel);
            this.Controls.Add(this.Test2PromptLabel);
            this.Controls.Add(this.Test1PromptLabel);
            this.Name = "TestAveragePanel";
            this.Text = "Test Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Test1PromptLabel;
        private System.Windows.Forms.Label Test2PromptLabel;
        private System.Windows.Forms.Label Test3PromptLabel;
        private System.Windows.Forms.Label OutputDescriptionLabel;
        private System.Windows.Forms.TextBox Test1TextBox;
        private System.Windows.Forms.TextBox Test2TextBox;
        private System.Windows.Forms.TextBox Test3TextBox;
        private System.Windows.Forms.TextBox AverageTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

