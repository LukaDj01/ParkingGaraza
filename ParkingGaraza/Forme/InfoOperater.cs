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
    public partial class InfoOperater : Form
    {
        public OperaterPregled oPregled;
        public InfoOperater()
        {
            InitializeComponent();
        }
        public InfoOperater(OperaterPregled op)
        {
            this.oPregled = op;
            InitializeComponent();
            PopulateData();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void InfoOperater_Load(object sender, EventArgs e)
        {
        }
        private void PopulateData()
        {
            txBoxJMBG.Text = oPregled.Jmbg;
            txBoxJMBG.Enabled = false;
            txBoxIme.Text = oPregled.L_Ime;
            txBoxIme.Enabled = false;
            txBoxPrezime.Text = oPregled.Prezime;
            txBoxPrezime.Enabled = false;
            txBoxSmena.Text = oPregled.Smena.ToString();
            txBoxSmena.Enabled = false;
        }
    }
}
