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
    public partial class AzurirajPU : Form
    {
        public PojedinacnaUpotrebaBasic puBasic;
        public AzurirajPU()
        {
            InitializeComponent();
        }
        public AzurirajPU(PojedinacnaUpotrebaBasic pub)
        {
            this.puBasic = pub;
            InitializeComponent();
            PopulateData();
            cbBoxOperater.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxPM.Enabled = false;
        }
        private void PopulateData()
        {
            textBoxVozilo.Text = puBasic.IdVozilo.ToString();
            textBoxPM.Text = puBasic.ParkingId.ToString();
            cbBoxOperater.Items.Clear();
            cbBoxOperater.Items.Add(puBasic.JmbgOperater);
            IEnumerable<OperaterPregled> operateri = DTOManager.GetOpInfosBezKontroloraIOtpustenih();
            foreach (OperaterPregled o in operateri)
            {
                if(o.Jmbg != puBasic.JmbgOperater)
                    cbBoxOperater.Items.Add(o.Jmbg);
            }
            cbBoxOperater.Refresh();
            cbBoxOperater.SelectedItem = cbBoxOperater.Items[0];

        }

        private void AzurirajPU_Load(object sender, EventArgs e)
        {

        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (DTOManager.VoziloProvera(Int32.Parse(textBoxVozilo.Text)) == false)
            {
                MessageBox.Show("Ne postoji u bazi vozilo sa datim id-em");
                return;
            }
            if (DTOManager.VoziloProveraKategorijePM(Int32.Parse(textBoxVozilo.Text), Int32.Parse(textBoxPM.Text)) == false)
            {
                MessageBox.Show("Vozilo se ne moze parkirati na dato parking mesto zbog neodgovarajuce kategorije");
                return;
            }
            if (puBasic.IdVozilo != Int32.Parse(textBoxVozilo.Text) && DTOManager.KarticaPUVoziloProvera(Int32.Parse(textBoxVozilo.Text)) == true)
            {
                MessageBox.Show("Dato vozilo vec poseduje aktivnu PU karticu");
                return;
            }
            /*if (DTOManager.KarticaPUVlasnikProvera(Int32.Parse(txBoxVozilo.Text)) == true)
            {
                MessageBox.Show("Vlasnik datog vozila vec poseduje aktivnu PRETPLATNU karticu");
                return;
            }*/
            if (DTOManager.UpdateKarticuPU(puBasic, cbBoxOperater.SelectedItem.ToString(), Int32.Parse(textBoxPM.Text), Int32.Parse(textBoxVozilo.Text)) == true)
            {
                MessageBox.Show("Uspesno izmenjena PU kartica");
            }
            else
                MessageBox.Show("Nije izmenjena PU kartica usled tehnickih problema");
            this.Close();
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            Parking p = new Parking();
            if (p.ShowDialog() == DialogResult.OK)
            {
                textBoxPM.Text = p.TheValue;
            }
        }
    }
}
