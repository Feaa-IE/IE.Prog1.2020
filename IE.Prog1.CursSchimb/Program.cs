using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prog1.CursSchimb
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] cursValutar = new decimal[DateTime.Today.Month];

            //cerem valori de la utilizator

            Console.WriteLine("Introduceti valori");
            for (int i = 0; i < cursValutar.Length; i++)
            {
                Console.WriteLine("Pentru luna: " + (i+1));
                cursValutar[i] = decimal.Parse(Console.ReadLine());
            }
                        
            decimal suma = 0;
            decimal minim = cursValutar[0];
            decimal maxim = cursValutar[0];
           // decimal pminim = 0;
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
            

            Console.WriteLine( "Media este " + (suma/cursValutar.Length));
           // Console.WriteLine("Maximul este" + maxim + " in luna: " + pmaxim);
            


            Console.ReadKey();
        }
    }
}
