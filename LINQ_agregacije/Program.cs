using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_agregacije
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

            List<int> brojevi= new List<int>() { 1,2,3,4,5,6,7,8,9,10 };
            List<string> stringovi = new List<string>() { "Jedan", "Dva", "Tri", "Četiri", "Pet", "Šest" };

            Console.WriteLine("=====================================================");
            Console.WriteLine("Aggregate operator - Method syntax");
            Console.WriteLine("=====================================================");

            string stringovi_odvojeni_zarezom = stringovi.Aggregate((s1, s2) => s1 + ", " + s2);

            Console.WriteLine(stringovi_odvojeni_zarezom);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=====================================================");
            Console.WriteLine("Aggregate operator s Seed value - Method syntax ");
            Console.WriteLine("=====================================================");

            string polaznici_odvojeni_zarezom = polaznici.Aggregate<Polaznik, string>(
                "Imena i prezimena polaznika: ",
                (str,p)=>str+=p.Ime+" "+p.Prezime+", "
                );

            Console.WriteLine(polaznici_odvojeni_zarezom);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=====================================================");
            Console.WriteLine("Aggregate operator s Seed value i metodom preopterećenja - Method syntax ");
            Console.WriteLine("=====================================================");

            string polaznici_odvojeni_zarezom_bez_zadnjeg = polaznici.Aggregate<Polaznik, string, string>(
                "Imena i prezimena polaznika: ",
                (str, p) => str += p.Ime + " " + p.Prezime + ", ",
                str => str.Substring(0, str.Length - 2)
                );

            Console.WriteLine(polaznici_odvojeni_zarezom_bez_zadnjeg);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=====================================================");
            Console.WriteLine("Average operator - Method sytax");
            Console.WriteLine("=====================================================");

            var prosjek_brojeva = brojevi.Average();

            Console.WriteLine("Prosjek brojeva je "+prosjek_brojeva);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=====================================================");
            Console.WriteLine("Average operator s složenim tipovima - Method sytax");
            Console.WriteLine("=====================================================");

            var prosjek_godina = polaznici.Average(x => x.Starost);

            Console.WriteLine("Prosječna dob polaznika je "+prosjek_godina);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=====================================================");
            Console.WriteLine("Count operator s jednostavnim tipovima - Method sytax");
            Console.WriteLine("=====================================================");

            var prebroji_sve = brojevi.Count();
            Console.WriteLine("Kolekcija ima {0} brojeva",prebroji_sve);

            var parni_brojevi = brojevi.Count(b => b % 2 == 0);
            Console.WriteLine("Kolekcija ima {0} parnih brojeva",parni_brojevi);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=====================================================");
            Console.WriteLine("Count operator s složenim tipovima - Method sytax");
            Console.WriteLine("=====================================================");

            var prebroji_polaznike = polaznici.Count();
            Console.WriteLine("Ukupno ima {0} polaznika",prebroji_polaznike);

            var punoljetni_polaznika = polaznici.Count(p => p.Starost >= 18);
            Console.WriteLine("Ima {0} punoljetnih polaznika",punoljetni_polaznika);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=====================================================");
            Console.WriteLine("Min i Max operatori s jednostavnim tipovima - Method sytax");
            Console.WriteLine("=====================================================");

            var najmanji_broj = brojevi.Min();
            var najveci_broj = brojevi.Max();

            Console.WriteLine("Najveći je {0}, a najmanji je {1}",najveci_broj,najmanji_broj);

            var najveci_neparni_broj = brojevi.Max(i =>
            {
                if (i % 2 == 1) return i;
                return int.MinValue;
            });

            Console.WriteLine("Najveći neparni broj je " + najveci_neparni_broj);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=====================================================");
            Console.WriteLine("Min i Max operatori s složeni tipovima - Method sytax");
            Console.WriteLine("=====================================================");

            var najstariji_polaznik = polaznici.Max(x => x.Starost);
            var najmljadji_polaznik = polaznici.Min(x => x.Starost);

            Console.WriteLine("Najstariji polaznik ima {0}, dok najmljađi ima {1} godina",najstariji_polaznik,najmljadji_polaznik);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=====================================================");
            Console.WriteLine("Min i Max operatori s složeni tipovima i usporedba - Method sytax");
            Console.WriteLine("=====================================================");

            var max_pol = polaznici.Max();

            Console.WriteLine($"ID: {max_pol.ID} Ime i prezime: {max_pol.Ime} {max_pol.Prezime}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=====================================================");
            Console.WriteLine("Sum operator s jednostavnim tipovima - Method sytax");
            Console.WriteLine("=====================================================");

            var ukupno = brojevi.Sum();
            Console.WriteLine("Suma brojeva je " + ukupno);

            var suma_parnih_brojeva = brojevi.Sum(i =>
            {
                if (i % 2 == 0) return i;
                return 0;
            });

            Console.WriteLine("Suma parnih brojeva u kolekciji je "+suma_parnih_brojeva);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=====================================================");
            Console.WriteLine("Sum operator s složenim tipovima - Method sytax");
            Console.WriteLine("=====================================================");

            var zbroj_godina = polaznici.Sum(p => p.Starost);

            Console.WriteLine("Zbroj godina polaznika je " + zbroj_godina);
        }
    }

    class Polaznik : IComparable<Polaznik>
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Starost { get; set; }

        public int CompareTo(Polaznik p)
        {
            return (this.Prezime + " " + this.Ime).CompareTo(p.Prezime + " " + p.Ime);
        }
    }
}
