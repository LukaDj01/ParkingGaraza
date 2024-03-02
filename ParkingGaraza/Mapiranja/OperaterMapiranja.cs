using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkingGaraza.Entiteti;

namespace ParkingGaraza.Mapiranja
{
    class OperaterMapiranja : ClassMap<Operater> // ParkingGaraza.Entiteti.Operater
    {
        public OperaterMapiranja()
        {
            //Mapiranje tabele
            Table("OPERATER");

            //mapiranje primarnog kljuca
            Id(x => x.Jmbg, "JMBG").GeneratedBy.Assigned();

            //mapiranje svojstava
            Map(x => x.L_Ime, "L_IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
            Map(x => x.DatumZaposlenja, "DATUM_ZAPOSLENJA");
            Map(x => x.RadniStaz, "RADNI_STAZ");
            Map(x => x.Smena, "SMENA");

            //mapiranje veze 1:N Operater-Kartica
            HasMany(x => x.Kartice).KeyColumn("JMBG_OPERATERA").LazyLoad().Cascade.All().Inverse();

            //mapiranje veze 1:N Kontrolor-Operater
            References(x => x.Kontrolisan).Column("ID_KONTROLORA").LazyLoad();

            //mapiranje veze 1:N Operater-Kontrolor
            HasMany(x => x.Kontrolor).KeyColumn("JMBG").LazyLoad().Cascade.All();
        }
    }
}
