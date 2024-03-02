using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGaraza.Entiteti
{
    public class ParkingMesto
    {
        public virtual int Id { get; protected set; }
        public virtual int Sprat { get; set; }
        public virtual string Zauzeto { get; set; }

        public virtual IList<Kartica> Kartica { get; set; } // HasMany 

        public virtual IList<KategorijaParking> Kategorije { get; set; } // HasMany ?

        public ParkingMesto()
        {
            Kategorije = new List<KategorijaParking>();
        }
    }
}
