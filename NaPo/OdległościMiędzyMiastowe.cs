using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaPo
{
    class OdległościMiędzyMiastowe
    {
        public Miasto start;
        public Miasto koniec;
        public int waga = 1;
        public OdległościMiędzyMiastowe(Miasto start, Miasto koniec, int waga = 1)
        {
            this.start = start;
            this.koniec = koniec;
            this.waga = waga;
        }
        public override string ToString()
        {
            return $"{this.start}-{this.koniec} ({this.waga})";
        }
        public Miasto WeźDrugi(Miasto n)
        {
            return n == this.start ? this.koniec : this.start;
        }
    }
}
