using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz3_cw14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double TicketInZona_A = 15.0;
            double TicketInZona_B = 12.0;
            double TicketInZona_C = 9.0;

            double CalculatePrice_ZonaA, CalculatePrice_ZonaB, CalculatePrice_ZonaC, SumOfAllZones;

            int SumOfTicket_ZonaA, SumOfTicket_ZonaB, SumOfTicket_ZonaC;

            try
            {
                SumOfTicket_ZonaA = int.Parse(ZoneATextBox.Text);
                SumOfTicket_ZonaB = int.Parse(ZoneBTextBox.Text);
                SumOfTicket_ZonaC = int.Parse(ZoneCTextBox.Text);

                CalculatePrice_ZonaA = (double)SumOfTicket_ZonaA * TicketInZona_A;
                CalculatePrice_ZonaB = (double)SumOfTicket_ZonaB * TicketInZona_B;
                CalculatePrice_ZonaC = (double)SumOfTicket_ZonaC * TicketInZona_C;

                SumOfAllZones = CalculatePrice_ZonaA + CalculatePrice_ZonaB + CalculatePrice_ZonaC;

                CostZonaATextBox.Text = CalculatePrice_ZonaA.ToString("c");
                CostZonaBTextBox.Text = CalculatePrice_ZonaB.ToString("c");
                CostZonaCTextBox.Text = CalculatePrice_ZonaC.ToString("c");

                SumOfSaleTextBox.Text = SumOfAllZones.ToString("c");
            }
            catch
            {
                MessageBox.Show("Błędne dane wejściowe!");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            string ClearWindow = "";

            ZoneATextBox.Text = ClearWindow;
            ZoneBTextBox.Text = ClearWindow;
            ZoneCTextBox.Text = ClearWindow;

            CostZonaATextBox.Text = ClearWindow;
            CostZonaBTextBox.Text = ClearWindow;
            CostZonaCTextBox.Text = ClearWindow;

            SumOfSaleTextBox.Text = ClearWindow;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
