using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz2_cw1
{
    public partial class translatorPanel : Form
    {
        public translatorPanel()
        {
            InitializeComponent();
        }

        private void sinisterButton_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "lewy";
        }

        private void dexterButton_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "prawy";
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "środkowy";
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
