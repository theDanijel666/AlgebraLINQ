using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_group_join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Polaznik> polaznici = new List<Polaznik>()
            {
                new Polaznik(){ID=1,Ime="Nikola",Prezime="Telsa",TecajID=1},
                new Polaznik(){ID=2,Ime="Mirko",Prezime="Filipović",TecajID=1},
                new Polaznik(){ID=3,Ime="Jon",Prezime="Jones",TecajID=2},
                new Polaznik(){ID=4,Ime="Clark",Prezime="Kent",TecajID=1},
                new Polaznik(){ID=5,Ime="Fjodor",Prezime="Emelianenko",TecajID=3},
                new Polaznik(){ID=6,Ime="Wnderlei",Prezime="Silva",TecajID=1},
                new Polaznik(){ID=7,Ime="Željko",Prezime="Mavrović",TecajID=2},
                new Polaznik(){ID=8,Ime="Mike",Prezime="Tyson"}
            };

            List<Tecaj> tecajevi = new List<Tecaj>()
            {
                new Tecaj(){ID=1,Naziv="C#"},
                new Tecaj(){ID=2,Naziv="SQL"},
                new Tecaj(){ID=3,Naziv="ASP.NET"}
            };

            Console.WriteLine("====================================================");
            Console.WriteLine("GroupJoin - method syntax");
            Console.WriteLine("====================================================");

            var ms_group_join = tecajevi.GroupJoin(polaznici,
                tecaj=>tecaj.ID,
                polaznik=>polaznik.TecajID,
                (tecaj,grupaPolaznika)=>new
                {
                    polaznici=grupaPolaznika,
                    NazivTecaja=tecaj.Naziv
                }
                );

            foreach(var stavka in ms_group_join)
            {
                Console.WriteLine(stavka.NazivTecaja+" tecaju pristupaju: ");
                foreach(var polaznik in stavka.polaznici)
                {
                    Console.WriteLine(polaznik.Prezime+" "+polaznik.Ime);
                }
                Console.WriteLine("-------------");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("====================================================");
            Console.WriteLine("GroupJoin - query syntax");
            Console.WriteLine("====================================================");

            var qs_group_join = from tecaj in tecajevi
                                join polaznik in polaznici
                                on tecaj.ID equals polaznik.TecajID
                                into groupaPolaznika
                                select new
                                {
                                    polaznici=groupaPolaznika,
                                    NazivTecaja=tecaj.Naziv
                                };

            foreach (var stavka in qs_group_join)
            {
                Console.WriteLine(stavka.NazivTecaja + " tecaju pristupaju: ");
                foreach (var polaznik in stavka.polaznici)
                {
                    Console.WriteLine(polaznik.Prezime + " " + polaznik.Ime);
                }
                Console.WriteLine("-------------");
            }
        }
    }

    class Polaznik
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int TecajID { get; set; }
    }

    class Tecaj
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
    }
}
