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
    public partial class InfoVozilo : Form
    {
        public VoziloPregled vPregled;
        public InfoVozilo()
        {
            InitializeComponent();
        }
        public InfoVozilo(VoziloPregled vp)
        {
            this.vPregled = vp;
            InitializeComponent();
            PopulateData();
        }
        private void PopulateData()
        {
            txBoxID.Text = vPregled.Id.ToString();
            txBoxID.Enabled = false;
            txBoxRBr.Text = vPregled.RegistarskiBroj;
            txBoxRBr.Enabled = false;
            txBoxMarka.Text = vPregled.Marka;
            txBoxMarka.Enabled = false;
            txBoxTip.Text = vPregled.Tip;
            txBoxTip.Enabled = false;
            txBoxKat.Text = vPregled.Kategorija;
            txBoxKat.Enabled = false;
        }
    }
}
