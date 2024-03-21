using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_single
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> jedan_broj= new List<int>() { 4 };
            List<int> brojevi = new List<int>() { 10, 21, 30, 69, 13, 50, 88 };
            List<string> stringovi = new List<string>() { "Jedan", "Dva", null, "Sedam", "Trienaest" };
            List<string> prazna = new List<string>();

            Console.WriteLine("Jedini element u listi jednog broja: "+jedan_broj.Single());
            Console.WriteLine("Jedini element u listi jednog broja: " + jedan_broj.SingleOrDefault());

            Console.WriteLine("Element u praznoj listi: " + prazna.SingleOrDefault());

            Console.WriteLine("Jedini element u listi brojeva koji je veći od 80: "+brojevi.Single(i=>i>80));

            //baca exception
            //Console.WriteLine("Jedini element u listi brojeva: " + brojevi.Single());
            //Console.WriteLine("Jedini element u listi brojeva: " + brojevi.SingleOrDefault());
        }
    }
}
