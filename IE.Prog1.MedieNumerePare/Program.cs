using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prog1.MedieNumerePare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti n:");
            uint n = uint.Parse(Console.ReadLine());

            uint suma = 0;
            uint numere = 0;
            for (uint i = 2; i < n; i += 2)
            {
                suma += i;
                numere++;
            }

            double media = suma / numere;

            //calcul medie fara numarare
            double media2 = suma / ((n - 1) / 2);

            //utilizare Debug
            Debug.Assert(media == media2);
            Debug.Write("media2=" + media2);

            Console.WriteLine("Media numerelor pare pozitive mai mici decat n este " + media);

            Console.ReadKey();
        }
    }
}
