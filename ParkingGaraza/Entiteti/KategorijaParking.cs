using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGaraza.Entiteti
{
    public class KategorijaParking
    {
        public virtual int Id { get; protected set; }
        public virtual string Kategorija { get; set; }

        public virtual ParkingMesto ParkingMesto { get; set; } // ref
    }
}
