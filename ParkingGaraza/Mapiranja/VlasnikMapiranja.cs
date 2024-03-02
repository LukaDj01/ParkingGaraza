using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkingGaraza.Entiteti;

namespace ParkingGaraza.Mapiranja
{
    class VlasnikMapiranja : ClassMap<Vlasnik>
    {
        public VlasnikMapiranja()
        {
            //Mapiranje tabele
            Table("VLASNIK");

            //mapiranje primarnog kljuca
            Id(x => x.Jmbg, "JMBG").GeneratedBy.Assigned();

            //mapiranje svojstava
            Map(x => x.L_Ime, "L_IME");
            Map(x => x.Prezime, "PREZIME");

            //mapiranje veze 1:N Vlasnik-Vozilo
            HasMany(x => x.Vozila).KeyColumn("JMBG_VLASNIKA").LazyLoad().Cascade.All().Inverse();

            //mapiranje veze 1:1 Vlasnik-Pretplatna
            HasMany(x => x.KarticaPretplatna).KeyColumn("JMBG_VLASNIKA").LazyLoad().Cascade.All();
        }
    }
}
