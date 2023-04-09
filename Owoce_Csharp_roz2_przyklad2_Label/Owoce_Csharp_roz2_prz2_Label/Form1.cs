using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz2_prz2_Label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void answerLabel_Click(object sender, EventArgs e)
        {

        }

        private void showAnswerButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "Theodore Roosevelt";
        }

    }
}
