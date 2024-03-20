using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_group
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Polaznik[] polaznici =
            {
                new Polaznik(){ID=1,Ime="Nikola",Prezime="Telsa",Starost=18},
                new Polaznik(){ID=2,Ime="Mirko",Prezime="Filipović",Starost=21},
                new Polaznik(){ID=3,Ime="Jon",Prezime="Jones",Starost=21},
                new Polaznik(){ID=4,Ime="Clark",Prezime="Kent",Starost=18},
                new Polaznik(){ID=5,Ime="Fjodor",Prezime="Emelianenko",Starost=18},
                new Polaznik(){ID=6,Ime="Wnderlei",Prezime="Silva",Starost=18},
                new Polaznik(){ID=7,Ime="Željko",Prezime="Mavrović",Starost=18},
                new Polaznik(){ID=8,Ime="Mike",Prezime="Tyson",Starost=21}
            };

            Console.WriteLine("==================================================");
            Console.WriteLine("grupiranje po starosti");
            Console.WriteLine("==================================================");

            var grupitaj_po_starosti = from p in polaznici
                                       group p by p.Starost;

            foreach(var grupa in grupitaj_po_starosti)
            {
                Console.WriteLine("Grupa starosti " + grupa.Key);
                foreach(var p in grupa)
                {
                    Console.WriteLine(p.Ime+" "+p.Prezime);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine("grupiranje po starosti method syntax");
            Console.WriteLine("==================================================");

            var grupiraj_po_starosti_method = polaznici.GroupBy(p => p.Starost);
            //var grupiraj_po_starosti_method=polaznici.ToLookup(p => p.Starost);

            foreach (var grupa in grupiraj_po_starosti_method)
            {
                Console.WriteLine("Grupa starosti " + grupa.Key);
                foreach (var p in grupa)
                {
                    Console.WriteLine(p.Ime + " " + p.Prezime);
                }
                Console.WriteLine();
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
