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
    public partial class DodajPretplatnu : Form
    {
        public DodajPretplatnu()
        {
            InitializeComponent();
            cbBoxOperater.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxPM.Enabled = false;
        }

        private void DodajPretplatnu_Load(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void PopulateData()
        {
            var c = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            var prva = new TimeSpan(6, 0, 0);
            var druga = new TimeSpan(14, 0, 0);
            var treca = new TimeSpan(22, 0, 0);

            int smena = (prva <= c && druga > c) ? 1 :
                        (druga <= c && treca > c) ? 2 : 3;

            cbBoxOperater.Items.Clear();
            IEnumerable<OperaterPregled> operateri = DTOManager.GetOpInfosBezKontroloraIOtpustenih();
            foreach (OperaterPregled o in operateri)
            {
                if (o.Smena == smena)
                    cbBoxOperater.Items.Add(o.Jmbg);
            }
            if (cbBoxOperater.Items.Count == 0)
            {
                cbBoxOperater.Items.Add($"Nema operatera u {smena}. smeni!");
            }
            cbBoxOperater.Refresh();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            cbBoxOperater.SelectedIndex = cbBoxOperater.Items.IndexOf(0);
            textBoxPM.Text = "";
            txBoxVlasnik.Text = "";
            dateTimePickerVremeOd.Text = "";
            dateTimePickerVremeDo.Text = "";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cbBoxOperater.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati operatera!");
                return;
            }
            if (textBoxPM.Text == "")
            {
                MessageBox.Show("Morate izabrati parking mesto!");
                return;
            }
            if (DTOManager.VlasnikProvera(txBoxVlasnik.Text) == false)
            {
                MessageBox.Show("Ne postoji u bazi vlasnik sa datim jmbg-om");
                return;
            }
            if (DTOManager.KarticaPretplatnaVlasnikProvera(txBoxVlasnik.Text) == true)
            {
                MessageBox.Show("Dati vlasnik vec poseduje aktivnu PRETPLATNU karticu");
                return;
            }
            if(dateTimePickerVremeOd.Value>dateTimePickerVremeDo.Value || dateTimePickerVremeDo.Value<DateTime.Now || dateTimePickerVremeOd.Value<DateTime.Now)
            {
                MessageBox.Show("Nije postavljeno validno vreme za karticu");
                return;
            }
            /*if (DTOManager.KarticaPUVlasnikProvera(Int32.Parse(txBoxVozilo.Text)) == true)
            {
                MessageBox.Show("Vlasnik datog vozila vec poseduje aktivnu PRETPLATNU karticu");
                return;
            }*/
            if (DTOManager.DodajKarticuPretplatna(cbBoxOperater.SelectedItem.ToString(), Int32.Parse(textBoxPM.Text), txBoxVlasnik.Text, dateTimePickerVremeOd.Value, dateTimePickerVremeDo.Value) == true)
            {
                MessageBox.Show("Uspesno dodata PRETPLATNA kartica");
                this.Close();
            }
            else
                MessageBox.Show("Nije dodata PRETPLATNA kartica usled tehnickih problema");
        }

        private void btnNastavi_Click(object sender, EventArgs e)
        {
            if (cbBoxOperater.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati operatera!");
                return;
            }
            if (textBoxPM.Text == "")
            {
                MessageBox.Show("Morate izabrati parking mesto!");
                return;
            }
            if (DTOManager.VlasnikProvera(txBoxVlasnik.Text) == false)
            {
                MessageBox.Show("Ne postoji u bazi vlasnik sa datim id-em");
                return;
            }
            if (DTOManager.KarticaPretplatnaVlasnikProvera(txBoxVlasnik.Text) == true)
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
            if (DTOManager.DodajKarticuPretplatna(cbBoxOperater.SelectedItem.ToString(), Int32.Parse(textBoxPM.Text), txBoxVlasnik.Text, dateTimePickerVremeOd.Value, dateTimePickerVremeDo.Value) == true)
            {
                MessageBox.Show("Uspesno dodata PRETPLATNA kartica");
            }
            else
                MessageBox.Show("Nije dodata PRETPLATNA kartica usled tehnickih problema");
            PopulateData();
            txBoxVlasnik.Text = "";
            textBoxPM.Text = "";
            dateTimePickerVremeOd.Text = "";
            dateTimePickerVremeDo.Text = "";
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            Parking p = new Parking();
            if (p.ShowDialog() == DialogResult.OK)
            {
                textBoxPM.Text = p.TheValue;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
