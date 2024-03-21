using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_kvantifikatori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Polaznik> polaznici = new List<Polaznik>()
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

            Console.WriteLine("=================================================");
            Console.WriteLine("All operator - Method syntax");
            Console.WriteLine("=================================================");

            bool provjeri_ako_su_svi_tinejdjeri = polaznici.All(x => x.Starost > 12 && x.Starost < 20);
            if(provjeri_ako_su_svi_tinejdjeri) Console.WriteLine("Svi su tinejđeri");
            else Console.WriteLine("Nisu svi tinejđeri");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine("Any operator - Method syntax");
            Console.WriteLine("=================================================");

            bool provjeri_ako_su_neki_tinejdjeri=polaznici.Any(x=>x.Starost>12 && x.Starost < 20);

            if (provjeri_ako_su_neki_tinejdjeri) Console.WriteLine("Ima tinejđera u kolekciji");
            else Console.WriteLine("Nema tinejđera u kolekciji.");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine("Contains operator - Method syntax");
            Console.WriteLine("=================================================");

            List<int> brojevi=new List<int>() { 1,2,3,4,5,6,7,8 };
            bool postoji_li_10 = brojevi.Contains(10);

            if (postoji_li_10) Console.WriteLine("Kolekcija sadrži 10");
            else Console.WriteLine("Kolekcija nema broj 10");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine("Contains operator - Method syntax s klasama netočni način korištenja");
            Console.WriteLine("=================================================");

            Polaznik pol = new Polaznik() { ID = 4, Ime = "Clark", Prezime = "Kent", Starost = 20 };
            bool postoji_li_pol_u_kolekciji = polaznici.Contains(pol);

            if (postoji_li_pol_u_kolekciji) Console.WriteLine("Kolekcija sadrži " + pol.Ime + " " + pol.Prezime);
            else Console.WriteLine("Nema "+pol.Ime + " " + pol.Prezime+" u kolekciji");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine("Contains operator - Method syntax s klasama točni način korištenja");
            Console.WriteLine("=================================================");

            bool opet_provjera_pol = polaznici.Contains(pol, new UsporedbaPolaznika());

            if(opet_provjera_pol) Console.WriteLine("Kolekcija sadrži " + pol.Ime + " " + pol.Prezime);
            else Console.WriteLine("Nema " + pol.Ime + " " + pol.Prezime + " u kolekciji");

        }
    }

    class Polaznik
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Starost { get; set; }
    }

    class UsporedbaPolaznika : IEqualityComparer<Polaznik>
    {
        bool IEqualityComparer<Polaznik>.Equals(Polaznik x, Polaznik y)
        {
            if(x.ID==y.ID && 
                x.Ime.ToLower()==y.Ime.ToLower() && 
                x.Prezime.ToLower()==y.Prezime.ToLower() && 
                x.Starost == y.Starost)
            {
                return true;
            }

            return false;
        }

        int IEqualityComparer<Polaznik>.GetHashCode(Polaznik obj)
        {
            return obj.GetHashCode();
        }
    }
}
