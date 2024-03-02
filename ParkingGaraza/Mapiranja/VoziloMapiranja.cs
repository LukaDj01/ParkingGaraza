using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkingGaraza.Entiteti;

namespace ParkingGaraza.Mapiranja
{
    public class VoziloMapiranja : ClassMap<Vozilo>
    {
        public VoziloMapiranja()
        {
            //Mapiranje tabele
            Table("VOZILO");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.RegistarskiBroj, "REGISTARSKI_BROJ");
            Map(x => x.Marka, "MARKA");
            Map(x => x.Tip, "TIP");
            Map(x => x.Kategorija, "KATEGORIJA");

            //mapiranje veze 1:N Vlasnik-Vozilo
            References(x => x.Vlasnik).Column("JMBG_VLASNIKA").LazyLoad();

            //mapiranje veze 1:N Vozilo-PojedinacnaUpotreba
            HasMany(x => x.KarticaPU).KeyColumn("ID_VOZILA").LazyLoad().Cascade.All();
        }
    }
}
