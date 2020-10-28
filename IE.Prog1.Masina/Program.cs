using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prog1.Masina
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Marca:");
            string marca = Console.ReadLine();
            Console.WriteLine("Culoarea:");
            string culoare = Console.ReadLine();
            Console.WriteLine("Pret:");
            float pret = float.Parse(Console.ReadLine());
            bool esteEuro6;
            esteEuro6 = true;
            //DateTime dataFab = new DateTime(1998, 12, 5);
            Console.WriteLine("Data fab:");
            DateTime dataFab = DateTime.Parse(Console.ReadLine());

            const float coefDepreciere = 0.07f;
            //Masina [marca/model] de culoare [culoarea] fabricata la data [datafabricatie] cu euro6 = [euro6] costa [pret]
            for (int i = 0; i < 7; i++)
            {
                if (i >= 1)
                {
                    pret = pret - pret * coefDepreciere;
                }
                if (i == 3)
                {
                    Console.WriteLine("Revopsire in culoarea:");
                    culoare = Console.ReadLine();
                }
                if (i == 5)
                {
                    esteEuro6 = false;
                }
                if (i == 0 || i == 2 || i == 4 || i == 6)
                {
                    if (i > 0)
                    {
                        Console.WriteLine("Anul " + i);
                    }
                    string mesaj = "Masina " + marca + " de culoare " + culoare + " fabricata la data " + dataFab + " cu euro = " + esteEuro6 + " costa " + pret;
                    Console.WriteLine(mesaj);
                }
            }


            Console.ReadLine();



        }
    }
}
