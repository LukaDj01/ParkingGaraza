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
    public partial class Operateri : Form
    {
        public Operateri()
        {
            InitializeComponent();
        }

        private void Operateri_Load(object sender, EventArgs e)
        {
            this.PopulateInfos();
            cmbBoxSmena.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxSmena.SelectedItem = cmbBoxSmena.Items[0];
        }
        private void PopulateInfos()
        {
            listaOperatera.Items.Clear();
            List<OperaterPregled> opInfos = DTOManager.GetOpInfos();
            KontrolorPregled kontrolor = DTOManager.GetKontrolorPregled();
            foreach (OperaterPregled op in opInfos)
            {
                if(kontrolor.JmbgOperatera != op.Jmbg)
                {
                    ListViewItem item;
                    if (op.Smena == 0)
                        item = new ListViewItem(new string[] { op.Jmbg, op.L_Ime, op.Prezime, op.DatumRodjenja.ToString(), op.DatumZaposlenja.ToString(), op.RadniStaz.ToString(), "/" });
                    else
                        item = new ListViewItem(new string[] { op.Jmbg, op.L_Ime, op.Prezime, op.DatumRodjenja.ToString(), op.DatumZaposlenja.ToString(), op.RadniStaz.ToString(), op.Smena.ToString() });
                    listaOperatera.Items.Add(item);
                }
            }
            listaOperatera.Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {   
            if (listaOperatera.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite operatera");
                return;
            }

            string opJmbg = listaOperatera.SelectedItems[0].SubItems[0].Text;
            OperaterPregled op = DTOManager.GetOperaterPregled(opJmbg);

            OperateriAzuriraj opaForm = new OperateriAzuriraj(op);
            if (opaForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PopulateInfos();
            }
        }

        private void btnKontrolor_Click(object sender, EventArgs e)
        {
            KontrolorPregled kp = DTOManager.GetKontrolorPregled();
            OperaterPregled op = DTOManager.GetOperaterPregled(kp.JmbgOperatera);

            KontrolorForma kForm = new KontrolorForma(kp, op);
            kForm.ShowDialog();

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            OperateriDodaj odForm = new OperateriDodaj();
            odForm.ShowDialog();
            PopulateInfos();
        }

        private void cmbBoxSmena_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaOperatera.Items.Clear();
            List<OperaterPregled> opInfos = new List<OperaterPregled>();
            KontrolorPregled kontrolor = DTOManager.GetKontrolorPregled();
            if (cmbBoxSmena.Text == "Sve")
                opInfos = DTOManager.GetOpInfos();
            else if (cmbBoxSmena.Text == "Otpušteni")
                opInfos = DTOManager.GetOpInfosSmena(0);
            else opInfos = DTOManager.GetOpInfosSmena(Int32.Parse(cmbBoxSmena.Text));
            foreach (OperaterPregled op in opInfos)
            {
                if (kontrolor.JmbgOperatera != op.Jmbg)
                {
                    ListViewItem item;
                    if (op.Smena == 0)
                        item = new ListViewItem(new string[] { op.Jmbg, op.L_Ime, op.Prezime, op.DatumRodjenja.ToString(), op.DatumZaposlenja.ToString(), op.RadniStaz.ToString(), "/" });
                    else
                        item = new ListViewItem(new string[] { op.Jmbg, op.L_Ime, op.Prezime, op.DatumRodjenja.ToString(), op.DatumZaposlenja.ToString(), op.RadniStaz.ToString(), op.Smena.ToString() });

                    listaOperatera.Items.Add(item);
                }
            }
            listaOperatera.Refresh();
        }


        private void btnOtpusti_Click(object sender, EventArgs e)
        {
            if (listaOperatera.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite operatera");
                return;
            }

            string opJmbg = listaOperatera.SelectedItems[0].SubItems[0].Text;
            if (DTOManager.OtpustiOperatera(opJmbg) == true)
            {
                MessageBox.Show("Uspesno otpušten operater");
                PopulateInfos();
            }
            else
                MessageBox.Show("Nije otpušten operater usled tehničkih problema");
        }
    }
}
