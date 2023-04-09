using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz2_cw4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void QuestionButton_Click(object sender, EventArgs e)
        {
            JokeLabel.Text = "Dlaczego słoń ma trąbe?";
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            JokeLabel.Text = "Dlaczego słoń ma trąbe?\n\nŻeby się tak gwałtownie nie zaczynał.\n\tHa ha";
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
