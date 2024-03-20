using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_sintaksa
{
    class Polaznik 
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Starost { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Polaznik[] listaPolaznika =
            {
                new Polaznik(){ ID = 1,Ime="Nikola",Prezime="Tesla",Starost=73},
                new Polaznik(){ ID = 2,Ime="Antun",Prezime="Gustav Matoš",Starost=63},
                new Polaznik(){ ID = 3,Ime="Josip",Prezime="Jelačić",Starost=56},
                new Polaznik(){ ID = 4,Ime="Ernest",Prezime="Hemingway",Starost=84},
                new Polaznik(){ ID = 5,Ime="Matija",Prezime="Reljković",Starost=71},
                new Polaznik(){ ID = 6,Ime="Josip",Prezime="Kozarac",Starost=27},
                new Polaznik(){ ID = 7,Ime="Dragutin",Prezime="Tadijanović",Starost=54},
                new Polaznik(){ ID = 8,Ime="Stjepan",Prezime="Radič",Starost=42}
            };

            Console.WriteLine("==========================================");
            Console.WriteLine("Klasični način traženja polaznika starosti od 35 do 60 godina:");
            Console.WriteLine("==========================================");

            Polaznik[] polaznici = new Polaznik[10];

            int i = 0;
            foreach(Polaznik polaznik in listaPolaznika)
            {
                if(polaznik.Starost>=35 && polaznik.Starost <= 60)
                {
                    polaznici[i++]= polaznik;
                }
            }

            for(int x=0;x<=polaznici.Length;x++)
            {
                if (polaznici.ElementAtOrDefault(x) != null)
                {
                    Console.WriteLine($"{polaznici[x].ID}: {polaznici[x].Ime} {polaznici[x].Prezime} {polaznici[x].Starost}");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("LINQ upit traženja polaznika starosti od 35 do 60 godina:");
            Console.WriteLine("==========================================");

            polaznici = (from polaznik in listaPolaznika
                         where polaznik.Starost >= 35 && polaznik.Starost <= 60
                         select polaznik).ToArray();

            for (int x = 0; x <= polaznici.Length; x++)
            {
                if (polaznici.ElementAtOrDefault(x) != null)
                {
                    Console.WriteLine($"{polaznici[x].ID}: {polaznici[x].Ime} {polaznici[x].Prezime} {polaznici[x].Starost}");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("LINQ upit (Method syntax) traženja polaznika starosti od 35 do 60 godina:");
            Console.WriteLine("==========================================");

            polaznici=listaPolaznika.Where(p=>p.Starost>=35 && p.Starost<=60).ToArray();

            for (int x = 0; x <= polaznici.Length; x++)
            {
                if (polaznici.ElementAtOrDefault(x) != null)
                {
                    Console.WriteLine($"{polaznici[x].ID}: {polaznici[x].Ime} {polaznici[x].Prezime} {polaznici[x].Starost}");
                }
            }
        }
    }
}
