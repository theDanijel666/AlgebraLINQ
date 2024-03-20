using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_where
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


            Console.WriteLine("============================================");
            Console.WriteLine("where operator - query syntax stil");
            Console.WriteLine("============================================");

            var filtriraj=from p in polaznici
                          where p.Starost>12 && p.Starost<20
                          select p.Ime+" "+p.Prezime;
            foreach(var rez in filtriraj)
            {
                Console.WriteLine(rez);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine("where operator - func tip delegat sa anonimnom metodom");
            Console.WriteLine("============================================");

            Func<Polaznik, bool> jeTinejdjer = delegate (Polaznik p)
            {
                return p.Starost > 12 && p.Starost < 20;
            };

            var filtriraj_s_delegatom = from p in polaznici
                                        where jeTinejdjer(p)
                                        select p.Ime + " " + p.Prezime;

            foreach (var rez in filtriraj_s_delegatom)
            {
                Console.WriteLine(rez);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine("where operator - koristeći vanjsku metodu");
            Console.WriteLine("============================================");

            var filtriraj_s_metodom=from p in polaznici
                                    where ProvjeriAkoJeTinejder(p)
                                    select p.Ime+" " + p.Prezime;

            foreach (var rez in filtriraj_s_metodom)
            {
                Console.WriteLine(rez);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine("where operator - method syntax stil");
            Console.WriteLine("============================================");

            var filtriraj_skraceno=polaznici.Where(p=>p.Starost>12 &&  p.Starost < 20);

            foreach(var rez in filtriraj_skraceno) 
            { 
                Console.WriteLine(rez.Ime+" "+rez.Prezime); 
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine("where operator - method syntax stil s uvjetom");
            Console.WriteLine("============================================");

            var filtriraj_samo_parni_indeksi = polaznici.Where((p, i) =>
            {
                if (i % 2 == 0)
                {
                    return true;
                }
                return false;
            });

            foreach(var rez in filtriraj_samo_parni_indeksi)
            {
                Console.WriteLine(rez.Ime + " " + rez.Prezime);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine("where operator - višestruki where");
            Console.WriteLine("============================================");

            var filtriraj_visetruko_1=from p in polaznici
                                      where p.Starost > 12
                                      where p.Starost < 20
                                      select p.Ime+" "+p.Prezime;
            foreach(var rez in filtriraj_visetruko_1)
            {
                Console.WriteLine(rez);
            }

            var filtriraj_visestruko_2=polaznici.Where(p=>p.Starost > 12).Where(p=>p.Starost<20);
            foreach (var rez in filtriraj_visestruko_2)
            {
                Console.WriteLine(rez.Ime + " " + rez.Prezime);
            }
        }

        public static bool ProvjeriAkoJeTinejder(Polaznik p)
        {
            return p.Starost > 12 && p.Starost < 20;
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
