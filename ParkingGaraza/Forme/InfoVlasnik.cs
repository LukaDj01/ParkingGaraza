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
    public partial class InfoVlasnik : Form
    {
        public VlasnikPregled vPregled;
        public InfoVlasnik()
        {
            InitializeComponent();
        }

        private void listaVozila_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public InfoVlasnik(VlasnikPregled vp)
        {
            this.vPregled = vp;
            InitializeComponent();
            PopulateData();
        }
        private void PopulateData()
        {
            txBoxJMBG.Text = vPregled.Jmbg;
            txBoxJMBG.Enabled = false;
            txBoxIme.Text = vPregled.L_Ime;
            txBoxIme.Enabled = false;
            txBoxPrezime.Text = vPregled.Prezime;
            txBoxPrezime.Enabled = false;

            listaVozila.Items.Clear();
            foreach (VoziloPregled vp in vPregled.Vozila)
            {
                ListViewItem item = new ListViewItem(new string[] { vp.RegistarskiBroj, vp.Marka, vp.Tip });

                listaVozila.Items.Add(item);
            }
            listaVozila.Refresh();
        }
    }
}
