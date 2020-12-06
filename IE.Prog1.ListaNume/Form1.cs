using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE.Prog1.ListaNume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uxButtonAdauga_Click(object sender, EventArgs e)
        {
            AdaugaNume();

        }

        private void AdaugaNume()
        {
            string nume = uxTextBoxNume.Text;
            bool exista = false;
            for (int i = 0; i < uxListBoxNume.Items.Count; i++)
            {
                if (nume == uxListBoxNume.Items[i].ToString())
                {
                    exista = true;
                    break;
                }
            }
            if (!exista)
            {
                uxListBoxNume.Items.Add(nume);
            }
            else
            {
                MessageBox.Show("Numele se afla deja in lista!");
            }
            uxTextBoxNume.Focus();
            uxTextBoxNume.Select(0, uxTextBoxNume.Text.Length);
        }

        private void uxTextBoxNume_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AdaugaNume();
            }
        }

        private void uxButtonMuta_Click(object sender, EventArgs e)
        {
            string prefix=uxTextBoxCauta.Text;
            for(int i = 0; i < uxListBoxNume.Items.Count; i++)
            {
                string curent = uxListBoxNume.Items[i].ToString();
                if (curent.StartsWith(prefix))
                {
                    bool gasit = false;
                    for (int j = 0; j < uxListBoxMutate.Items.Count; j++)
                    {
                        if (curent == uxListBoxMutate.Items[j].ToString())
                        {
                            gasit = true;
                            break;
                        }
                    }
                    if (!gasit)
                    {
                        uxListBoxMutate.Items.Add(uxListBoxNume.Items[i].ToString());
                    }
                }
            }
        }
    }
}
