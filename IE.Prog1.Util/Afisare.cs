using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prog1.Util
{
    public class Afisare
    {
        
        public static void AfisareLuni(int[] luni, string titlu)
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
    }
}
