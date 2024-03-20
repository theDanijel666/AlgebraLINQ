using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("Jednostavni LINQ upit: ");
            Console.WriteLine("=================================================");

            string[] prezimena = { "Tesla","Mažuranić", "Jelačić","Ujević" };

            var upit = from prezime in prezimena
                       where prezime.Contains("ić")
                       select prezime;

            foreach(var p in upit)
            {
                Console.Write(p+" ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine("Primjer LINQ upita koji traži slovo 't' u imenu: ");
            Console.WriteLine("=================================================");

            string[] imena = { "Ana", "Iva", "Kata", "Marija", "Ivana", "Anita", "Magdalena", "Mirta" };

            var nadjiimena = from ime in imena
                             where ime.Contains('t')
                             select ime;

            foreach(var ime in nadjiimena)
            {
                Console.Write(ime+", ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine("Primjer LINQ upita koji vraća samo pozitivne brojeve: ");
            Console.WriteLine("=================================================");

            int[] brojevi = { 3, 5, -12, 1, -4, -43, 13, 17, 22, 39, 18, -3, -7, -666 };

            var pozitivnibrojevi = from broj in brojevi
                                   where broj > 0
                                   select broj;

            foreach(var broj in pozitivnibrojevi)
            {
                Console.Write(broj + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine("Primjer LINQ upita koji vraća brojeve između -5 i 5 ");
            Console.WriteLine("=================================================");

            var trazeniBrojevi=from broj in brojevi
                               where broj>=-5 && broj<=5
                               select broj;

            foreach (var broj in trazeniBrojevi)
            {
                Console.Write(broj + ", ");
            }

            var trazeniBrojevi2 = (from broj in brojevi
                                 where broj >= -5 && broj <= 5
                                 select broj).ToList();

        }
    }
}
