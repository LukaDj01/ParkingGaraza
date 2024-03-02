using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using ParkingGaraza.Entiteti;

namespace ParkingGaraza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdUcitavanjeOperatera_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o operateru za zadatim jmbg-om
                Operater o = s.Get<Operater>("2806974730006");
                if (o != null)
                    MessageBox.Show(o.L_Ime);
                else
                    MessageBox.Show("Ne postoji operater sa zadatim identifikatorom!");
                s.Close();

            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void cmdDodavanjeOperatera_Click(object sender, EventArgs e)
        {
            try // treba da se doradi
            {
                ISession s = DataLayer.GetSession();


                Operater o = new Operater();

                //p = s.Load<Entiteti.Prodavnica>(81);

                o.Jmbg = "1104991730051";
                o.L_Ime = "Mirko";
                o.Prezime = "Mirkovic";
                o.DatumRodjenja = new DateTime(1991, 04, 11);
                o.DatumZaposlenja = new DateTime(2023, 05, 06);
                o.RadniStaz = 12;
                o.Smena = 2;
                //o.Kontrolisan = 11; ?? 

                MessageBox.Show(o.DatumRodjenja.ToString());
                MessageBox.Show(o.DatumZaposlenja.ToString());

                //s.Save(p);
                //s.SaveOrUpdate(o);

                //s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void cmdAzuriranjeOperatera_Click(object sender, EventArgs e)
        {

        }

        private void cmdBrisanjeOperatera_Click_1(object sender, EventArgs e)
        {

        }

        private void cmdDodavanjeKontrolora_Click(object sender, EventArgs e)
        {

        }

        private void cmdUcitavanjeKontrolora_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kontrolor o = s.Load<Kontrolor>(11);

                MessageBox.Show(o.DatumPocetka.ToString());
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdAzuriranjeKontrolora_Click(object sender, EventArgs e)
        {

        }

        private void cmdBrisanjeKontrolora_Click(object sender, EventArgs e)
        {

        }

        private void cmdUcitavanjeVlasnika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vlasnik o = s.Load<Vlasnik>("0809998730060");

                MessageBox.Show(o.L_Ime);
                
                foreach (Vozilo v in o.Vozila)
                {
                    MessageBox.Show(v.Id + " " + v.RegistarskiBroj);
                }
                
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodavanjeVlasnika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vlasnik vlasnik = new Vlasnik()
                {
                    Jmbg = "1709990780042",
                    L_Ime = "Paja",
                    Prezime = "Markov"
                };

                Vozilo vozilo1 = new Vozilo()
                {
                    RegistarskiBroj = "NI521OI",
                    Marka = "Fiat",
                    Tip = "Punto",
                    Kategorija = "B"
                };

                Vozilo vozilo2 = new Vozilo()
                {
                    RegistarskiBroj = "NI912VK",
                    Marka = "Audi",
                    Tip = "A4",
                    Kategorija = "A"
                };


                //s.Save(vlasnik);

                vozilo1.Vlasnik = vlasnik;
                //s.Save(vozilo1);

                vozilo2.Vlasnik = vlasnik;
                //s.Save(vozilo2);

                vlasnik.Vozila.Add(vozilo1);
                vlasnik.Vozila.Add(vozilo2);

                s.Save(vlasnik);

                s.Flush();
                s.Close();

                MessageBox.Show("Dodato!");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdAzuriranjeVlasnika_Click(object sender, EventArgs e)
        {

        }

        private void cmdBrisanjeVlasnika_Click(object sender, EventArgs e)
        {

        }

        private void cmdUcitavanjeVozila_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo o = s.Load<Vozilo>(11);

                MessageBox.Show(o.RegistarskiBroj);
                MessageBox.Show(o.Vlasnik.L_Ime);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodavanjeVozila_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vlasnik vlasnik = s.Load<Vlasnik>("0809998730060");

                Vozilo vozilo = new Vozilo()
                {
                    RegistarskiBroj = "NI521OI",
                    Marka = "Fiat",
                    Tip = "Punto",
                    Kategorija = "B"
                };

                vozilo.Vlasnik = vlasnik;

                s.Save(vozilo);

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdAzuriranjeVozila_Click(object sender, EventArgs e)
        {

        }

        private void cmdBrisanjeVozila_Click(object sender, EventArgs e)
        {

        }

        private void cmdUcitavanjeKarticePretplatna_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Kartica> kartice = s.QueryOver<Kartica>()
                                                .List<Kartica>();

                foreach (Kartica k in kartice)
                {
                    if (k.GetType() == typeof(Pretplatna))
                    {
                        Pretplatna p = (Pretplatna)k;
                        // prikaz
                    }
                    else
                    {
                        PojedinacnaUpotreba pu = (PojedinacnaUpotreba)k;
                    }
                }
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodavanjeKarticePretplatna_Click(object sender, EventArgs e)
        {

        }

        private void cmdAzuriranjeKarticePretplatna_Click(object sender, EventArgs e)
        {

        }

        private void cmdBrisanjeKarticePretplatna_Click(object sender, EventArgs e)
        {

        }

        private void cmdUcitavanjeKarticePU_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Kartica> kartice = s.QueryOver<Kartica>()
                                                .List<Kartica>();

                foreach (Kartica k in kartice)
                {
                    if (k.GetType() == typeof(Pretplatna))
                    {
                        Pretplatna p = (Pretplatna)k;
                    }
                    else
                    {
                        PojedinacnaUpotreba pu = (PojedinacnaUpotreba)k;
                        MessageBox.Show(pu.Vozilo.Marka);
                    }
                }
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodavanjeKarticePU_Click(object sender, EventArgs e)
        {

        }

        private void cmdAzuriranjeKarticePU_Click(object sender, EventArgs e)
        {

        }

        private void cmdBrisanjeKarticePU_Click(object sender, EventArgs e)
        {

        }

        private void cmdUcitavanjeParkingMesta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ParkingMesto o = s.Load<ParkingMesto>(2);

                MessageBox.Show(o.Zauzeto);
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodavanjeParkingMesta_Click(object sender, EventArgs e)
        {

        }

        private void cmdAzuriranjeParkingMesta_Click(object sender, EventArgs e)
        {

        }

        private void cmdBrisanjeParkingMesta_Click(object sender, EventArgs e)
        {

        }

        private void cmdUcitavanjeKategorije_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KategorijaParking o = s.Load<KategorijaParking>(1);

                MessageBox.Show(o.Kategorija);
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodavanjeKategorije_Click(object sender, EventArgs e)
        {

        }

        private void cmdAzuriranjeKategorije_Click(object sender, EventArgs e)
        {

        }

        private void cmdBrisanjeKategorije_Click(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Kartica> kartice = from o in s.Query<Kartica>()
                                           where o.VremeDo < DateTime.Now // za istekle kartice
                                           select o;

            IEnumerable<Kartica> kartice2 = from o in s.Query<Kartica>()
                                           where o.VremeDo > DateTime.Now || o.VremeDo == null // za vazece kartice
                                           select o;




            s.Close();
        }
    }
}
