using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_of_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList mjesovitaLista=new ArrayList();
            mjesovitaLista.Add(0);
            mjesovitaLista.Add("jedan");
            mjesovitaLista.Add("dva");
            mjesovitaLista.Add(3);
            mjesovitaLista.Add(new Polaznik() { ID = 1, Ime = "Đuro" });

            Console.WriteLine("=================================================");
            Console.WriteLine("Pronađi samo stringove");
            Console.WriteLine("=================================================");

            var stringovi = from s in mjesovitaLista.OfType<string>() select s;

            foreach(string rez in stringovi) {  Console.WriteLine(rez); }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine("Pronađi samo intove");
            Console.WriteLine("=================================================");

            var intovi=from s in mjesovitaLista.OfType<int>() select s;

            foreach(int rez in intovi) { Console.WriteLine(rez); }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine("Pronađi samo stringove method syntax");
            Console.WriteLine("=================================================");

            var stringovi_m = mjesovitaLista.OfType<string>();

            foreach(string rez in stringovi_m) { Console.WriteLine(rez); }
        }
    }

    class Polaznik
    {
        public int ID { get; set; }
        public string Ime { get; set; }
    }
}
