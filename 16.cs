using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET2._16
{
    internal class Program
    {
        //O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. 
        static bool IsBitonicRotatedSequence(int n)
        {
            if (n < 3)
            {
                return false;
            }
            Console.Write("Introduceti primul element al secventei: ");
            int firstElement = int.Parse(Console.ReadLine());
            int prev = firstElement;
            bool increasing = true;
            bool decreasing = false;
            for (int i = 1; i < n; i++)
            {
                Console.Write("Introduceti urmatorul element: ");
                int current = int.Parse(Console.ReadLine());
                if (current == prev)
                {
                    return false;
                }
                if (current > prev)
                {
                    if (decreasing)
                    {
                        return false;
                    }
                    increasing = true;
                }
                else
                {
                    decreasing = true;
                }
                if (decreasing && current > firstElement)
                {
                    return true;
                }
                prev = current;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());
            if (IsBitonicRotatedSequence(n))
            {
                Console.WriteLine("Secventa este bitonica rotita.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Secventa nu este bitonica rotita.");
                Console.ReadLine();
            }
        }
    }
}

