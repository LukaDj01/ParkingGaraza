using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGaraza.Entiteti
{
    public abstract class Kartica
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime VremeOd { get; set; }
        public virtual DateTime? VremeDo { get; set; }
        public virtual string Tip { get; set; }

        public virtual Operater Operater { get; set; } // ref

        public virtual ParkingMesto ParkingMesto { get; set; } // ref

    }

    public class Pretplatna : Kartica
    {

        public virtual Vlasnik Vlasnik { get; set; } // ref

    }

    public class PojedinacnaUpotreba : Kartica
    {

        public virtual Vozilo Vozilo { get; set; } // ref

    }
}
