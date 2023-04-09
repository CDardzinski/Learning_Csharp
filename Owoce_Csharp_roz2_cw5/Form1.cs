using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz2_cw5
{
    public partial class CoinSidePanel : Form
    {
        public CoinSidePanel()
        {
            InitializeComponent();
        }

        private void ShowTailsButton_Click(object sender, EventArgs e)
        {
            HeadsPictureBox.Visible = true;
            TailsPictureBox.Visible = false;          
        }

        private void ShowHeadButton_Click(object sender, EventArgs e)
        {
            HeadsPictureBox.Visible = false;
            TailsPictureBox.Visible = true;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
