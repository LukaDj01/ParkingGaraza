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
    public partial class KontrolorNovi : Form
    {
        public KontrolorNovi()
        {
            InitializeComponent();
        }

        private void KontrolorNovi_Load(object sender, EventArgs e)
        {
            this.PopulateInfos();
        }
        private void PopulateInfos()
        {
            listaOperatera.Items.Clear();
            List<OperaterPregled> opInfos = DTOManager.GetOpInfosBezTrKontrolora();
            foreach (OperaterPregled op in opInfos)
            {
                if(op.Smena != 0)
                {
                    ListViewItem item = new ListViewItem(new string[] { op.Jmbg, op.L_Ime, op.Prezime, op.RadniStaz.ToString() });

                    listaOperatera.Items.Add(item);
                }
            }
            listaOperatera.Refresh();
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            if (listaOperatera.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite operatera");
                return;
            }

            string opJmbg = listaOperatera.SelectedItems[0].SubItems[0].Text;
            OperaterPregled op = DTOManager.GetOperaterPregled(opJmbg);
            if (DTOManager.PostaviNovogKontrolora(op))
            {
                MessageBox.Show("Uspesno postavljen novi kontrolor!");
                this.Close();
            }
            else
                MessageBox.Show("Nije postavljen novi kontrolor usled tehnickih problema!");
        }
    }
}
