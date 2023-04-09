using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz2_cw2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void OnePictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jeden");
        }
        private void TwoPictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dwa");
        }

        private void ThreePictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trzy");
        }

        private void FourPictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cztery");
        }
        private void FivePictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pięć");
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
