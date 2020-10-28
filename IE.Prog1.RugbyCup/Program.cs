using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prog1.RugbyCup
{
    class Program
    {
        static void Main(string[] args)
        {
            const uint primaEditie = 1987;
            uint numarEditii = 0;

            Console.WriteLine("Cupa mondiala de rugby s-a desfasurat in anii:");
            
            for (uint i = primaEditie; i <= DateTime.Today.Year; i += 4)
            {
                Console.Write(i + " ");
                numarEditii++;
            }

            //implementare cu while
            /*
            uint an = primaEditie;
            while (an <= DateTime.Today.Year)
            {
                Console.Write(an + " ");
                an += 4;
                numarEditii++;
            }
            */

            double totalSpectatori = 14759430;
            double mediaSpectatori = totalSpectatori / numarEditii;
            Console.WriteLine();
            Console.WriteLine($"Media de spectatori este: {mediaSpectatori}");

            //tine consola deschisa pana utilizatorul apasa o tasta
            Console.ReadKey();
        }
    }
}
