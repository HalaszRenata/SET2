using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_2._9
{
    internal class Program
    {
        static void Main(string[] args)
        //Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            VerificaMonotonia(n);
        }
            static void VerificaMonotonia(int lungime)
            {
                if (lungime <= 1)
                {
                    Console.WriteLine("Secventa este monotona.");
                    return;
                }
                Console.Write($"Introduceti numarul de pe pozitia 0: ");
                int numarAnterior = int.Parse(Console.ReadLine());
                bool crescatoare = true;
                bool descrescatoare = true;
                for (int i = 1; i < lungime; i++)
                {
                    Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                    int numar = int.Parse(Console.ReadLine());
                    if (numar < numarAnterior)
                    {
                        crescatoare = false;
                    }
                    if (numar > numarAnterior)
                    {
                        descrescatoare = false;
                    }
                    numarAnterior = numar;
                }
                if (crescatoare || descrescatoare)
                {
                    Console.WriteLine("Secventa este monotona.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Secventa NU este monotona.");
                    Console.ReadLine();
                }
            }
    }
}
