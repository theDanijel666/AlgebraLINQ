using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> brojevi = new List<int>() { 10, 21, 30, 69, 13, 50, 88 };
            List<string> stringovi = new List<string>() { "Jedan", "Dva", null, "Sedam", "Trienaest" };
            List<string> prazna = new List<string>();

            Console.WriteLine("Prvi element u listi brojeva: " + brojevi.First());
            Console.WriteLine("Prvi element u listi brojeva: " + brojevi.FirstOrDefault());

            Console.WriteLine("Prvi parni element u listi brojeva: " + brojevi.First(i => i % 2 == 0));
            Console.WriteLine("Prvi parni element u listi brojeva: " + brojevi.FirstOrDefault(i => i % 2 == 0));

            Console.WriteLine("Prvi element u listi stringova: " + stringovi.First());
            Console.WriteLine("Prvi element u listi stringova: " + stringovi.FirstOrDefault());

            Console.WriteLine("Prvi element u praznoj listi: " + prazna.FirstOrDefault());
            Console.WriteLine("Prvi element u praznoj listi: " + prazna.First());
        }
    }
}
