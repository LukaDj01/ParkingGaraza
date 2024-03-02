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
    public partial class KarticePretplatne : Form
    {
        public KarticePretplatne()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void KarticePretplatne_Load(object sender, EventArgs e)
        {
            this.PopulateInfos();
        }
        private void PopulateInfos()
        {
            listaKarata.Items.Clear();
            List<PretplatnaPregled> prInfos = DTOManager.GetKartePretplatneInfos();
            foreach (PretplatnaPregled pr in prInfos)
            {
                ListViewItem item = new ListViewItem(new string[] { pr.KarticaId.ToString(), pr.VremeOd.ToString(), pr.VremeDo.ToString() });

                listaKarata.Items.Add(item);
            }
            listaKarata.Refresh();
        }

        private void btnOperater_Click(object sender, EventArgs e)
        {
            if (listaKarata.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite kartu");
                return;
            }

            int idKarte = Int32.Parse(listaKarata.SelectedItems[0].SubItems[0].Text);
            OperaterPregled op = DTOManager.GetKartePregledOperater(idKarte);

            InfoOperater opaForm = new InfoOperater(op);
            opaForm.ShowDialog();
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            if (listaKarata.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite kartu");
                return;
            }

            int idKarte = Int32.Parse(listaKarata.SelectedItems[0].SubItems[0].Text);
            ParkingMestoPregled pmp = DTOManager.GetKartePregledParkingMesto(idKarte);

            InfoPM pmpForm = new InfoPM(pmp);
            pmpForm.ShowDialog();
        }

        private void btnVlasnik_Click(object sender, EventArgs e)
        {
            if (listaKarata.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite kartu");
                return;
            }

            int idKarte = Int32.Parse(listaKarata.SelectedItems[0].SubItems[0].Text);
            VlasnikPregled vp = DTOManager.GetKartePretPregledVlasnik(idKarte);

            InfoVlasnik vpForm = new InfoVlasnik(vp);
            vpForm.ShowDialog();

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajPretplatnu dpForma = new DodajPretplatnu();
            dpForma.ShowDialog();
            PopulateInfos();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listaKarata.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite karticu");
                return;
            }

            int kId = Int32.Parse(listaKarata.SelectedItems[0].SubItems[0].Text);
            PretplatnaBasic pb = DTOManager.GetPretplatnaPregled(kId);
            if (pb.VremeDo < DateTime.Now)
            {
                MessageBox.Show("Ne mozete izmeniti isteklu karticu");
                return;
            }

            AzurirajPretplatnu apForm = new AzurirajPretplatnu(pb);
            apForm.ShowDialog();
            PopulateInfos();
        }
    }
}
