using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz2_cw3
{
    public partial class cardIDPanel : Form
    {
        public cardIDPanel()
        {
            InitializeComponent();
        }

        private void CardIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EightDiamondPictureBox_Click(object sender, EventArgs e)
        {
            CardIdLabel.Text = "Ósemka Karo";
        }

        private void AceSpadesPictureBox_Click(object sender, EventArgs e)
        {
            CardIdLabel.Text = "As Pik";
        }

        private void KingSpadesPictureBox_Click(object sender, EventArgs e)
        {
            CardIdLabel.Text = "Król Pik";
        }

        private void TwoClubsPictureBox_Click(object sender, EventArgs e)
        {
            CardIdLabel.Text = "Dwójka trefl";
        }

        private void RedJockerPictureBox_Click(object sender, EventArgs e)
        {
            CardIdLabel.Text = "Czerwony Joker";
        }
    }
}
