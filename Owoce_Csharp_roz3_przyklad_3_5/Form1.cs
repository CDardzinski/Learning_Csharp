using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz3_przyklad_3_5
{
    public partial class ChangeCounterPanel : Form
    {
        //Pola stałych dostępnych w tej klasie
        const decimal FIVE_CENTS_VALUE = 0.05m;
        const decimal TEN_CENTS_VALUE = 0.10m;
        const decimal TWENTY_FIVE_CENTS_VALUE = 0.25m;
        const decimal FIFTY_CENTS_VALUE = 0.50m;

        //Pole zmiennej dla tej klasy
        private decimal total = 0m;

        public ChangeCounterPanel()
        {
            InitializeComponent();
        }

        private void FiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += FIVE_CENTS_VALUE;

            TotalTextBox.Text = total.ToString("c");
        }

        private void TenCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += TEN_CENTS_VALUE;

            TotalTextBox.Text = total.ToString("c");
        }
        private void TwentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += TWENTY_FIVE_CENTS_VALUE;

            TotalTextBox.Text = total.ToString("c");
        }

        private void FiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += FIFTY_CENTS_VALUE;

            TotalTextBox.Text = total.ToString("c");
        }     

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
