using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingGaraza.Forme
{
    public partial class Korisnici : Form
    {
        public Korisnici()
        {
            InitializeComponent();
        }

        private void btnVlasnici_Click(object sender, EventArgs e)
        {
            ParkingGaraza.Forme.Vlasnici forma = new ParkingGaraza.Forme.Vlasnici();
            forma.ShowDialog();
        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            ParkingGaraza.Forme.Vozila forma = new ParkingGaraza.Forme.Vozila();
            forma.ShowDialog();
        }
    }
}
