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
    public partial class VozilaDodaj : Form
    {
        public VoziloPregled vp;

        string jmbgVlasnika;
        public VozilaDodaj()
        {
            InitializeComponent();
            this.vp = new VoziloPregled();
            this.jmbgVlasnika = null;
        }
        public VozilaDodaj(string JmbgVlasnika)
        {
            InitializeComponent();
            this.vp = new VoziloPregled();
            this.jmbgVlasnika = JmbgVlasnika;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (DTOManager.VoziloProveraTablica(txBoxTablice.Text) == true)
            {
                MessageBox.Show("Vec postoji vozilo sa datim tablicama");
                return;
            }
            if (DTOManager.VlasnikProvera(textBoxJmbgVlasnika.Text)==false)
            {
                MessageBox.Show("Ne postoji vlasnik sa datim jmbg-om");
                return;
            }
            vp.RegistarskiBroj = txBoxTablice.Text;
            vp.Marka = txBoxMarka.Text;
            vp.Tip = textBoxTip.Text;
            vp.Kategorija = txBoxKategorija.Text;
            if (DTOManager.DodajVozilo(vp, textBoxJmbgVlasnika.Text) == true)
            {
                MessageBox.Show("Dodato novo vozilo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Nije dodato novo vozilo usled tehnickih problema");
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            txBoxTablice.Text = "";
            txBoxMarka.Text = "";
            textBoxTip.Text = "";
            txBoxKategorija.Text = "";
            if(this.jmbgVlasnika == null)
                textBoxJmbgVlasnika.Text = "";
        }

        private void VozilaDodaj_Load(object sender, EventArgs e)
        {
            if(this.jmbgVlasnika != null)
            {
                textBoxJmbgVlasnika.Text = this.jmbgVlasnika;
                textBoxJmbgVlasnika.Enabled = false;
            }
        }
    }
}
