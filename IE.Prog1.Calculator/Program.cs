using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prog1.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //declar variabile
            double a;
            double b;
            string op;

            //preiau valori
            Console.WriteLine("Introduceti a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti b:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti operatorul:");
            op = Console.ReadLine();

            double rezultat;
            //logica
            switch (op)
            {
                case "+":
                    rezultat = a + b;
                    break;

                default:
                    break;
            }

            Console.WriteLine($"{a}{op}{b}={rezultat}");
            Console.WriteLine(a + op + b + "=" + rezultat);


        }
    }
}
