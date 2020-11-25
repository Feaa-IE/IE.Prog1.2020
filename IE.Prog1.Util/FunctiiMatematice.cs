using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prog1.Util
{
    public class FunctiiMatematice
    {
        public static double[] EqGrad2(double a, double b, double c, out bool infinitateDeSolutii)
        {
            double[] solutii = new double[0];
            infinitateDeSolutii = false;
            if (a == 0 && b == 0 && c == 0)
            {
                infinitateDeSolutii = true;
                return solutii;
            }
            if (a == 0 && b == 0)
            {
                return solutii;
            }
            if (a == 0)
            {
                //ecuatie de grad 1
                solutii = new double[1];
                solutii[0] = -c / b;
                return solutii;
            }

            //ecuatie grad 2
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta > 0)
            {
                solutii = new double[2];
                solutii[0] = (-b + Math.Sqrt(delta)) / 2 * a;
                solutii[1] = (-b - Math.Sqrt(delta)) / 2 * a;
                return solutii;
            }
            if (delta == 0)
            {
                solutii = new double[2];
                solutii[0] = solutii[1] = -b / 2 * a;
                return solutii;
            }

            return solutii;

        }
    }
}
