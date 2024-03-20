using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_pronadji_vece_brojeve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            
            List<int> lista=new List<int>();

            Console.Write("Koliko brojeva želite unijeti: ");
            x=int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 0; i < x; i++)
            {
                Console.Write("Broj {0} : ", i + 1);
                lista.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Unesite broj od kojeg želite ispisati veće brojeve iz liste: ");
            y= int.Parse(Console.ReadLine());

            var filtrirana_lista=lista.FindAll(broj => broj>y );
            //var filtriraj=from broj in lista
            //              where broj>y
            //              select broj;

            Console.WriteLine("Brojevi veći od {0} su : ",y);
            foreach(var broj in filtrirana_lista)
            {
                Console.WriteLine(broj);
            }


        }
    }
}
