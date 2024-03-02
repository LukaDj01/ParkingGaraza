using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkingGaraza.Entiteti;

namespace ParkingGaraza.Mapiranja
{
    class KontrolorMapiranja : ClassMap<Kontrolor>
    {
        public KontrolorMapiranja()
        {
            //Mapiranje tabele
            Table("KONTROLOR");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.DatumPocetka, "DATUM_POCETKA");
            Map(x => x.DatumKraja, "DATUM_KRAJA");

            //mapiranje veze 1:N Operater-Kartica
            HasMany(x => x.Operateri).KeyColumn("ID_KONTROLORA").LazyLoad().Cascade.All().Inverse();

            //mapiranje veze 1:1 Operater-Kontrolor
            References(x => x.JmbgOperatera).Column("JMBG").LazyLoad();
        }
    }
}
