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
    public partial class AzurirajPretplatnu : Form
    {
        PretplatnaBasic pBasic;
        public AzurirajPretplatnu()
        {
            InitializeComponent();
        }
        public AzurirajPretplatnu(PretplatnaBasic pb)
        {
            this.pBasic = pb;
            InitializeComponent();
            PopulateData();
            cbBoxOperater.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxPM.Enabled = false;
        }
        private void PopulateData()
        {
            dateTimePickerVremeOd.Value = pBasic.VremeOd;
            dateTimePickerVremeDo.Value = DateTime.Parse(pBasic.VremeDo.ToString());
            textBoxVlasnik.Text = pBasic.JmbgVlasnik;
            textBoxPM.Text = pBasic.ParkingId.ToString();
            cbBoxOperater.Items.Clear();
            cbBoxOperater.Items.Add(pBasic.JmbgOperater);
            IEnumerable<OperaterPregled> operateri = DTOManager.GetOpInfosBezKontroloraIOtpustenih();
            foreach (OperaterPregled o in operateri)
            {
                if (o.Jmbg != pBasic.JmbgOperater)
                    cbBoxOperater.Items.Add(o.Jmbg);
            }
            cbBoxOperater.Refresh();
            cbBoxOperater.SelectedItem = cbBoxOperater.Items[0];
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (DTOManager.VlasnikProvera(textBoxVlasnik.Text) == false)
            {
                MessageBox.Show("Ne postoji u bazi vlasnik sa datim jmbg-om");
                return;
            }
            if (pBasic.JmbgVlasnik != textBoxVlasnik.Text && DTOManager.KarticaPretplatnaVlasnikProvera(textBoxVlasnik.Text) == true)
            {
                MessageBox.Show("Dati vlasnik vec poseduje aktivnu PRETPLATNU karticu");
                return;
            }
            if (dateTimePickerVremeOd.Value > dateTimePickerVremeDo.Value || dateTimePickerVremeDo.Value < DateTime.Now || dateTimePickerVremeOd.Value < DateTime.Now)
            {
                MessageBox.Show("Nije postavljeno validno vreme za karticu");
                return;
            }
            /*if (DTOManager.KarticaPUVlasnikProvera(Int32.Parse(txBoxVozilo.Text)) == true)
            {
                MessageBox.Show("Vlasnik datog vozila vec poseduje aktivnu PRETPLATNU karticu");
                return;
            }*/
            pBasic.VremeOd = dateTimePickerVremeOd.Value;
            pBasic.VremeDo = dateTimePickerVremeDo.Value;
            if (DTOManager.UpdateKarticuPretplatnu(pBasic, cbBoxOperater.SelectedItem.ToString(), Int32.Parse(textBoxPM.Text), textBoxVlasnik.Text) == true)
            {
                MessageBox.Show("Uspesno izmenjena PRETPLATNA kartica");
            }
            else
                MessageBox.Show("Nije izmenjena PRETPLATNA kartica usled tehnickih problema");
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
