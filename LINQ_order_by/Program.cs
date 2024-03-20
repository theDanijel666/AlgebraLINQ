using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_order_by
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Polaznik[] polaznici =
            {
                new Polaznik(){ID=1,Ime="Nikola",Prezime="Telsa",Starost=18},
                new Polaznik(){ID=2,Ime="Mirko",Prezime="Filipović",Starost=21},
                new Polaznik(){ID=3,Ime="Jon",Prezime="Jones",Starost=25},
                new Polaznik(){ID=4,Ime="Clark",Prezime="Kent",Starost=20},
                new Polaznik(){ID=5,Ime="Fjodor",Prezime="Emelianenko",Starost=31},
                new Polaznik(){ID=6,Ime="Wnderlei",Prezime="Silva",Starost=17},
                new Polaznik(){ID=7,Ime="Željko",Prezime="Mavrović",Starost=19},
                new Polaznik(){ID=8,Ime="Mike",Prezime="Tyson",Starost=57}
            };

            Console.WriteLine("================================================");
            Console.WriteLine("Uzlazno sortiranje");
            Console.WriteLine("================================================");

            var sortiraj_uzlazno = from p in polaznici
                                   orderby p.Prezime
                                   select p;
            foreach(var rez in sortiraj_uzlazno)
            {
                Console.WriteLine(rez.Prezime+" "+rez.Ime);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("================================================");
            Console.WriteLine("Uzlazno sortiranje method syntax");
            Console.WriteLine("================================================");

            var sortiraj_uzlazno_method = polaznici.OrderBy(p => p.Prezime);

            foreach (var rez in sortiraj_uzlazno_method)
            {
                Console.WriteLine(rez.Prezime + " " + rez.Ime);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("================================================");
            Console.WriteLine("Silazno sortiranje");
            Console.WriteLine("================================================");

            var sortiraj_silazno=from p in polaznici
                                 orderby p.Prezime descending
                                 select p;

            foreach (var rez in sortiraj_silazno)
            {
                Console.WriteLine(rez.Prezime + " " + rez.Ime);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("================================================");
            Console.WriteLine("Silazno sortiranje method syntax");
            Console.WriteLine("================================================");

            var sortiraj_silazno_method = polaznici.OrderByDescending(p => p.Prezime);

            foreach (var rez in sortiraj_silazno_method)
            {
                Console.WriteLine(rez.Prezime + " " + rez.Ime);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("================================================");
            Console.WriteLine("Višestruko sortiranje");
            Console.WriteLine("================================================");

            var visestruko=from p in polaznici
                           orderby p.Prezime,p.Ime descending
                           select p;

            foreach (var rez in visestruko)
            {
                Console.WriteLine(rez.Prezime + " " + rez.Ime);
            }
        }
    }

    class Polaznik
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Starost { get; set; }
    }
}
