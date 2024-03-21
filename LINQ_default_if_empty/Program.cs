using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_default_if_empty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> stringovi= new List<string>();

            var novaLista1 = stringovi.DefaultIfEmpty();
            var novaLista2 = stringovi.DefaultIfEmpty("Prazno");

            Console.WriteLine("Broj elemenata: " + novaLista1.Count());
            Console.WriteLine("Vrijednost: " + novaLista1.First());
            Console.WriteLine();
            Console.WriteLine("Broj elemenata: " + novaLista2.Count());
            Console.WriteLine("Vrijednost: " + novaLista2.First());

            Console.WriteLine();
            Console.WriteLine();

            List<int> intovi= new List<int>();

            var novaLista3 = intovi.DefaultIfEmpty();
            var novaLista4 = intovi.DefaultIfEmpty(505);

            Console.WriteLine("Broj elemenata: " + novaLista3.Count());
            Console.WriteLine("Vrijednost: " + novaLista3.First());
            Console.WriteLine();
            Console.WriteLine("Broj elemenata: " + novaLista4.Count());
            Console.WriteLine("Vrijednost: " + novaLista4.First());

            Console.WriteLine();
            Console.WriteLine();

            List<Polaznik> polaznici= new List<Polaznik>();

            var novaLista5 = polaznici.DefaultIfEmpty();
            var novaLista6 = polaznici.DefaultIfEmpty(new Polaznik() { ID=1,Ime="Josip"});

            Console.WriteLine("Broj elemenata: " + novaLista5.Count());
            Console.WriteLine("Vrijednost: " + novaLista5.First());
            Console.WriteLine();
            Console.WriteLine("Broj elemenata: " + novaLista6.Count());
            Console.WriteLine("Vrijednost: " + novaLista6.First().Ime);
        }
    }

    class Polaznik
    {
        public int ID { get; set; }
        public string Ime { get; set; }
    }
}
