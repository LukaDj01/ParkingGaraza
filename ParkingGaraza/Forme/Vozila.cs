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
    public partial class Vozila : Form
    {
        public Vozila()
        {
            InitializeComponent();
        }

        private void Vozila_Load(object sender, EventArgs e)
        {
            this.PopulateInfos();
        }
        private void PopulateInfos()
        {
            listaVozila.Items.Clear();
            List<VoziloPregled> vInfos = DTOManager.GetVozilaInfos();
            foreach (VoziloPregled vp in vInfos)
            {
                ListViewItem item = new ListViewItem(new string[] { vp.Id.ToString(), vp.RegistarskiBroj, vp.Marka, vp.Tip, vp.Kategorija });

                listaVozila.Items.Add(item);
            }
            listaVozila.Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listaVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite vozilo");
                return;
            }

            int vId = Int32.Parse(listaVozila.SelectedItems[0].SubItems[0].Text);
            VoziloPregled v = DTOManager.GetVoziloPregled(vId);

            VozilaAzuriraj vaForm = new VozilaAzuriraj(v);
            if (vaForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PopulateInfos();
            }
        }

        private void btnPrikazVlasnika_Click(object sender, EventArgs e)
        {
            if (listaVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite vozilo");
                return;
            }

            int vId = Int32.Parse(listaVozila.SelectedItems[0].SubItems[0].Text);
            VlasnikPregled vp = DTOManager.GetVlasnikPregledPrekoVozila(vId);

            InfoVlasnik vpForm = new InfoVlasnik(vp);
            vpForm.ShowDialog();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            VozilaDodaj vdForm = new VozilaDodaj();
            vdForm.ShowDialog();
            PopulateInfos();
        }
    }
}
