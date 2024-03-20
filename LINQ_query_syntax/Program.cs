using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_query_syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> brojevi = new List<int>() { 5,4,1,3,9,8,6,7,2,10 };

            //brojeve koji su manji od 3 ili veći od 7
            var moji_brojevi = from broj in brojevi
                               where broj < 3 || broj > 7
                               select broj;

            foreach(var broj in moji_brojevi)
            {
                Console.Write(broj+", ");
            }

            Console.WriteLine();
            Console.WriteLine();

            List<string> kucni_ljubimci = new List<string>()
            {
                "Ovo je moj pas Dona",
                "Imam zmiju Heru",
                "Agama se zove Rozika",
                "Još jedna zmija koja se zove Grga"
            };

            var rezultat_pretrage = from tekst in kucni_ljubimci
                                    where tekst.Contains("je")
                                    select tekst;

            foreach(var tekst in rezultat_pretrage)
            {
                Console.WriteLine(tekst);
            }
        }
    }
}
