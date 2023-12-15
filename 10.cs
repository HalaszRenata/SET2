using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_2._10
{
    internal class Program
    {
        static void Main(string[] args)
        //Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            int maxNumereConsecutiveEgale = NumereConsecutiveEgale(n);
            Console.WriteLine($"Numarul maxim de numere consecutive egale este: {maxNumereConsecutiveEgale}");
            Console.ReadLine();
        }
        static int NumereConsecutiveEgale(int lungime)
        {
            if (lungime <= 1)
            {
                return lungime;
            }
            Console.Write($"Introduceti primul numar de pe pozitia 0: ");
            int numarAnterior = int.Parse(Console.ReadLine());
            int maxConsecutiveEgale = 1;
            int consecutiveEgaleCurent = 1;
            for (int i = 1; i < lungime; i++)
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                int numar = int.Parse(Console.ReadLine());
                if (numar == numarAnterior)
                {
                    consecutiveEgaleCurent++;
                }
                else
                {
                    consecutiveEgaleCurent = 1;
                }
                if (consecutiveEgaleCurent > maxConsecutiveEgale)
                {
                    maxConsecutiveEgale = consecutiveEgaleCurent;
                }
                numarAnterior = numar;
            }
            return maxConsecutiveEgale;
        }
    }
}