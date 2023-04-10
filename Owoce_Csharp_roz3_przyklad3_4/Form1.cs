using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz3_przyklad3_4
{
	public partial class TestAveragePanel : Form
	{
		public TestAveragePanel()
		{
			InitializeComponent();
		}

		private void CalculateButton_Click(object sender, EventArgs e)
		{
			try
			{
				double test1, test2, test3, average;

				test1 = double.Parse(Test1TextBox.Text);
                test2 = double.Parse(Test2TextBox.Text);
                test3 = double.Parse(Test3TextBox.Text);

				average = (test1 + test2 + test3) / 3.0;

				AverageTextBox.Text = average.ToString("n1");
            }
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			Test1TextBox.Text = "";
			Test2TextBox.Text = "";
			Test3TextBox.Text = "";
			AverageTextBox.Text = "";
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
