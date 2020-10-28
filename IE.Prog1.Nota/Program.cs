using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prog1.Nota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nota 1:");
            float nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nota 2:");
            float nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nota test practic:");
            float notaTestPractic = float.Parse(Console.ReadLine());
            const float pondereNote = 0.3f;
            const float pondereNotaTestPractic = 0.4f;
            const float prag = 5f;

            float notaFinala = (nota1 + nota2) * pondereNote + notaTestPractic * pondereNotaTestPractic;

            if (notaTestPractic >= prag && notaFinala >= prag)
            {
                Console.WriteLine("Absolvit! Nota " + notaFinala + " cu " + (notaFinala - prag) + " mai mult decat pragul " + prag);
            }
            else
            {
                Console.WriteLine("Restantier!");
            }

            Console.ReadLine();
        }
    }
}
