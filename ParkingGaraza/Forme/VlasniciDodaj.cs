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
    public partial class VlasniciDodaj : Form
    {
        public VlasnikPregled vp;
        public VlasniciDodaj()
        {
            InitializeComponent();
            this.vp = new VlasnikPregled();
        }

        private void VlasniciDodaj_Load(object sender, EventArgs e)
        {

        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            txBoxJMBG.Text = "";
            txBoxIme.Text = "";
            txBoxPrezime.Text = "";
        }

        private void btnNastavi_Click(object sender, EventArgs e)
        {
            vp.Jmbg = txBoxJMBG.Text;
            if (DTOManager.VlasnikProvera(vp.Jmbg))
            {
                MessageBox.Show("Vec postoji vlasnik sa datim jmbg-om");
                return;
            }
            vp.L_Ime = txBoxIme.Text;
            vp.Prezime = txBoxPrezime.Text;
            if (DTOManager.DodajVlasnika(vp) == true)
            {
                MessageBox.Show("Dodat novi vlasnik");
                txBoxJMBG.Text = "";
                txBoxIme.Text = "";
                txBoxPrezime.Text = "";
            }
            else
            {
                MessageBox.Show("Nije dodat novi vlasnik usled tehnickih problema");
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            vp.Jmbg = txBoxJMBG.Text;
            if (DTOManager.VlasnikProvera(vp.Jmbg))
            {
                MessageBox.Show("Vec postoji vlasnik sa datim jmbg-om");
                return;
            }
            vp.L_Ime = txBoxIme.Text;
            vp.Prezime = txBoxPrezime.Text;
            if (DTOManager.DodajVlasnika(vp) == true)
            {
                MessageBox.Show("Dodat novi vlasnik");
                this.Close();
            }
            else
            {
                MessageBox.Show("Nije dodat novi vlasnik usled tehnickih problema");
            }
        }
    }
}
