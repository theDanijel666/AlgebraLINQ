using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_element_at
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> brojevi=new List<int>() { 10, 21, 30, 69, 13, 50, 88 };
            List<string> stringovi = new List<string>() { "Jedan", "Dva", null, "Sedam", "Trienaest" };

            Console.WriteLine("Prvi element liste brojeva je "+brojevi.ElementAt(0));
            Console.WriteLine("Prvi element liste stringova je " + stringovi.ElementAt(0));

            Console.WriteLine("Drugi element liste brojeva je " + brojevi.ElementAt(1));
            Console.WriteLine("Drugi element liste stringova je " + stringovi.ElementAt(1));

            Console.WriteLine("Treći element liste brojeva je " + brojevi.ElementAtOrDefault(2));
            Console.WriteLine("Treći element liste stringova je " + stringovi.ElementAtOrDefault(2));

            Console.WriteLine("Deseti element liste brojeva je " + brojevi.ElementAtOrDefault(9));
            Console.WriteLine("Deseti element liste stringova je " + stringovi.ElementAtOrDefault(9));

        }
    }
}
