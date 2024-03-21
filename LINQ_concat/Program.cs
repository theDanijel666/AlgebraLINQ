using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_concat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> stringovi1 = new List<string>() { "Jedan","Dva","Tri" };
            List<string> stringovi2 = new List<string>() { "Četiri", "Pet", "Šest" };
            List<int> brojevi1 = new List<int>() { 1, 2, 3 };
            List<int> brojevi2 = new List<int>() { 4, 5, 6 };

            var str3 = stringovi1.Concat(stringovi2).ToList();
            foreach (var item in str3)
            {
                Console.WriteLine(item);
            }

            var brojevi3 = brojevi1.Concat(brojevi2).ToList();
            foreach(var item in brojevi3)
            {
                Console.WriteLine(item);
            }

            //var mjesana=stringovi1.Concat(brojevi1).ToList();
        }
    }
}
