using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_razni_primjeri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listaVoca=new List<string>() { "Limun", "Jabuka", "Naranča", "Limeta",
                       "Lubenica", "Borovnica"};

            var vocaSaSlovomL = from voce in listaVoca where voce[0] == 'L' select voce;

            var vocaSaSlovomLM = listaVoca.Where(v => v[0] == 'L');

            foreach(string voce in vocaSaSlovomL)
            {
                Console.WriteLine(voce);
            }

            Console.WriteLine();
            Console.WriteLine();

            List<int> NasumicniBrojevi=new List<int>() { 
                15,8,21,24,32,13,30,12,7,54,48,4,49,96
            };

            var visekratnici_4_i_6=NasumicniBrojevi.Where(x=>x%4==0 && x%6==0).ToList();
            foreach(int broj in  visekratnici_4_i_6) { Console.WriteLine(broj); }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
