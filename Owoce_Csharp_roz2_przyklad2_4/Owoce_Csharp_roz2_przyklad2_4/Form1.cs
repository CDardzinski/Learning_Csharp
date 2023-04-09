using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz2_przyklad2_4
{
    public partial class Flags : Form
    {
        public Flags()
        {
            InitializeComponent();
        }

        private void finlandPictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Finlandia";
        }

        private void francePictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Francja";
        }

        private void germanyPictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Niemcy";
        }
    }
}
