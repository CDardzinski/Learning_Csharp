using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz2_prz2._1 //przestrzeń nazw
{
    public partial class Form1 : Form //klasa
    {
        public Form1() //metoda
        {
            InitializeComponent();
        }

        private void firstButton_Click(object sender, EventArgs e) //obsługa zdarzenia, kliknięcie w przycisk
        {
            MessageBox.Show("Wcisnąłeś przycisk pierwszy!");
        }

        private void secondButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wcisnąłeś przycisk drugi!");
        }

        private void thirdbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wcisnąłeś przycisk trzeci!");
        }
    }
}
