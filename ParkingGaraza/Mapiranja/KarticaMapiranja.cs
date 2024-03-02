using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkingGaraza.Entiteti;

namespace ParkingGaraza.Mapiranja
{
    class KarticaMapiranja : ClassMap<Kartica>
    {
        public KarticaMapiranja()
        {

            //Mapiranje tabele
            Table("KARTICA");

            //mapiranje podklasa
            DiscriminateSubClassesOnColumn("TIP");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            //Map(x => x.Tip, "TIP");
            Map(x => x.VremeOd, "VREME_OD");
            Map(x => x.VremeDo, "VREME_DO");

            //mapiranje veze 1:1 ParkingMesto-Kartica
            References(x => x.ParkingMesto).Column("ID_PARKINGA").LazyLoad();

            //mapiranje veze 1:N Operater-Kartica
            References(x => x.Operater).Column("JMBG_OPERATERA").LazyLoad();

        }
    }
    class PretplatnaMapiranja : SubclassMap<Pretplatna>
    {
        public PretplatnaMapiranja()
        {
            DiscriminatorValue("PRETPLATNA");

            //mapiranje veze 1:1 Vlasnik-Pretplatna
            References(x => x.Vlasnik).Column("JMBG_VLASNIKA").LazyLoad();
        }
    }

    class PojedinacnaUpotrebaMapiranja : SubclassMap<PojedinacnaUpotreba>
    {
        public PojedinacnaUpotrebaMapiranja()
        {
            DiscriminatorValue("POJEDINACNA_UPOTREBA");

            //mapiranje veze 1:1 Vozilo-PojedinacnaUpotreba
            References(x => x.Vozilo).Column("ID_VOZILA").LazyLoad();
        }
    }
}
