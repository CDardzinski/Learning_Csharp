using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz3_przyklad3_1
{
    public partial class BirthDateStringPanel : Form
    {
        public BirthDateStringPanel()
        {
            InitializeComponent();
        }

        private void ShowDateButton_Click(object sender, EventArgs e)
        {
            string OutputData;

            OutputData = DayOfWeekTextBox.Text + " " + DayOfMonthTextBox.Text + " " +
                MonthTextBox.Text + " " + YearTextBox.Text;
                
            DateOutputLabel.Text = OutputData;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DayOfWeekTextBox.Text = "";
            MonthTextBox.Text = "";
            DayOfMonthTextBox.Text = "";
            YearTextBox.Text = "";

            DateOutputLabel.Text = "";
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
