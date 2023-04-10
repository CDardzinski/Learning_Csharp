using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz4_przyklad4_5
{
    public partial class ColorTheme : Form
    {
        public ColorTheme()
        {
            InitializeComponent();
        }

        private void YellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(YellowRadioButton.Checked) this.BackColor = Color.Yellow;
        }

        private void RedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(RedRadioButton.Checked) this.BackColor = Color.Red;
        }

        private void WhiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(WhiteRadioButton.Checked) this.BackColor = Color.White;
        }

        private void NormalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(NormalRadioButton.Checked) this.BackColor = SystemColors.Control;
        }  

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
