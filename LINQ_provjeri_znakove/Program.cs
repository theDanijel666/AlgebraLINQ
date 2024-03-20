using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_provjeri_znakove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prikazati znakove i učestalost znakova u zadanom tekstu:

            Console.Write("Unesite rečenicu: ");
            string recenia = Console.ReadLine();
            Console.WriteLine();

            var UcestalostZnakova=from x in recenia
                                  group x by x into y
                                  select y;
            Console.WriteLine("Učestalost znakova je:");
            foreach(var stavka in UcestalostZnakova)
            {
                Console.WriteLine("Znak "+stavka.Key+" je nađen "+stavka.Count()+" puta");
            }
        }
    }
}
