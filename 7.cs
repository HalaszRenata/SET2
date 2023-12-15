using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_2._7
{
    internal class Program
    {
        static void Main(string[] args)
        //Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            DeterminaMinMax(n, out int min, out int max);
            Console.WriteLine($"Cea mai mica valoare din secventa: {min}");
            Console.WriteLine($"Cea mai mare valoare din secventa: {max}");
            Console.ReadLine();
        }
        static void DeterminaMinMax(int lungime, out int min, out int max)
        {
            Console.Write("Introduceti primul numar: ");
            int primulNumar = int.Parse(Console.ReadLine());
            min = primulNumar;
            max = primulNumar;
            for (int i = 1; i < lungime; i++)
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                int numar = int.Parse(Console.ReadLine());
                if (numar < min)
                {
                    min = numar;
                }
                if (numar > max)
                {
                    max = numar;
                }
            }
        }
    }
}
