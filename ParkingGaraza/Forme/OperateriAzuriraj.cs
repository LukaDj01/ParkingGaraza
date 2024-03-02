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
    public partial class OperateriAzuriraj : Form
    {
        public OperaterPregled oPregled;
        public OperateriAzuriraj()
        {
            InitializeComponent();
        }
        public OperateriAzuriraj(OperaterPregled op)
        {
            this.oPregled = op;
            InitializeComponent();
            PopulateData();
            cmbBoxSmena.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void PopulateData()
        {
            txBoxJMBG.Text = oPregled.Jmbg;
            txBoxJMBG.Enabled = false; // ne sme da se menja id objekta
            txBoxIme.Text = oPregled.L_Ime;
            txBoxPrezime.Text = oPregled.Prezime;
            dateTimePickerRodjenje.Value = oPregled.DatumRodjenja;
            dateTimePickerZaposlenje.Value = oPregled.DatumZaposlenja;
            numRadniStaz.Value = oPregled.RadniStaz;
            cmbBoxSmena.Text = oPregled.Smena.ToString();
        }

        private void txBoxJMBG_TextChanged(object sender, EventArgs e)
        {
        }

        private void txBoxIme_TextChanged(object sender, EventArgs e)
        {
        }

        private void txBoxPrezime_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("snimanje podataka");
            oPregled.L_Ime = txBoxIme.Text;
            oPregled.Prezime = txBoxPrezime.Text;
            oPregled.DatumRodjenja = dateTimePickerRodjenje.Value;
            oPregled.DatumZaposlenja = dateTimePickerZaposlenje.Value;
            oPregled.RadniStaz = (int)numRadniStaz.Value;
            oPregled.Smena = Int32.Parse(cmbBoxSmena.Text);
            DTOManager.UpdateOperaterPregled(oPregled);
            MessageBox.Show("Uspesna izmena operatera!");
            this.Close();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            PopulateData();
        }
    }
}
