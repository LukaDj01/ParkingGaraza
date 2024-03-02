using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkingGaraza.Entiteti;

namespace ParkingGaraza.Mapiranja
{
    class ParkingMestoMapiranja : ClassMap<ParkingMesto>
    {
        public ParkingMestoMapiranja()
        {
            //Mapiranje tabele
            Table("PARKING_MESTO");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.Sprat, "SPRAT");
            Map(x => x.Zauzeto, "ZAUZETO");

            //mapiranje veze 1:N ParkingMesto-Kartica
            HasMany(x => x.Kartica).KeyColumn("ID_PARKINGA").LazyLoad().Cascade.All();

            //mapiranje veze 1:N ParkingMesto-KategorijaParking
            HasMany(x => x.Kategorije).KeyColumn("ID_PARKINGA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
