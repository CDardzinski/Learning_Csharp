using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz3_cw12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculeButton_Click(object sender, EventArgs e)
        {
            const double PaintPerSqurtMeter = 4.0 / 115.0;
            const double WorkhourPerSqrtMeter = 115.0 / 8.0;
            const double HourWork = 20.0;

            double SpaceToPaint, Cost4LiterPaint, SumOfPaint, WorkHours, OneLiterPaintCost, HowManyPaintIneed, SumOfPaintCost;
            double WorkCostSum, SumOfAllCost;

            try
            {
                SpaceToPaint = double.Parse(SpaceTextBox.Text);
                Cost4LiterPaint = double.Parse(PaintCostTextBox.Text);

                SumOfPaint = PaintPerSqurtMeter * SpaceToPaint;
                SumPaintTextBox.Text = SumOfPaint.ToString("n2");

                WorkHours = SpaceToPaint / WorkhourPerSqrtMeter;
                PaintTimeTextBox.Text = WorkHours.ToString("n2");

                OneLiterPaintCost = Cost4LiterPaint / 4.0;
                HowManyPaintIneed = SpaceToPaint * PaintPerSqurtMeter;
                SumOfPaintCost = OneLiterPaintCost * HowManyPaintIneed;
                SumPaintCostTextBox.Text = SumOfPaintCost.ToString("c");

                WorkCostSum = SpaceToPaint / WorkhourPerSqrtMeter;
                WorkCostSum *= HourWork;
                SumWorkCostTextBox.Text = WorkCostSum.ToString("c");

                SumOfAllCost = WorkCostSum + SumOfPaintCost;
                SumOfAllTextBox.Text = SumOfAllCost.ToString("c");
            }
            catch
            {
                MessageBox.Show("Błędne dane wejściowe");
            }
        }
        
        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
