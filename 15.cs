using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET2._15
{
    internal class Program
    {
        static void Main(string[] args)
        //O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. 
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            bool esteBitonica = VerificaBitonica(n);
            if (esteBitonica)
            {
                Console.WriteLine("Secventa este bitonica.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Secventa NU este bitonica.");
                Console.ReadLine();
            }
        }
        static bool VerificaBitonica(int lungime)
        {
            if (lungime <= 2)
            {
                return false;
            }
            Console.Write("Introduceti primul numar de pe pozitia 0: ");
            int primulNumar = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al doilea numar de pe pozitia 1: ");
            int alDoileaNumar = int.Parse(Console.ReadLine());
            if (primulNumar >= alDoileaNumar)
            {
                return false;
            }
            bool aFostCrescatoare = true;
            for (int i = 2; i < lungime; i++)
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                int numar = int.Parse(Console.ReadLine());
                if (aFostCrescatoare)
                {
                    if (numar < alDoileaNumar)
                    {
                        aFostCrescatoare = false;
                    }
                }
                else
                {
                    if (numar >= alDoileaNumar)
                    {
                        return false;
                    }
                }
                alDoileaNumar = numar;
            }
            return true;
        }
    }
}
