using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prog1.MasinaV2
{
    struct Masina
    {
        public string Marca;
        public DateTime DataFab;
        public string Culoare;
        public float Pret;
        public bool AreEuro6;

        public override string ToString()
        {
            return Marca + " de culoare " + Culoare + " fabricata la data " + this.DataFab + " cu euro 6 = " + AreEuro6 + " costa " + Pret;
        }
    }
}
