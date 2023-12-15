using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_2._6
{
    internal class Program
    {
        static void Main(string[] args)
        //Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            bool esteCrescatoare = VerificaCrescatoare(n);
            if (esteCrescatoare)
            {
             Console.WriteLine("Secventa este in ordine crescatoare.");
                Console.ReadLine();
            }
            else
            {
             Console.WriteLine("Secventa NU este in ordine crescatoare.");
                Console.ReadLine();
            }
        }
        static bool VerificaCrescatoare(int lungime)
        {
            if (lungime <= 1)
            {
                return true;
            }
            int ultimulNumar = int.MinValue;
            for (int i = 0; i < lungime; i++)
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                int numar = int.Parse(Console.ReadLine());
                if (numar < ultimulNumar)
                {
                    return false;
                }
                ultimulNumar = numar;
            }
            return true;
        }
    }
}
