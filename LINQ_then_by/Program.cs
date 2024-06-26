﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_then_by
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

            Console.WriteLine("===============================================");
            Console.WriteLine("višestruko uzlazno sortiranje");
            Console.WriteLine("===============================================");

            var visestruko=polaznici.OrderBy(p=>p.Prezime).ThenBy(p=>p.Ime).ThenBy(p=>p.Starost);

            foreach(var p in visestruko)
            {
                Console.WriteLine(p.Prezime+" "+p.Ime+ " "+p.Starost);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===============================================");
            Console.WriteLine("višestruko sortiranje, prvo uzlazno, pa drugi parametar silazno");
            Console.WriteLine("===============================================");

            var visestruko_multi = polaznici.OrderBy(p => p.Prezime).ThenByDescending(p => p.Ime);

            foreach (var p in visestruko_multi)
            {
                Console.WriteLine(p.Prezime + " " + p.Ime + " " + p.Starost);
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
