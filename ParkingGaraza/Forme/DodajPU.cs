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
    public partial class DodajPU : Form
    {
        public DodajPU()
        {
            InitializeComponent();
            cbBoxOperater.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxPM.Enabled = false;
        }

        private void DodajPU_Load(object sender, EventArgs e)
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
            txBoxVozilo.Text = "";
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
            if (DTOManager.VoziloProvera(Int32.Parse(txBoxVozilo.Text)) == false)
            {
                MessageBox.Show("Ne postoji u bazi vozilo sa datim id-em");
                return;
            }
            if (DTOManager.VoziloProveraKategorijePM(Int32.Parse(txBoxVozilo.Text), Int32.Parse(textBoxPM.Text)) == false)
            {
                MessageBox.Show("Vozilo se ne moze parkirati na dato parking mesto zbog neodgovarajuce kategorije");
                return;
            }
            if (DTOManager.KarticaPUVoziloProvera(Int32.Parse(txBoxVozilo.Text))==true)
            {
                MessageBox.Show("Dato vozilo vec poseduje aktivnu PU karticu");
                return;
            }
            /*if (DTOManager.KarticaPUVlasnikProvera(Int32.Parse(txBoxVozilo.Text)) == true)
            {
                MessageBox.Show("Vlasnik datog vozila vec poseduje aktivnu PRETPLATNU karticu");
                return;
            }*/
            if (DTOManager.DodajKarticuPU(cbBoxOperater.SelectedItem.ToString(), Int32.Parse(textBoxPM.Text), Int32.Parse(txBoxVozilo.Text)) == true)
            {
                MessageBox.Show("Uspesno dodata PU kartica");
                this.Close();
            }
            else
                MessageBox.Show("Nije dodata PU kartica usled tehnickih problema");


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
            if (DTOManager.VoziloProvera(Int32.Parse(txBoxVozilo.Text)) == false)
            {
                MessageBox.Show("Ne postoji u bazi vozilo sa datim id-em");
                return;
            }
            if (DTOManager.VoziloProveraKategorijePM(Int32.Parse(txBoxVozilo.Text), Int32.Parse(textBoxPM.Text)) == false)
            {
                MessageBox.Show("Vozilo se ne moze parkirati na dato parking mesto zbog neodgovarajuce kategorije");
                return;
            }
            if (DTOManager.KarticaPUVoziloProvera(Int32.Parse(txBoxVozilo.Text)) == true)
            {
                MessageBox.Show("Dato vozilo vec poseduje aktivnu PU karticu");
                return;
            }
            /*if (DTOManager.KarticaPUVlasnikProvera(Int32.Parse(txBoxVozilo.Text)) == true)
            {
                MessageBox.Show("Vlasnik datog vozila vec poseduje aktivnu PRETPLATNU karticu");
                return;
            }*/
            if (DTOManager.DodajKarticuPU(cbBoxOperater.SelectedItem.ToString(), Int32.Parse(textBoxPM.Text), Int32.Parse(txBoxVozilo.Text)) == true)
            {
                MessageBox.Show("Uspesno dodata PU kartica");
            }
            else
                MessageBox.Show("Nije dodata PU kartica usled tehnickih problema");

            PopulateData();
            textBoxPM.Text = "";
            txBoxVozilo.Text = "";
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
