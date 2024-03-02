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
    public partial class VozilaPromeniVlasnika : Form
    {
        public VlasnikPregled vPregled;

        public VoziloPregled voPregled;
        public VozilaPromeniVlasnika()
        {
            InitializeComponent();
        }
        public VozilaPromeniVlasnika(VlasnikPregled vp, VoziloPregled vop)
        {
            this.vPregled = vp;
            this.voPregled = vop;
            InitializeComponent();
            PopulateData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void PopulateData()
        {
            textBoxJMBG.Text = vPregled.Jmbg;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            bool uspesnaPromena = DTOManager.UpdateVoziloPromeniVlasnika(voPregled, textBoxJMBG.Text);
            if(uspesnaPromena == true)
            {
                MessageBox.Show("Uspesna promena vlasnika");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ne postoji vlasnik sa datim jmbg-om. Želite li da dodate vlasnika?");
                VlasniciDodaj vdForm = new VlasniciDodaj();
                vdForm.ShowDialog();
            }

            return;
        }

        private void VozilaPromeniVlasnika_Load(object sender, EventArgs e)
        {

        }
    }
}
