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
    public partial class Vlasnici : Form
    {
        public Vlasnici()
        {
            InitializeComponent();
        }

        private void Vlasnici_Load(object sender, EventArgs e)
        {
            this.PopulateInfos();
        }
        private void PopulateInfos()
        {
            listaVlasnika.Items.Clear();
            List<VlasnikPregled> vInfos = DTOManager.GetVlasniciInfos();
            foreach (VlasnikPregled vp in vInfos)
            {
                ListViewItem item = new ListViewItem(new string[] { vp.Jmbg, vp.L_Ime, vp.Prezime });

                listaVlasnika.Items.Add(item);
            }
            listaVlasnika.Refresh();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            VlasniciDodaj vdForm = new VlasniciDodaj();
            vdForm.ShowDialog();
            PopulateInfos();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listaVlasnika.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite vlasnika");
                return;
            }

            string vpJmbg = listaVlasnika.SelectedItems[0].SubItems[0].Text;
            VlasnikPregled vp = DTOManager.GetVlasnikPregled(vpJmbg);

            VlasniciAzuriraj vpaForm = new VlasniciAzuriraj(vp);
            vpaForm.ShowDialog();
            PopulateInfos();
        }

        private void btnPrikazVozila_Click(object sender, EventArgs e)
        {
            if (listaVlasnika.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite vlasnika");
                return;
            }

            string vpJmbg = listaVlasnika.SelectedItems[0].SubItems[0].Text;
            VlasnikPregled vp = DTOManager.GetVlasnikPregled(vpJmbg);

            InfoVlasnik vpForm = new InfoVlasnik(vp);
            vpForm.ShowDialog();
        }
    }
}
