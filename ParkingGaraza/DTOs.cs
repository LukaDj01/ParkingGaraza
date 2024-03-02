using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParkingGaraza.Entiteti;
using System.Threading.Tasks;

namespace ParkingGaraza
{
    #region Kartica
    public class KarticaBasic
    {
        public  int KarticaId { get; set; }
        public  DateTime VremeOd { get; set; }
        public  DateTime? VremeDo { get; set; }
        public string JmbgOperater { get; set; }

        public int ParkingId { get; set; }

        public KarticaBasic(int karID, DateTime vremeOd, DateTime? vremeDo, string jmbgOpreter, int parkingId)
        {
            this.KarticaId = karID;
            this.VremeOd = vremeOd;
            this.VremeDo = vremeDo;
            this.JmbgOperater = jmbgOpreter;
            this.ParkingId = parkingId;
        }
        public KarticaBasic()
        {

        }
    }

    public class PretplatnaBasic : KarticaBasic
    {
        public string JmbgVlasnik { get; set; }
        public PretplatnaBasic()
        {

        }
        public PretplatnaBasic(int karID, DateTime vremeOd, DateTime? vremeDo, string jmbgOpreter, int parkingId, string jmbgVlasnik) : base(karID, vremeOd, vremeDo, jmbgOpreter, parkingId)
        {
            this.JmbgVlasnik = jmbgVlasnik;
        }

    }
    public class PojedinacnaUpotrebaBasic : KarticaBasic
    {
        public int IdVozilo { get; set; }
        public PojedinacnaUpotrebaBasic()
        {

        }
        public PojedinacnaUpotrebaBasic(int karID, DateTime vremeOd, DateTime? vremeDo, string jmbgOpreter, int parkingId, int idVozilo) : base(karID, vremeOd, vremeDo, jmbgOpreter, parkingId)
        {
            this.IdVozilo = idVozilo;
        }
    }
    public class KarticaPregled
    {
        public int KarticaId { get; set; }
        public DateTime VremeOd { get; set; }
        public DateTime? VremeDo { get; set; }

        public KarticaPregled(int karID, DateTime vremeOd, DateTime? vremeDo)
        {
            this.KarticaId = karID;
            this.VremeOd = vremeOd;
            this.VremeDo = vremeDo;
        }
        public KarticaPregled()
        {

        }
    }

    public class PretplatnaPregled : KarticaPregled
    {
        public PretplatnaPregled()
        {

        }
        public PretplatnaPregled(int karID, DateTime vremeOd, DateTime? vremeDo) : base(karID, vremeOd, vremeDo)
        {

        }

    }
    public class PojedinacnaUpotrebaPregled : KarticaPregled
    {
        public PojedinacnaUpotrebaPregled()
        {

        }
        public PojedinacnaUpotrebaPregled(int karID, DateTime vremeOd, DateTime? vremeDo) : base(karID, vremeOd, vremeDo)
        {

        }
    }
    #endregion
    #region Operater
    public class OperaterPregled
    {
        public string Jmbg { get; set; }
        public string L_Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public int RadniStaz { get; set; }
        public int Smena { get; set; }

        public OperaterPregled(string jmbg, string l_ime, string prezime, DateTime datumRodjenja, DateTime datumZaposlenja, int radniStaz, int smena)
        {
            this.Jmbg = jmbg;
            this.L_Ime = l_ime;
            this.Prezime = prezime;
            this.DatumRodjenja = datumRodjenja;
            this.DatumZaposlenja = datumZaposlenja;
            this.RadniStaz = radniStaz;
            this.Smena = smena;
        }
        public OperaterPregled()
        {

        }
    }
    #endregion
    #region Vozilo
    public class VoziloPregled
    {
        public int Id { get; set; }
        public string RegistarskiBroj { get; set; }
        public string Marka { get; set; }
        public string Tip { get; set; }
        public string Kategorija { get; set; }

        public VoziloPregled(int id, string registarskiBroj, string marka, string tip, string kategorija)
        {
            this.Id = id;
            this.RegistarskiBroj = registarskiBroj;
            this.Marka = marka;
            this.Tip = tip;
            this.Kategorija = kategorija;
        }
        public VoziloPregled()
        {

        }
    }
    #endregion
    #region ParkingMesto
    public class ParkingMestoPregled
    {
        public int Id { get; set; }
        public int Sprat { get; set; }
        public string Zauzeto { get; set; }
        public IList<string> KategorijeNazivi { get; set; }

        public ParkingMestoPregled(int id, int sprat, string zauzeto, IList<string> KategorijeNazivi)
        {
            this.Id = id;
            this.Sprat = sprat;
            this.Zauzeto = zauzeto;
            this.KategorijeNazivi = KategorijeNazivi;
        }
        public ParkingMestoPregled()
        {

        }
    }
    #endregion
    #region Vlasnik
    public class VlasnikPregled
    {
        public  string Jmbg { get; set; }
        public  string L_Ime { get; set; }
        public  string Prezime { get; set; }
        public  IList<VoziloPregled> Vozila { get; set; }

        public VlasnikPregled(string jmbg, string l_Ime, string prezime, IList<VoziloPregled> vozila)
        {
            this.Jmbg = jmbg;
            this.L_Ime = l_Ime;
            this.Prezime = prezime;
            this.Vozila = vozila;
        }
        public VlasnikPregled()
        {

        }
    }
    #endregion
    #region Kontrolor
    public class KontrolorPregled
    {
        public int Id { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime? DatumKraja { get; set; }

        public string JmbgOperatera { get; set; }

        public KontrolorPregled(int id, DateTime datumPocetka, DateTime? datumKraja, string jmbgOperatera)
        {
            this.Id = id;
            this.DatumPocetka = datumPocetka;
            this.DatumKraja = datumKraja;
            this.JmbgOperatera = jmbgOperatera;
        }
        public KontrolorPregled()
        {

        }
    }
    #endregion
}
