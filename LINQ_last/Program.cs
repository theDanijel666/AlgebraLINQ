using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_last
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> brojevi = new List<int>() { 10, 21, 30, 69, 13, 50, 88 };
            List<string> stringovi = new List<string>() { "Jedan", "Dva", null, "Sedam", "Trienaest" };
            List<string> prazna = new List<string>();

            Console.WriteLine("Zadnji element u listi brojeva: " + brojevi.Last());
            Console.WriteLine("Zadnji element u listi brojeva: " + brojevi.LastOrDefault());

            Console.WriteLine("Zadnji parni element u listi brojeva: " + brojevi.Last(i => i % 2 == 0));
            Console.WriteLine("Zadnji parni element u listi brojeva: " + brojevi.LastOrDefault(i => i % 2 == 0));

            Console.WriteLine("Zadnji element u listi stringova: " + stringovi.Last());
            Console.WriteLine("Zadnji element u listi stringova: " + stringovi.LastOrDefault());

            Console.WriteLine("Zadnji element u praznoj listi: " + prazna.LastOrDefault());
            Console.WriteLine("Zadnji element u praznoj listi: " + prazna.Last());
        }
    }
}
