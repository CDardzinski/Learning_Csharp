namespace Owoce_Csharp_roz2_prz2_Label
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
            this.answerLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.showAnswerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answerLabel
            // 
            this.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.answerLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerLabel.Location = new System.Drawing.Point(50, 73);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(379, 78);
            this.answerLabel.TabIndex = 0;
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answerLabel.Click += new System.EventHandler(this.answerLabel_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionLabel.Location = new System.Drawing.Point(80, 35);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(312, 14);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "Który prezydent USA był na afrykańskiem safari?";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showAnswerButton
            // 
            this.showAnswerButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showAnswerButton.Location = new System.Drawing.Point(170, 184);
            this.showAnswerButton.Name = "showAnswerButton";
            this.showAnswerButton.Size = new System.Drawing.Size(119, 23);
            this.showAnswerButton.TabIndex = 2;
            this.showAnswerButton.Text = "Pokaż odpowiedź";
            this.showAnswerButton.UseVisualStyleBackColor = true;
            this.showAnswerButton.Click += new System.EventHandler(this.showAnswerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 250);
            this.Controls.Add(this.showAnswerButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.answerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button showAnswerButton;
    }
}

