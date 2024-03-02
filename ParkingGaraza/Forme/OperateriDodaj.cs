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
    public partial class OperateriDodaj : Form
    {
        public OperaterPregled op;
        public OperateriDodaj()
        {
            InitializeComponent();
            this.op = new OperaterPregled();
            cmbBoxSmena.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            txBoxJMBG.Text = "";
            txBoxIme.Text = "";
            txBoxPrezime.Text = "";
            dateTimePickerRodjenje.Value = DateTime.Now;
            dateTimePickerZaposlenje.Value = DateTime.Now;
            txBoxStaz.Text = "";
            cmbBoxSmena.SelectedIndex = cmbBoxSmena.Items.IndexOf(0);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            op.Jmbg = txBoxJMBG.Text;
            if(DTOManager.OperaterProvera(op.Jmbg))
            {
                MessageBox.Show("Vec postoji operater sa datim jmbg-om");
                return;
            }
            op.L_Ime = txBoxIme.Text;
            op.Prezime = txBoxPrezime.Text;
            op.DatumRodjenja = dateTimePickerRodjenje.Value;
            op.DatumZaposlenja = dateTimePickerZaposlenje.Value;
            op.RadniStaz = Int32.Parse(txBoxStaz.Text);
            op.Smena = Int32.Parse(cmbBoxSmena.Text);
            if(DTOManager.DodajOperatera(op)==true)
            {
                MessageBox.Show("Dodat novi operater");
                this.Close();
            }
            else
            {
                MessageBox.Show("Nije dodat novi operater usled tehnickih problema");
            }

        }

        private void btnNastavi_Click(object sender, EventArgs e)
        {
            op.Jmbg = txBoxJMBG.Text;
            if (DTOManager.OperaterProvera(op.Jmbg))
            {
                MessageBox.Show("Vec postoji operater sa datim jmbg-om");
                return;
            }
            op.L_Ime = txBoxIme.Text;
            op.Prezime = txBoxPrezime.Text;
            op.DatumRodjenja = dateTimePickerRodjenje.Value;
            op.DatumZaposlenja = dateTimePickerZaposlenje.Value;
            op.RadniStaz = Int32.Parse(txBoxStaz.Text);
            op.Smena = Int32.Parse(cmbBoxSmena.Text);
            if (DTOManager.DodajOperatera(op) == true)
            {
                MessageBox.Show("Dodat novi operater");
                txBoxJMBG.Text = "";
                txBoxIme.Text = "";
                txBoxPrezime.Text = "";
                dateTimePickerRodjenje.Value = DateTime.Now;
                dateTimePickerZaposlenje.Value = DateTime.Now;
                txBoxStaz.Text = "";
                cmbBoxSmena.SelectedIndex = cmbBoxSmena.Items.IndexOf(0);
            }
            else
            {
                MessageBox.Show("Nije dodat novi operater usled tehnickih problema");
            }
        }

        private void cmbBoxSmena_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
