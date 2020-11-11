using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prog1.CursSchimb
{
    class Program
    {
     
        //functia este statica pentru ca o apelam dintr-o alta functie static(Main)
        private static void AfisareLuni(int[] luni, string titlu)
        {
            Console.WriteLine("Lunile " + titlu + " sunt: ");
            for (int i = 0; i < luni.Length; i++)
            {
                //separatorul intre luni; daca este ultima luna separatorul este gol
                string separator = i == luni.Length - 1 ? string.Empty : ",";
                //luni[i] ne va da luna 
                Console.Write(NumeLuna(luni[i] + 1) + separator);
            }
            Console.WriteLine();
        }

        private static string NumeLuna(int numarluna)
        {
            //verifica validitatea parametrului numarLuni
            if (numarluna > 12 || numarluna < 1)
            {
                return "";
            }
            //vector cu numele lunilor
            string[] numeLuni = new string[] { "Ian", "Feb", "Mar", "Apr", "Mai", "Iun", "Iul", "Aug", "Sep", "Oct", "Noi", "Dec" };
            //returnam numele lunii din vector in functie de numarul lunii (incepe de la 1)
            return numeLuni[numarluna - 1];

            //implementare cu switch
            //switch (numarluna)
            //{
            //    case 1:
            //        return "ian";
            //    case 2:
            //        return "feb";
            //    default:
            //        return "";
            //}

        }
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
            AfisareLuni(luniMin, "de minim");
            AfisareLuni(luniMax, "de maxim");
            AfisareLuni(luniPesteMedie, "peste medie");


            Console.ReadKey();
        }


    }
}
