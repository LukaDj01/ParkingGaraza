using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using ParkingGaraza.Entiteti;
using NHibernate.Linq;

namespace ParkingGaraza.Forme
{
    public partial class KarticePU : Form
    {
        public KarticePU()
        {
            InitializeComponent();
        }

        private void KarticePU_Load(object sender, EventArgs e)
        {
            this.PopulateInfos();
        }
        private void PopulateInfos()
        {
            listaKarata.Items.Clear();
            List<PojedinacnaUpotrebaPregled> puInfos = DTOManager.GetKartePUInfos();
            foreach (PojedinacnaUpotrebaPregled pu in puInfos)
            {
                ListViewItem item = new ListViewItem(new string[] { pu.KarticaId.ToString(), pu.VremeOd.ToString(), pu.VremeDo.ToString() });

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

        private void btnVozilo_Click(object sender, EventArgs e)
        {
            if (listaKarata.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite kartu");
                return;
            }

            int idKarte = Int32.Parse(listaKarata.SelectedItems[0].SubItems[0].Text);
            VoziloPregled vp = DTOManager.GetKartePUPregledVozilo(idKarte);

            InfoVozilo vpForm = new InfoVozilo(vp);
            vpForm.ShowDialog();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajPU dpuForma = new DodajPU();
            dpuForma.ShowDialog();
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
            PojedinacnaUpotrebaBasic pup = DTOManager.GetPUPregled(kId);
            if(pup.VremeDo != null)
            {
                MessageBox.Show("Ne mozete izmeniti isteklu karticu");
                return;
            }

            AzurirajPU apuForm = new AzurirajPU(pup);
            apuForm.ShowDialog();
            PopulateInfos();
        }
    }
}
