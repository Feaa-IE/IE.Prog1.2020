using IE.Prog1.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prog1.CursSchimbV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeCursuri = new[] { "EUR", "USD" };
            //declaram o matrice cu 2 linii (EUR, USD) si un numar de coloane egal cu numarul lunii curente
            decimal[,] cursValutar = new decimal[2, DateTime.Today.Month];
            //populam matricea
            for (int i = 0; i < cursValutar.GetLength(0); i++)
            {
                for (int j = 0; j < cursValutar.GetLength(1); j++)
                {
                    //afisam mesaj utilizatorului
                    Console.WriteLine("Introduceti cursul valutar " + numeCursuri[i] + " pentru luna " + (j + 1));
                    //Console.WriteLine("Introduceti cursul valutar " + (i == 0 ? "EUR" : "USD") + " pentru luna " + (j + 1));

                    //preluam cursul pentru fiecare valuta (linie) si fiecare luna (coloana
                    cursValutar[i, j] = decimal.Parse(Console.ReadLine());
                }
            }

            //aflam lunile pentru care cursurile sunt diferite si lunile pentru care sunt egale

            //declaram un vector pentru a stoca lunile care au cursuri diferite
            int[] cursuriDiferite = new int[0];
            //declaram un vector pentru a stoca lunile care au cursuri  egale
            int[] cursuriEgale = new int[0];

            for (int i = 0; i < cursValutar.GetLength(1); i++)
            {
                //testam (in)egalitatea cursurilor
                if (cursValutar[0, i] != cursValutar[1, i])
                {
                    Array.Resize(ref cursuriDiferite, cursuriDiferite.Length + 1);
                    cursuriDiferite[cursuriDiferite.Length - 1] = i + 1;
                }
                else
                {
                    Array.Resize(ref cursuriEgale, cursuriEgale.Length + 1);
                    cursuriEgale[cursuriEgale.Length - 1] = i + 1;
                }
            }

            //afisam lunile utilizand o functie utilitara definita in proiectul IE.Prog1.Util
            Afisare.AfisareLuni(cursuriDiferite, "cu cursuri diferite");
            Afisare.AfisareLuni(cursuriEgale, "cu cursuri egale");


            Console.ReadKey();

        }
    }
}
