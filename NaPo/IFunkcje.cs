using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaPo
{
    interface IFunkcje
    {
        void Odczytaj();
        void WyczyśćWszystkiePola();
        double WywołajAlgorytmDijkastry(string text1, string text2);
    }
}
