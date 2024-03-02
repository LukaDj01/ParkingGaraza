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
    public partial class VozilaAzuriraj : Form
    {
        public VoziloPregled vPregled;
        public VozilaAzuriraj()
        {
            InitializeComponent();
        }
        public VozilaAzuriraj(VoziloPregled vp)
        {
            this.vPregled = vp;
            InitializeComponent();
            PopulateData();
        }
        private void PopulateData()
        {
            txBoxTablice.Text = vPregled.RegistarskiBroj;
            txBoxMarka.Text = vPregled.Marka;
            txBoxTip.Text = vPregled.Tip;
            txBoxKategorija.Text = vPregled.Kategorija;
        }

        private void Izmeni_Click(object sender, EventArgs e)
        {
            vPregled.RegistarskiBroj = txBoxTablice.Text;
            vPregled.Marka = txBoxMarka.Text;
            vPregled.Tip = txBoxTip.Text;
            vPregled.Kategorija = txBoxKategorija.Text;
            DTOManager.UpdateVoziloPregled(vPregled);
            MessageBox.Show("Uspesna izmena vozila!");
            this.Close();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void button1_Click(object sender, EventArgs e) // promeni vlasnika
        {

            VlasnikPregled vlasnikPregled = DTOManager.GetVoziloVlasnikPregled(vPregled.Id);
            VozilaPromeniVlasnika vpvForm = new VozilaPromeniVlasnika(vlasnikPregled, vPregled);

            vpvForm.ShowDialog();

            PopulateData();
        }

        private void VozilaAzuriraj_Load(object sender, EventArgs e)
        {

        }
    }
}
