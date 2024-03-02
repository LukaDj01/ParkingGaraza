using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingGaraza
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Pocetna_Load(object sender, EventArgs e)
        {

        }

        private void btnKartice_Click(object sender, EventArgs e)
        {
            ParkingGaraza.Forme.Kartice forma = new ParkingGaraza.Forme.Kartice();
            forma.ShowDialog();
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            ParkingGaraza.Forme.Korisnici forma = new ParkingGaraza.Forme.Korisnici();
            forma.ShowDialog();
        }

        private void btnOperateri_Click(object sender, EventArgs e)
        {
            ParkingGaraza.Forme.Operateri forma = new ParkingGaraza.Forme.Operateri();
            forma.ShowDialog();
        }
    }
}
