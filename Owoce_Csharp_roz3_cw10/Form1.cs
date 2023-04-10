using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz3_cw10
{
    public partial class Form1 : Form
    {
        uint SumOfCalory = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void BananaPictureBox_Click(object sender, EventArgs e)
        {
            SumOfCalory += 115;
            KcalSumLabel.Text = SumOfCalory.ToString();
        }

        private void ApplePictureBox_Click(object sender, EventArgs e)
        {
            SumOfCalory += 80;
            KcalSumLabel.Text = SumOfCalory.ToString();
        }

        private void OrangePictureBox_Click(object sender, EventArgs e)
        {
            SumOfCalory += 90;
            KcalSumLabel.Text = SumOfCalory.ToString();
        }

        private void PearPictureBox_Click(object sender, EventArgs e)
        {
            SumOfCalory += 120;
            KcalSumLabel.Text = SumOfCalory.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SumOfCalory = 0;
            KcalSumLabel.Text = SumOfCalory.ToString();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
