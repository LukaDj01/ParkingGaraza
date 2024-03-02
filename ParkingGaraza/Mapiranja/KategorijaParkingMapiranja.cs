using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkingGaraza.Entiteti;

namespace ParkingGaraza.Mapiranja
{
    class KategorijaParkingMapiranja : ClassMap<KategorijaParking>
    {
        public KategorijaParkingMapiranja()
        {
            //Mapiranje tabele
            Table("KATEGORIJA_PARKING");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.Kategorija, "KATEGORIJA");

            //mapiranje veze 1:N ParkingMesto-KategorijaParking
            References(x => x.ParkingMesto).Column("ID_PARKINGA").LazyLoad();
        }
    }
}
