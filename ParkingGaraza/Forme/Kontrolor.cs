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
    public partial class KontrolorForma : Form
    {
        public KontrolorPregled kPregled;
        public OperaterPregled oPregled;
        public KontrolorForma()
        {
            InitializeComponent();
        }
        public KontrolorForma(KontrolorPregled kp, OperaterPregled op)
        {
            this.kPregled = kp;
            this.oPregled = op;
            InitializeComponent();
            PopulateData();
        }
        private void PopulateData()
        {
            txBoxJMBG.Text = oPregled.Jmbg;
            txBoxJMBG.Enabled = false;
            txBoxIme.Text = oPregled.L_Ime;
            txBoxIme.Enabled = false;
            txBoxPrezime.Text = oPregled.Prezime;
            txBoxPrezime.Enabled = false;
            dateTimePickerRodjenje.Value = oPregled.DatumRodjenja;
            dateTimePickerRodjenje.Enabled = false;
            dateTimePickerZaposlenje.Value = oPregled.DatumZaposlenja;
            dateTimePickerZaposlenje.Enabled = false;
            txBoxStaz.Text = oPregled.RadniStaz.ToString();
            txBoxStaz.Enabled = false;
            dtpDatumPostavljanja.Value = kPregled.DatumPocetka;
            dtpDatumPostavljanja.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KontrolorIstorija kiForm = new KontrolorIstorija();
            kiForm.ShowDialog();
        }

        private void btnNoviKontrolor_Click(object sender, EventArgs e)
        {
            KontrolorNovi kNForm = new KontrolorNovi();
            kNForm.ShowDialog();
            kPregled = DTOManager.GetKontrolorPregled();
            oPregled = DTOManager.GetOperaterPregled(kPregled.JmbgOperatera);
            PopulateData();
        }
    }
}
