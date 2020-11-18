using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IE.Prog1.Util;

namespace IE.Prog1.CursSchimb
{
    class Program
    {     
              
        static void Main(string[] args)
        {
            decimal[] cursValutar = new decimal[DateTime.Today.Month];


            //cerem valori de la utilizator
            Console.WriteLine("Introduceti curs EUR");
            for (int i = 0; i < cursValutar.Length; i++)
            {
                Console.WriteLine("Pentru luna: " + (i + 1));
                cursValutar[i] = decimal.Parse(Console.ReadLine());
            }

            decimal suma = 0;
            decimal minim = cursValutar[0];
            decimal maxim = cursValutar[0];
            //decimal pminim = 0;
            //decimal pmaxim = 0;
            for (int i = 0; i < cursValutar.Length; i++)
            {
                suma = suma + cursValutar[i];
                if (cursValutar[i] < minim)
                {
                    minim = cursValutar[i];
                    //pminim = i;
                }
                if (cursValutar[i] > maxim)
                {
                    maxim = cursValutar[i];
                    //pmaxim = i;
                }
            }
            decimal media = suma / cursValutar.Length;

            int[] luniMax = new int[0];
            int[] luniMin = new int[0];
            int[] luniPesteMedie = new int[0];

            int j = 0;
            while (j < cursValutar.Length)
            {
                if (cursValutar[j] == minim)
                {
                    Array.Resize(ref luniMin, luniMin.Length + 1);
                    luniMin[luniMin.Length - 1] = j;
                }
                if (cursValutar[j] == maxim)
                {
                    Array.Resize(ref luniMax, luniMax.Length + 1);
                    luniMax[luniMax.Length - 1] = j;
                }
                if (cursValutar[j] > media)
                {
                    Array.Resize(ref luniPesteMedie, luniPesteMedie.Length + 1);
                    luniPesteMedie[luniPesteMedie.Length - 1] = j;
                }
                j++;
            }

            Console.WriteLine("Media este " + media);


            //apelam functia de afisare
            Afisare.AfisareLuni(luniMin, "de minim");
            Afisare.AfisareLuni(luniMax, "de maxim");
            Afisare.AfisareLuni(luniPesteMedie, "peste medie");


            Console.ReadKey();
        }


    }
}
