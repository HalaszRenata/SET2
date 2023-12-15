using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        //Se da o secventa de n numere. Sa se determine cate din ele sunt pare.
        {
            Console.Write("Introduceti lungimea secventei: ");
            int lungime = int.Parse(Console.ReadLine());
            int numerePare = 0;
            for (int i = 0; i < lungime; i++)
            {
                Console.Write($"Introduceti numarul {i + 1}: ");
                int numar = int.Parse(Console.ReadLine());
                if (EstePar(numar))
                {
                    numerePare++;
                }
            }
            Console.WriteLine($"Dintre cele {lungime} numere, {numerePare} sunt pare.");
            Console.ReadLine();
        }
        static bool EstePar(int numar)
        {
            return numar % 2 == 0;
        }
    }
}
