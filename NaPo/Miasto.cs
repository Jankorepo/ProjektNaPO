using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaPo
{
    class Miasto
    {
        public string wartość;
        public Miasto(string wartość)
        {
            this.wartość = wartość;
        }
        public override string ToString()
        {
            return this.wartość;
        }
    }
}
