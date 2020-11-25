using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prog1.MasinaV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Masina masina = new Masina();          
            

            Console.WriteLine("Marca:");
            masina.Marca = Console.ReadLine();
            Console.WriteLine("Culoarea:");
            masina.Culoare = Console.ReadLine();
            Console.WriteLine("Pret:");
            masina.Pret = float.Parse(Console.ReadLine());
            
            masina.AreEuro6 = true;
            //DateTime dataFab = new DateTime(1998, 12, 5);
            Console.WriteLine("Data fab:");
            masina.DataFab = DateTime.Parse(Console.ReadLine());            

            const float coefDepreciere = 0.07f;
            for (int i = 0; i < 7; i++)
            {
                if (i >= 1)
                {
                    masina.Pret = masina.Pret - masina.Pret * coefDepreciere;
                }
                if (i == 3)
                {
                    Console.WriteLine("Revopsire in culoarea:");
                    masina.Culoare = Console.ReadLine();
                }
                if (i == 5)
                {
                    masina.AreEuro6 = false;
                }
                if (i == 0 || i == 2 || i == 4 || i == 6)
                {
                    if (i > 0)
                    {
                        Console.WriteLine("Anul " + i);
                    }



                    //string mesaj = "Masina " + masina.Marca + " de culoare " + masina.Culoare + " fabricata la data " + masina.DataFab + " cu euro = " + masina.AreEuro6 + " costa " + masina.Pret;
                    string mesaj = "Masina: " + masina;
                    Console.WriteLine(mesaj);
                }
            }


            Console.ReadLine();

        }
    }
}
