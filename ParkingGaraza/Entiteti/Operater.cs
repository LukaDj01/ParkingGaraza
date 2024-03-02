using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGaraza.Entiteti
{
    public class Operater
    {
        public virtual string Jmbg { get; set; }
        public virtual string L_Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual DateTime DatumZaposlenja { get; set; }
        public virtual int RadniStaz { get; set; }
        public virtual int Smena { get; set; }

        public virtual Kontrolor Kontrolisan { get; set; } // ref

        public virtual IList<Kontrolor> Kontrolor { get; set; } // HasMany

        public virtual IList<Kartica> Kartice { get; set; } // HasMany

        public Operater()
        {
            Kartice = new List<Kartica>();
        }
    }
}
