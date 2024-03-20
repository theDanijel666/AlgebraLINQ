using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<string> stringLista1 = new List<string>()
            {
                "Jedan",
                "Dva",
                "Tri",
                "Četiri"
            };
            IList<string> stringLista2 = new List<string>()
            {
                "Jedan",
                "Dva",
                "Pet",
                "Šest"
            };

            Console.WriteLine("======================================================");
            Console.WriteLine("join operacija - samo podudarne vrijednosti");
            Console.WriteLine("======================================================");

            var podudarne_vrijednosti=stringLista1.Join(stringLista2,
                                        str1=>str1,str2=>str2,(str1,str2)=>str1);

            foreach(var rez in podudarne_vrijednosti)
            {
                Console.WriteLine(rez);
            }

            Console.WriteLine();
            Console.WriteLine();

            List<Polaznik> polaznici = new List<Polaznik>()
            {
                new Polaznik(){ID=1,Ime="Nikola",Prezime="Telsa",TecajID=1},
                new Polaznik(){ID=2,Ime="Mirko",Prezime="Filipović",TecajID=1},
                new Polaznik(){ID=3,Ime="Jon",Prezime="Jones",TecajID=2},
                new Polaznik(){ID=4,Ime="Clark",Prezime="Kent",TecajID=1},
                new Polaznik(){ID=5,Ime="Fjodor",Prezime="Emelianenko",TecajID=3},
                new Polaznik(){ID=6,Ime="Wnderlei",Prezime="Silva",TecajID=1},
                new Polaznik(){ID=7,Ime="Željko",Prezime="Mavrović",TecajID=2},
                new Polaznik(){ID=8,Ime="Mike",Prezime="Tyson",TecajID=2}
            };

            List<Tecaj> tecajevi = new List<Tecaj>() 
            {
                new Tecaj(){ID=1,Naziv="C#"},
                new Tecaj(){ID=2,Naziv="SQL"},
                new Tecaj(){ID=3,Naziv="ASP.NET"}
            };

            Console.WriteLine("======================================================");
            Console.WriteLine("join operacija - join s različitim klasama - method syntax");
            Console.WriteLine("======================================================");

            var ms_ineer_join = polaznici.Join(
                    tecajevi,
                    polaznik=>polaznik.TecajID,
                    tecaj=>tecaj.ID,
                    (polaznik,tecaj)=> new
                    {
                        ImePrezimePolaznik=polaznik.Ime+" "+polaznik.Prezime,
                        NazivTecaja=tecaj.Naziv
                    }
                );

            foreach(var rez in ms_ineer_join)
            {
                Console.WriteLine(rez.ImePrezimePolaznik + " pohađa tečaj " + rez.NazivTecaja);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("======================================================");
            Console.WriteLine("join operacija - join s različitim klasama - query syntax");
            Console.WriteLine("======================================================");

            var qs_inner_join = from p in polaznici
                                join t in tecajevi
                                on p.TecajID equals t.ID
                                select new
                                {
                                    ImePrezimePolaznik = p.Ime + " " + p.Prezime,
                                    NazivTecaja = t.Naziv
                                };

            foreach (var rez in qs_inner_join)
            {
                Console.WriteLine(rez.ImePrezimePolaznik + " pohađa tečaj " + rez.NazivTecaja);
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
