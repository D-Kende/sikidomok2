using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidomok2
{
    abstract class Sikidom
    {
         readonly string alakzatTipus;

        public string AlakzatTipus { get => alakzatTipus;}

        protected Sikidom(string alakzatTipus)
        {
            this.alakzatTipus = alakzatTipus;
        }

        public abstract double Kerulet();

         public abstract double Terulet();







    }
}
