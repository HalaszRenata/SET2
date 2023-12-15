using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_2._5
{
    internal class Program
    {
        static void Main(string[] args)
        //Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. 
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            int numereEgaleCuPozitia = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                int numar = int.Parse(Console.ReadLine());

                if (numar == i)
                {
                    numereEgaleCuPozitia++;
                }
            }
            Console.WriteLine($"Numerele egale cu pozitia in secventa: {numereEgaleCuPozitia}");
            Console.ReadLine();
        }
    }
}
