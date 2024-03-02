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
    public partial class KontrolorIstorija : Form
    {
        public KontrolorIstorija()
        {
            InitializeComponent();
        }

        private void KontrolorIstorija_Load(object sender, EventArgs e)
        {
            this.PopulateInfos();
        }
        private void PopulateInfos()
        {
            listaKontrolora.Items.Clear();
            List<KontrolorPregled> kpInfos = DTOManager.GetKontroloriInfos();
            foreach (KontrolorPregled kp in kpInfos)
            {
                ListViewItem item = new ListViewItem();
                if (kp.DatumKraja == null)
                    item = new ListViewItem(new string[] { kp.Id.ToString(), kp.DatumPocetka.ToString(), "", kp.JmbgOperatera });
                else
                    item = new ListViewItem(new string[] { kp.Id.ToString(), kp.DatumPocetka.ToString(), kp.DatumKraja.ToString(), kp.JmbgOperatera });

                listaKontrolora.Items.Add(item);
            }
            listaKontrolora.Refresh();
        }
    }
}
