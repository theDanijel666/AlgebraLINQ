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
