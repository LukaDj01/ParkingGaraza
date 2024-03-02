using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingGaraza.Entiteti;

namespace ParkingGaraza.Forme
{
    public partial class InfoPM : Form
    {
        public ParkingMestoPregled pmPregled;
        public InfoPM()
        {
            InitializeComponent();
        }
        public InfoPM(ParkingMestoPregled pmp)
        {
            this.pmPregled = pmp;
            InitializeComponent();
            PopulateData();
        }
        private void PopulateData()
        {
            txBoxID.Text = pmPregled.Id.ToString();
            txBoxID.Enabled = false;
            txBoxSprat.Text = pmPregled.Sprat.ToString();
            txBoxSprat.Enabled = false;


            foreach (string naziv in pmPregled.KategorijeNazivi)
            {
                cbxKategorija.Items.Add(naziv);
            }
            cbxKategorija.SelectedItem = cbxKategorija.Items[0];
            cbxKategorija.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
