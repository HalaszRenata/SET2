using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_2._13
{
    internal class Program
    {
        static void Main(string[] args)
        //O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            bool esteCrescatoareRotita = VerificaCrescatoareRotita(n);
            if (esteCrescatoareRotita)
            {
                Console.WriteLine("Secventa este o secventa crescatoare rotita.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Secventa NU este o secventa crescatoare rotita.");
                Console.ReadLine();
            }
        }
        static bool VerificaCrescatoareRotita(int lungime)
        {
            if (lungime <= 1)
            {
                return true;
            }
            Console.Write("Introduceti primul numar de pe pozitia 0: ");
            int primulNumar = int.Parse(Console.ReadLine());
            int numarAnterior = primulNumar;
            bool aFostRotire = false;
            for (int i = 1; i < lungime; i++)
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                int numar = int.Parse(Console.ReadLine());
                if (numar < numarAnterior)
                {
                    if (aFostRotire)
                    {
                        return false;
                    }
                    else
                    {
                        aFostRotire = true;
                    }
                }
                numarAnterior = numar;
            }
            return true;
        }
    }
}