using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidomok2
{
    internal class Negyzet : Sikidom
    {
        double oldal;

        public double Oldal { get => oldal; set => oldal = value; }

        public Negyzet(double oldal):base("Négyzet")
        {
            this.oldal = oldal;
        }

        public override double Kerulet()
        {
            return oldal * 4;
        }

        public override double Terulet()
        {
            return oldal* oldal;
        }
    }
}
