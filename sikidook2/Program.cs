using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidomok2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Sikidom> sikidoms = new List<Sikidom>();
            sikidoms.Add(new Kor(2.5,"Kör"));
            sikidoms.Add(new Kor(5.1,"Kör"));
            sikidoms.Add(new Negyzet(2.5,"Négyztet"));
            sikidoms.Add(new Negyzet(4.1,"Négyzet"));

            foreach  (Sikidom item in sikidoms)
            {
                string tipus = "";
                if (item.GetType().Equals(typeof(Kor)))
                {
                    
                    Kor kor = (Kor)item;
                    Console.WriteLine($"{kor.AlakzatTipus}kerület: {item.Kerulet():N2}, \t terület: {item.Terulet():N2}\t körnek a sugara {kor.Sugar:N2}");


                }
                else if (item.GetType().Equals(typeof(Negyzet)))
                {
                  
                    Negyzet negyzet = (Negyzet)item;
                    Console.WriteLine($"{negyzet.AlakzatTipus}kerület: {item.Kerulet():N2}, \t terület: {item.Terulet():N2}\t oldal hossza: {negyzet.Oldal:N2}");

                }

            }

            Console.WriteLine("\n Program vége!");
            Console.ReadLine();
        }
    }
}
