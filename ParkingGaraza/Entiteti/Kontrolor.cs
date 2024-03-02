using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGaraza.Entiteti
{
    public class Kontrolor // ?
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime DatumPocetka { get; set; }
        public virtual DateTime? DatumKraja { get; set; }

        public virtual Operater JmbgOperatera { get; set; } // ref

        public virtual IList<Operater> Operateri { get; set; } // HasMany

        public Kontrolor()
        {
            Operateri = new List<Operater>();
        }
    }
}
