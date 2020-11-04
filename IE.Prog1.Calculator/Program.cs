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

            do
            {
                //preiau valori
                Console.WriteLine("Introduceti a:");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduceti b:");
                b = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduceti operatorul:");
                op = Console.ReadLine();

                double rezultat;
                bool opValid = true;
                //logica
                switch (op)
                {
                    case "-":
                        rezultat = a - b;
                        break;
                    case "+":
                    case "suma":
                        rezultat = a + b;
                        break;
                    case "*":
                        rezultat = a * b;
                        break;
                    case "/":
                        rezultat = a / b;
                        break;
                    default:
                        // goto case "+";
                        rezultat = 0;
                        opValid = false;
                        break;
                }

                if (opValid == false)
                {
                    Console.WriteLine("Operatia nu este suportata!");
                }
                else
                {
                    Console.WriteLine($"{a}{op}{b}={rezultat}");
                    //Console.WriteLine(a + op + b + "=" + rezultat);
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            // Console.ReadKey();

        }
    }
}
