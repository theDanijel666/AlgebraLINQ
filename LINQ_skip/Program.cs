using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_skip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> rijeci = new List<string>() { "Jedan","Dva","Tri","Četiri","Pet","Šest","Sedam","Osam" };

            var novaLista = rijeci.Skip(2);

            foreach (var item in novaLista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();
            
            int page = 2, per_page = 2;
            var elementi= rijeci.Skip((page-1)*per_page).Take(per_page);
            foreach (var item in elementi) { Console.WriteLine(item); }
        }
    }
}
