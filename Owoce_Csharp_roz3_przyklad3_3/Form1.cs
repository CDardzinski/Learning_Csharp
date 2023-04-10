using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz3_przyklad3_3
{
    public partial class SalesPricePanel : Form
    {
        public SalesPricePanel()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice;
            decimal discountPercentage;
            decimal discountAmount;
            decimal salePrice;

            originalPrice = decimal.Parse(OriginalProceTextBox.Text);

            discountPercentage = decimal.Parse(DiscountPercentageTextBox.Text);

            discountPercentage = discountPercentage / 100;

            discountAmount = originalPrice * discountPercentage;

            salePrice = originalPrice - discountAmount;

            SalesPriceTextBox.Text = salePrice.ToString("c");
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
