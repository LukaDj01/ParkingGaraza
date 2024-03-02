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
    public partial class Kartice : Form
    {
        public Kartice()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnPU_Click(object sender, EventArgs e)
        {
            ParkingGaraza.Forme.KarticePU forma = new ParkingGaraza.Forme.KarticePU();
            forma.ShowDialog();
        }

        private void btnPretp_Click(object sender, EventArgs e)
        {
            ParkingGaraza.Forme.KarticePretplatne forma = new ParkingGaraza.Forme.KarticePretplatne();
            forma.ShowDialog();
        }
    }
}
