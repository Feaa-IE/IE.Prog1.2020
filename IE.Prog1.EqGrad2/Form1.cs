using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IE.Prog1.Util;

namespace IE.Prog1.EqGrad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uxButtonRezultat_Click(object sender, EventArgs e)
        {
            double a = double.Parse(uxTextBoxA.Text);
            double b = double.Parse(uxTextBoxB.Text);
            double c = double.Parse(uxTextBoxC.Text);

            //bool areOInfinitateDeSolutii;
            double[] solutii = FunctiiMatematice.EqGrad2(a, b, c, out bool areOInfinitateDeSolutii);

            if (areOInfinitateDeSolutii)
            {
                MessageBox.Show("Ecuatia are o infinitate de solutii!");
            }
            else
            {
                if (solutii.Length == 0)
                {
                    MessageBox.Show("Ecuatia nu are solutii reale!");
                }
                else if (solutii.Length == 1)
                {
                    MessageBox.Show("Ecuatie de grad 1. Solutia: " + solutii[0]);
                }
                else if (solutii.Length == 2)
                {
                    MessageBox.Show("Ecuatie de grad 2. x1= " + solutii[0] + " x2=" + solutii[1]);
                }
            }
        }


    }
}
