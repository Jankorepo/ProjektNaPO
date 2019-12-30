using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaPo
{
    abstract class WczytajPliki
    {
        static public List<string> WczytajMiasta()
        {
            List<string> Combo = new List<string>();
            string[] miasta = System.IO.File.ReadAllLines("Miasta.txt");
            foreach (var tmp in miasta)
            {
                Combo.Add(tmp);
            }
            return Combo;
        }
        static public List<string> WczytajDrogi()
        {
            List<string> DrogaWTypieString = new List<string>();
            string[] Drogi = System.IO.File.ReadAllLines("Połączenia.txt");
            foreach (var tmp in Drogi)
            {
                DrogaWTypieString.Add(tmp);
            }
            return DrogaWTypieString;
        }
    }
}