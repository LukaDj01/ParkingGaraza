using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using ParkingGaraza.Entiteti;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ParkingGaraza
{
    public class DTOManager
    {
        public static List<OperaterPregled> GetOpInfos()
        {
            List<OperaterPregled> opInfos = new List<OperaterPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Operater> operateri = from o in s.Query<Operater>()
                                                   select o;

                foreach (Operater o in operateri)
                {
                    opInfos.Add(new OperaterPregled(o.Jmbg, o.L_Ime, o.Prezime, o.DatumRodjenja, o.DatumZaposlenja, o.RadniStaz, o.Smena));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return opInfos;
        }

        public static OperaterPregled GetOperaterPregled(string opJmbg)
        {
            OperaterPregled op = new OperaterPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                Operater o = s.Load<Operater>(opJmbg);
                op = new OperaterPregled(o.Jmbg, o.L_Ime, o.Prezime, o.DatumRodjenja, o.DatumZaposlenja, o.RadniStaz, o.Smena);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return op;
        }

        public static OperaterPregled UpdateOperaterPregled(OperaterPregled op)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Operater o = s.Load<Operater>(op.Jmbg);
                o.L_Ime = op.L_Ime;
                o.Prezime = op.Prezime;
                o.DatumRodjenja = op.DatumRodjenja;
                o.DatumZaposlenja = op.DatumZaposlenja;
                o.RadniStaz = op.RadniStaz;
                o.Smena = op.Smena;

                s.Update(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return op;
        }
        public static List<PojedinacnaUpotrebaPregled> GetKartePUInfos()
        {
            List<PojedinacnaUpotrebaPregled> puInfos = new List<PojedinacnaUpotrebaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PojedinacnaUpotreba> pojedinacnaUpotreba = from pu in s.Query<PojedinacnaUpotreba>()
                                                                        select pu;

                foreach (PojedinacnaUpotreba pu in pojedinacnaUpotreba)
                {
                    puInfos.Add(new PojedinacnaUpotrebaPregled(pu.Id, pu.VremeOd, pu.VremeDo));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return puInfos;
        }

        public static OperaterPregled GetKartePregledOperater(int idKPU)
        {
            OperaterPregled op = new OperaterPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                Kartica pu = s.Load<Kartica>(idKPU);
                Operater o = s.Load<Operater>(pu.Operater.Jmbg);
                op = new OperaterPregled(o.Jmbg, o.L_Ime, o.Prezime, o.DatumRodjenja, o.DatumZaposlenja, o.RadniStaz, o.Smena);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return op;
        }

        public static VoziloPregled GetKartePUPregledVozilo(int idKPU)
        {
            VoziloPregled vp = new VoziloPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                PojedinacnaUpotreba pu = s.Load<PojedinacnaUpotreba>(idKPU);
                Vozilo v = s.Load<Vozilo>(pu.Vozilo.Id);
                vp = new VoziloPregled(v.Id, v.RegistarskiBroj, v.Marka, v.Tip, v.Kategorija);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return vp;
        }

        public static ParkingMestoPregled GetKartePregledParkingMesto(int idKPU)
        {
            ParkingMestoPregled pmp = new ParkingMestoPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                Kartica pu = s.Load<Kartica>(idKPU);
                ParkingMesto pm = s.Load<ParkingMesto>(pu.ParkingMesto.Id);
                IList<string> kategorijeNazivi = new List<string>();
                foreach(KategorijaParking kp in pm.Kategorije)
                {
                    kategorijeNazivi.Add(kp.Kategorija);
                }
                pmp = new ParkingMestoPregled(pm.Id, pm.Sprat, pm.Zauzeto, kategorijeNazivi);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return pmp;
        }
        public static List<PretplatnaPregled> GetKartePretplatneInfos()
        {
            List<PretplatnaPregled> prInfos = new List<PretplatnaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Pretplatna> pretplatna = from pr in s.Query<Pretplatna>()
                                                                       select pr;

                foreach (Pretplatna pr in pretplatna)
                {
                    prInfos.Add(new PretplatnaPregled(pr.Id, pr.VremeOd, pr.VremeDo));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return prInfos;
        }
        public static VlasnikPregled GetKartePretPregledVlasnik(int idKPU)
        {
            VlasnikPregled vp = new VlasnikPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                Pretplatna pr = s.Load<Pretplatna>(idKPU);
                Vlasnik v = s.Load<Vlasnik>(pr.Vlasnik.Jmbg);
                IList<VoziloPregled> vozila = new List<VoziloPregled>();
                foreach (Vozilo vo in v.Vozila)
                {
                    VoziloPregled voziloPregled = new VoziloPregled(vo.Id, vo.RegistarskiBroj, vo.Marka, vo.Tip, "kategorija");
                    vozila.Add(voziloPregled);
                }
                vp = new VlasnikPregled(v.Jmbg, v.L_Ime, v.Prezime, vozila);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return vp;
        }
        public static List<VoziloPregled> GetVozilaInfos()
        {
            List<VoziloPregled> vInfos = new List<VoziloPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Vozilo> vozilo = from v in s.Query<Vozilo>()
                                                     select v;

                foreach (Vozilo v in vozilo)
                {
                    vInfos.Add(new VoziloPregled(v.Id, v.RegistarskiBroj, v.Marka, v.Tip, v.Kategorija));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return vInfos;
        }

        public static VoziloPregled GetVoziloPregled(int vId)
        {
            VoziloPregled vp = new VoziloPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo v = s.Load<Vozilo>(vId);
                vp = new VoziloPregled(v.Id, v.RegistarskiBroj, v.Marka, v.Tip, v.Kategorija);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return vp;
        }
        public static VoziloPregled UpdateVoziloPregled(VoziloPregled vp)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo v = s.Load<Vozilo>(vp.Id);
                v.RegistarskiBroj = vp.RegistarskiBroj;
                v.Marka = vp.Marka;
                v.Tip = vp.Tip;
                v.Kategorija = vp.Kategorija;

                s.Update(v);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return vp;
        }
        public static List<VlasnikPregled> GetVlasniciInfos()
        {
            List<VlasnikPregled> vInfos = new List<VlasnikPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Vlasnik> vlasnik = from v in s.Query<Vlasnik>()
                                             select v;

                IList<VoziloPregled> vozila = new List<VoziloPregled>();
                
                foreach (Vlasnik v in vlasnik)
                {
                    vInfos.Add(new VlasnikPregled(v.Jmbg, v.L_Ime, v.Prezime, vozila));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return vInfos;
        }
        public static VlasnikPregled GetVoziloVlasnikPregled(int idVozila)
        {
            VlasnikPregled vp = new VlasnikPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo vozilo = s.Load<Vozilo>(idVozila);
                Vlasnik v = s.Load<Vlasnik>(vozilo.Vlasnik.Jmbg);

                IList<VoziloPregled> vozila = new List<VoziloPregled>();

                vp = new VlasnikPregled(v.Jmbg, v.L_Ime, v.Prezime, vozila);
                

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return vp;
        }
        public static bool UpdateVoziloPromeniVlasnika(VoziloPregled vp, string jmbgNovogVlasnika)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo v = s.Load<Vozilo>(vp.Id);
                Vlasnik vl = s.Get<Vlasnik>(jmbgNovogVlasnika);
                if (vl != null)
                {
                    v.Vlasnik = vl;
                    s.Update(v);
                    s.Flush();
                    s.Close();
                    return true;
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return false;
        }

        public static KontrolorPregled GetKontrolorPregled()
        {
            KontrolorPregled kp = new KontrolorPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Kontrolor> kv = from k in s.Query<Kontrolor>()
                                           where k.DatumKraja == null
                                           select k;

                kp = new KontrolorPregled(kv.First().Id, kv.First().DatumPocetka, kv.First().DatumKraja, kv.First().JmbgOperatera.Jmbg);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return kp;
        }
        public static List<KontrolorPregled> GetKontroloriInfos()
        {
            List<KontrolorPregled> kInfos = new List<KontrolorPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Kontrolor> kontrolori = from k in s.Query<Kontrolor>()
                                               select k;

                foreach (Kontrolor k in kontrolori)
                {
                    kInfos.Add(new KontrolorPregled(k.Id, k.DatumPocetka, k.DatumKraja, k.JmbgOperatera.Jmbg));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return kInfos;
        }
        public static List<OperaterPregled> GetOpInfosBezTrKontrolora()
        {
            List<OperaterPregled> opInfos = new List<OperaterPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Operater> operateri = from o in s.Query<Operater>()
                                                  select o;
                KontrolorPregled k = GetKontrolorPregled();
                foreach (Operater o in operateri)
                {
                    if (o.Jmbg!=k.JmbgOperatera)
                        opInfos.Add(new OperaterPregled(o.Jmbg, o.L_Ime, o.Prezime, o.DatumRodjenja, o.DatumZaposlenja, o.RadniStaz, o.Smena));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return opInfos;
        }

        public static bool PostaviNovogKontrolora(OperaterPregled op)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Operater noviKontrolor = s.Load<Operater>(op.Jmbg);

                KontrolorPregled kp = GetKontrolorPregled();
                Kontrolor prethodniKontrolor = s.Load<Kontrolor>(kp.Id);

                Kontrolor novi = new Kontrolor();
                novi.DatumPocetka = DateTime.Now;
                novi.DatumKraja = null;
                novi.JmbgOperatera = noviKontrolor;
                s.Save(novi);


                IEnumerable<Operater> operateri = from ope in s.Query<Operater>()
                                                  select ope;
                foreach(Operater operater in operateri)
                {
                    operater.Kontrolisan = novi;
                    s.Update(operater);
                }

                prethodniKontrolor.DatumKraja = DateTime.Now;
                s.Update(prethodniKontrolor);

                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return false;
        }
        public static bool DodajOperatera(OperaterPregled o)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable <Kontrolor> kontrolor = from k in s.Query<Kontrolor>()
                                             where k.DatumKraja == null
                                             select k;
                Operater op = new Operater();
                op.Jmbg = o.Jmbg;
                op.L_Ime = o.L_Ime;
                op.Prezime = o.Prezime;
                op.DatumRodjenja = o.DatumRodjenja;
                op.DatumZaposlenja = o.DatumZaposlenja;
                op.RadniStaz = o.RadniStaz;
                op.Smena = o.Smena;
                op.Kontrolisan = kontrolor.First();

                s.SaveOrUpdate(op);

                s.Flush();

                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return false;
        }
        public static bool OperaterProvera(string oJmbg)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Operater operater = s.Get<Operater>(oJmbg);
                if (operater != null)
                    return true;

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return false;
        }

        public static List<OperaterPregled> GetOpInfosSmena(int smena)
        {
            List<OperaterPregled> opInfos = new List<OperaterPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Operater> operateri = from o in s.Query<Operater>()
                                                  where o.Smena == smena
                                                  select o;

                foreach (Operater o in operateri)
                {
                    opInfos.Add(new OperaterPregled(o.Jmbg, o.L_Ime, o.Prezime, o.DatumRodjenja, o.DatumZaposlenja, o.RadniStaz, o.Smena));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return opInfos;
        }
        public static bool VlasnikProvera(string vJmbg)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vlasnik vlasnik = s.Get<Vlasnik>(vJmbg);
                if (vlasnik != null)
                    return true;

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return false;
        }
        public static bool DodajVlasnika(VlasnikPregled v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vlasnik vp = new Vlasnik();
                vp.Jmbg = v.Jmbg;
                vp.L_Ime = v.L_Ime;
                vp.Prezime = v.Prezime;

                s.SaveOrUpdate(vp);

                s.Flush();

                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return false;
        }

        public static VlasnikPregled GetVlasnikPregled(string vpJmbg)
        {
            VlasnikPregled vp = new VlasnikPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                Vlasnik v = s.Load<Vlasnik>(vpJmbg);
                IList<VoziloPregled> vozila = new List<VoziloPregled>();
                foreach (Vozilo vo in v.Vozila)
                {
                    VoziloPregled voziloPregled = new VoziloPregled(vo.Id, vo.RegistarskiBroj, vo.Marka, vo.Tip, vo.Kategorija);
                    vozila.Add(voziloPregled);
                }
                vp = new VlasnikPregled(v.Jmbg, v.L_Ime, v.Prezime, vozila);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return vp;
        }

        public static VlasnikPregled UpdateVlasnikPregled(VlasnikPregled vp)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Vlasnik v = s.Load<Vlasnik>(vp.Jmbg);
                v.L_Ime = vp.L_Ime;
                v.Prezime = vp.Prezime;

                s.Update(v);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return vp;
        }
        public static bool PMProvera(int pmId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ParkingMesto pm = s.Get<ParkingMesto>(pmId);
                if (pm != null)
                    return true;

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return false;
        }
        public static bool VoziloProvera(int vId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo vozilo = s.Get<Vozilo>(vId);
                if (vozilo != null)
                    return true;

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return false;
        }
        public static bool DodajKarticuPU(string oJmbg, int pmId, int vId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Operater o = s.Load<Operater>(oJmbg);
                ParkingMesto pm = s.Load<ParkingMesto>(pmId);
                Vozilo v = s.Load<Vozilo>(vId);
                PojedinacnaUpotreba pu = new PojedinacnaUpotreba();
                pu.VremeOd = DateTime.Now;
                pu.VremeDo = null;
                pu.Operater = o;
                pu.ParkingMesto = pm;
                pu.Vozilo = v;

                s.SaveOrUpdate(pu);
                s.Flush();

                pm.Zauzeto = "Da";

                s.Update(pm);
                s.Flush();

                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return false;
        }
        public static bool PMZauzetoProvera(int pmID)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ParkingMesto pm = s.Get<ParkingMesto>(pmID);

                if (pm.Zauzeto == "Da")
                    return true;

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return false;
        }
        public static bool KarticaPUVoziloProvera(int vID)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PojedinacnaUpotreba> kartice = from o in s.Query<PojedinacnaUpotreba>()
                                               where o.Vozilo.Id == vID && o.VremeDo == null
                                                           select o;
                PojedinacnaUpotreba k = kartice.FirstOrDefault();
                if (k != null)
                    return true;

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return false;
        }
        public static void OslobodiPM()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<KarticaBasic> kb = GetAktivneKartice();
                IList<int> idPMs = new List<int>();
                foreach(KarticaBasic k in kb)
                {
                    idPMs.Add(k.ParkingId);
                }
                IEnumerable<ParkingMesto> parkingMesta = from o in s.Query<ParkingMesto>()
                                                         where idPMs.Contains(o.Id) == false
                                                         select o;

                foreach (ParkingMesto pm in parkingMesta)
                {
                    pm.Zauzeto = "Ne";
                    s.Update(pm);
                }

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        public static bool OtpustiOperatera(string oJmbg)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Operater o = s.Load<Operater>(oJmbg);

                o.Smena = 0;
                s.Update(o);
                s.Flush();
                s.Close();
                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return false;
        }
        public static List<OperaterPregled> GetOpInfosBezKontroloraIOtpustenih()
        {
            List<OperaterPregled> opInfos = new List<OperaterPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                KontrolorPregled kontrolor = GetKontrolorPregled();
                IEnumerable<Operater> operateri = from o in s.Query<Operater>()
                                                  where o.Jmbg != kontrolor.JmbgOperatera && o.Smena != 0
                                                  select o;

                foreach (Operater o in operateri)
                {
                    opInfos.Add(new OperaterPregled(o.Jmbg, o.L_Ime, o.Prezime, o.DatumRodjenja, o.DatumZaposlenja, o.RadniStaz, o.Smena));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return opInfos;
        }
        public static List<ParkingMestoPregled> GetSlobodnaPM()
        {
            List<ParkingMestoPregled> pmpInfos = new List<ParkingMestoPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ParkingMesto> pmesta = from o in s.Query<ParkingMesto>()
                                                  where o.Zauzeto == "Ne"
                                                  select o;

                foreach (ParkingMesto o in pmesta)
                {
                    pmpInfos.Add(new ParkingMestoPregled(o.Id, o.Sprat, o.Zauzeto, new List<string>()));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return pmpInfos;
        }
        /*public static bool KarticaPUVlasnikProvera(int voziloID) // da li vlasnik vec ima aktivnu pretplatnu kartu
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo v = s.Load<Vozilo>(voziloID);
                IEnumerable<Pretplatna> kartice = from o in s.Query<Pretplatna>()
                                                           where o.Vlasnik.Vozila.Contains(v) && o.VremeDo > DateTime.Now
                                                           select o;
                Pretplatna k = kartice.FirstOrDefault();
                if (k != null)
                    return true;

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return false;
        }*/
        public static List<KarticaBasic> GetAktivneKartice()
        {
            List<KarticaBasic> kpInfos = new List<KarticaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Kartica> kartice = from o in s.Query<Kartica>()
                                                         where o.VremeDo == null || o.VremeDo > DateTime.Now
                                                         select o;
                foreach(Kartica k in kartice)
                {
                    KarticaBasic ka = new KarticaBasic(k.Id, k.VremeOd, k.VremeDo, k.Operater.Jmbg, k.ParkingMesto.Id);
                    kpInfos.Add(ka);
                }
                
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return kpInfos;
        }
        public static VlasnikPregled GetVlasnikPregledPrekoVozila(int vId)
        {
            VlasnikPregled vp = new VlasnikPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo vozilo = s.Load<Vozilo>(vId);
                Vlasnik v = s.Load<Vlasnik>(vozilo.Vlasnik.Jmbg);
                IList<VoziloPregled> vozila = new List<VoziloPregled>();
                foreach (Vozilo vo in v.Vozila)
                {
                    VoziloPregled voziloPregled = new VoziloPregled(vo.Id, vo.RegistarskiBroj, vo.Marka, vo.Tip, "kategorija");
                    vozila.Add(voziloPregled);
                }
                vp = new VlasnikPregled(v.Jmbg, v.L_Ime, v.Prezime, vozila);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return vp;
        }
        public static bool DodajVozilo(VoziloPregled v, string jmbgVlasnika)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vlasnik vlasnik = s.Load<Vlasnik>(jmbgVlasnika);
                Vozilo vozilo = new Vozilo();
                vozilo.RegistarskiBroj = v.RegistarskiBroj;
                vozilo.Marka = v.Marka;
                vozilo.Tip = v.Tip;
                vozilo.Kategorija = v.Kategorija;
                vozilo.Vlasnik = vlasnik;

                s.SaveOrUpdate(vozilo);

                s.Flush();

                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return false;
        }
        public static bool VoziloProveraKategorijePM(int vId, int pmId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo vozilo = s.Load<Vozilo>(vId);
                IEnumerable<KategorijaParking> kp = from o in s.Query<KategorijaParking>()
                                                    where o.ParkingMesto.Id == pmId
                                                    select o;
                IList<string> kategorije = new List<string>();
                foreach(KategorijaParking k in kp)
                {
                    kategorije.Add(k.Kategorija);
                }
                if (kategorije.Contains(vozilo.Kategorija))
                    return true;

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return false;
        }
        public static bool KarticaPretplatnaVlasnikProvera(string vJmbg)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Pretplatna> kartice = from o in s.Query<Pretplatna>()
                                                           where o.Vlasnik.Jmbg == vJmbg && o.VremeDo > DateTime.Now
                                                           select o;
                Pretplatna k = kartice.FirstOrDefault();
                if (k != null)
                    return true;

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return false;
        }
        public static bool DodajKarticuPretplatna(string oJmbg, int pmId, string vJmbg, DateTime vremeOd, DateTime vremeDo)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Operater o = s.Load<Operater>(oJmbg);
                ParkingMesto pm = s.Load<ParkingMesto>(pmId);
                Vlasnik v = s.Load<Vlasnik>(vJmbg);
                Pretplatna pu = new Pretplatna();
                pu.VremeOd = vremeOd;
                pu.VremeDo = vremeDo;
                pu.Operater = o;
                pu.ParkingMesto = pm;
                pu.Vlasnik = v;

                s.SaveOrUpdate(pu);
                s.Flush();

                pm.Zauzeto = "Da";

                s.Update(pm);
                s.Flush();

                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return false;
        }

        public static PojedinacnaUpotrebaBasic GetPUPregled(int kId)
        {
            PojedinacnaUpotrebaBasic pu = new PojedinacnaUpotrebaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                PojedinacnaUpotreba v = s.Load<PojedinacnaUpotreba>(kId);
                
                pu = new PojedinacnaUpotrebaBasic(v.Id, v.VremeOd, v.VremeDo, v.Operater.Jmbg, v.ParkingMesto.Id, v.Vozilo.Id);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return pu;
        }
        public static bool UpdateKarticuPU(PojedinacnaUpotrebaBasic puBasic, string oJmbg, int pmId, int vId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Operater o = s.Load<Operater>(oJmbg);
                ParkingMesto prethodnoPM = s.Load<ParkingMesto>(puBasic.ParkingId);
                ParkingMesto pm = s.Load<ParkingMesto>(pmId);
                Vozilo v = s.Load<Vozilo>(vId);
                PojedinacnaUpotreba pu = s.Load<PojedinacnaUpotreba>(puBasic.KarticaId);
                pu.VremeOd = DateTime.Now;
                pu.Operater = o;
                pu.ParkingMesto = pm;
                pu.Vozilo = v;

                s.SaveOrUpdate(pu);
                s.Flush();

                prethodnoPM.Zauzeto = "Ne";
                s.SaveOrUpdate(prethodnoPM);
                s.Flush();

                pm.Zauzeto = "Da";
                s.SaveOrUpdate(pm);
                s.Flush();

                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return false;
        }

        public static PretplatnaBasic GetPretplatnaPregled(int kId)
        {
            PretplatnaBasic pb = new PretplatnaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Pretplatna v = s.Load<Pretplatna>(kId);

                pb = new PretplatnaBasic(v.Id, v.VremeOd, v.VremeDo, v.Operater.Jmbg, v.ParkingMesto.Id, v.Vlasnik.Jmbg);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return pb;
        }
        public static bool UpdateKarticuPretplatnu(PretplatnaBasic pBasic, string oJmbg, int pmId, string vJmbg)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Operater o = s.Load<Operater>(oJmbg);
                ParkingMesto prethodnoPM = s.Load<ParkingMesto>(pBasic.ParkingId);
                ParkingMesto pm = s.Load<ParkingMesto>(pmId);
                Vlasnik v = s.Load<Vlasnik>(vJmbg);
                Pretplatna pu = s.Load<Pretplatna>(pBasic.KarticaId);
                pu.VremeOd = pBasic.VremeOd;
                pu.VremeDo = pBasic.VremeDo;
                pu.Operater = o;
                pu.ParkingMesto = pm;
                pu.Vlasnik = v;

                s.SaveOrUpdate(pu);
                s.Flush(); 
                
                prethodnoPM.Zauzeto = "Ne";
                s.SaveOrUpdate(prethodnoPM);
                s.Flush();

                pm.Zauzeto = "Da";
                s.SaveOrUpdate(pm);
                s.Flush();


                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return false;
        }
        public static bool VoziloProveraTablica(string tablice)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Vozilo> vozila = from v in s.Query<Vozilo>()
                                where v.RegistarskiBroj == tablice
                                select v;
                if (vozila.Any())
                    return true;

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return false;
        }
        public static List<ParkingMestoPregled> GetPMInfos()
        {
            List<ParkingMestoPregled> pmInfos = new List<ParkingMestoPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ParkingMesto> parkingMesta = from o in s.Query<ParkingMesto>()
                                                        select o;

                foreach (ParkingMesto o in parkingMesta)
                {
                    pmInfos.Add(new ParkingMestoPregled(o.Id, o.Sprat, o.Zauzeto, new List<string>()));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return pmInfos;
        }
    }
}
