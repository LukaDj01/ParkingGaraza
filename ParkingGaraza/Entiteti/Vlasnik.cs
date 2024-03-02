using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGaraza.Entiteti
{
    public class Vlasnik
    {
        public virtual string Jmbg { get; set; }
        public virtual string L_Ime { get; set; }
        public virtual string Prezime { get; set; }

        public virtual IList<Vozilo> Vozila { get; set; } // HasMany

        public virtual IList<Pretplatna> KarticaPretplatna { get; set; } // HasMany

        public Vlasnik()
        {
            Vozila = new List<Vozilo>();
        }
    }
}
