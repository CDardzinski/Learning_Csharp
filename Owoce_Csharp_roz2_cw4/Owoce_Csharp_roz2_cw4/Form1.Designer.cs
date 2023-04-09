namespace Owoce_Csharp_roz2_cw4
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
            this.JokeLabel = new System.Windows.Forms.Label();
            this.QuestionButton = new System.Windows.Forms.Button();
            this.AnswerButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JokeLabel
            // 
            this.JokeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JokeLabel.Location = new System.Drawing.Point(70, 70);
            this.JokeLabel.Name = "JokeLabel";
            this.JokeLabel.Size = new System.Drawing.Size(645, 150);
            this.JokeLabel.TabIndex = 0;
            this.JokeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuestionButton
            // 
            this.QuestionButton.Location = new System.Drawing.Point(110, 272);
            this.QuestionButton.Name = "QuestionButton";
            this.QuestionButton.Size = new System.Drawing.Size(95, 40);
            this.QuestionButton.TabIndex = 1;
            this.QuestionButton.Text = "Pytanie";
            this.QuestionButton.UseVisualStyleBackColor = true;
            this.QuestionButton.Click += new System.EventHandler(this.QuestionButton_Click);
            // 
            // AnswerButton
            // 
            this.AnswerButton.Location = new System.Drawing.Point(547, 272);
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.Size = new System.Drawing.Size(95, 40);
            this.AnswerButton.TabIndex = 2;
            this.AnswerButton.Text = "Odpowiedź";
            this.AnswerButton.UseVisualStyleBackColor = true;
            this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(324, 360);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(95, 40);
            this.QuitButton.TabIndex = 3;
            this.QuitButton.Text = "Wyjście";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.AnswerButton);
            this.Controls.Add(this.QuestionButton);
            this.Controls.Add(this.JokeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label JokeLabel;
        private System.Windows.Forms.Button QuestionButton;
        private System.Windows.Forms.Button AnswerButton;
        private System.Windows.Forms.Button QuitButton;
    }
}

