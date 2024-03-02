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
    public partial class VlasniciAzuriraj : Form
    {
        public VlasnikPregled vPregled;
        public VlasniciAzuriraj()
        {
            InitializeComponent();
        }
        public VlasniciAzuriraj(VlasnikPregled vp)
        {
            this.vPregled = vp;
            InitializeComponent();
            PopulateData();
        }
        private void PopulateData()
        {
            txBoxJMBG.Text = vPregled.Jmbg;
            txBoxJMBG.Enabled = false; // ne sme da se menja id objekta
            txBoxIme.Text = vPregled.L_Ime;
            txBoxPrezime.Text = vPregled.Prezime;
            listaVozila.Items.Clear();
            foreach (VoziloPregled vp in vPregled.Vozila)
            {
                ListViewItem item = new ListViewItem(new string[] { vp.RegistarskiBroj, vp.Marka, vp.Tip});

                listaVozila.Items.Add(item);
            }
            listaVozila.Refresh();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            vPregled.L_Ime = txBoxIme.Text;
            vPregled.Prezime = txBoxPrezime.Text;
            DTOManager.UpdateVlasnikPregled(vPregled);
            MessageBox.Show("Uspesna izmena vlasnika!");
            this.Close();

        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            VozilaDodaj vdForm = new VozilaDodaj(vPregled.Jmbg);
            vdForm.ShowDialog();
            PopulateData();
        }
    }
}
