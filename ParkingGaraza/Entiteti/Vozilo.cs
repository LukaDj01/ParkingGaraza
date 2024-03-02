using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGaraza.Entiteti
{
    public class Vozilo
    {
        public virtual int Id { get; protected set; }
        public virtual string RegistarskiBroj { get; set; }
        public virtual string Marka { get; set; }
        public virtual string Tip { get; set; }
        public virtual string Kategorija { get; set; }

        public virtual Vlasnik Vlasnik { get; set; } // ref

        public virtual IList<PojedinacnaUpotreba> KarticaPU { get; set; } // HasMany

    }
}
