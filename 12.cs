using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_2._12
{
    internal class Program
    {
        static void Main(string[] args)
        //Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            int numarGrupuri = CalculeazaNumarGrupuri(n);
            Console.WriteLine($"Numarul de grupuri consecutive diferite de zero este: {numarGrupuri}");
            Console.ReadLine();
        }
        static int CalculeazaNumarGrupuri(int lungime)
        {
            int numarGrupuri = 0;
            bool inGrup = false;
            for (int i = 0; i < lungime; i++)
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                int numar = int.Parse(Console.ReadLine());
                if (numar != 0)
                {
                    inGrup = true;
                }
                else if (numar == 0 && inGrup)
                {
                    numarGrupuri++;
                    inGrup = false;
                }
            }
            if (inGrup)
            {
                numarGrupuri++;
            }
            return numarGrupuri;
        }
    }
}