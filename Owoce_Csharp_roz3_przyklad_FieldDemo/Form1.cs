using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz3_przyklad_FieldDemo
{
	public partial class Form1 : Form
	{
		//Deklaracja pola typu private przeznaczonego do przechowywania imienia
		private string name = "Karol";

		public Form1()
		{
			InitializeComponent();
		}

		private void ShowNameButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show(name);
		}

		private void CarmenButton_Click(object sender, EventArgs e)
		{
			name = "Katarzyna";
		}

		private void ChrisButton_Click(object sender, EventArgs e)
		{
			name = "Krzysztof";
		}

		private void QuitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
