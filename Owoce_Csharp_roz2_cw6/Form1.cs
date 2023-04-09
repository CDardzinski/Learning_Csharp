using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz2_cw6
{
    public partial class OrionConstelationPanel : Form
    {
        public OrionConstelationPanel()
        {
            InitializeComponent();
        }

        private void ShowStarNameButton_Click(object sender, EventArgs e)
        {
            BetelgeuseLabel.Visible = true;
            MeissaLabel.Visible = true;
            AlnitakLabel.Visible = true;
            AlnilamLabel.Visible = true;
            MintakaLabel.Visible = true;
            SaiphLabel.Visible = true;
            RigelLabel.Visible = true;
        }

        private void HideStarNameButton_Click(object sender, EventArgs e)
        {
            BetelgeuseLabel.Visible =false;
            MeissaLabel.Visible = false;
            AlnitakLabel.Visible = false;
            AlnilamLabel.Visible = false;
            MintakaLabel.Visible = false;
            SaiphLabel.Visible = false;
            RigelLabel.Visible = false;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
