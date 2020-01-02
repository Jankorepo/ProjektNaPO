using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaPo
{
    abstract class WczytajPliki
    {
        static public List<string> WczytajMiasta(GrafMiast Mapa)
        {
            List<string> Combo = new List<string>();
            string[] miasta = System.IO.File.ReadAllLines("Miasta.txt");
            foreach (var tmp in miasta)
            {
                Combo.Add(tmp);
                Mapa.Nodes.Add(new Miasto(tmp));
            }
            return Combo;
        }
        static public void WczytajDrogi(GrafMiast Mapa)
        {
            Miasto tmp1=null, tmp2=null;
            string[] x = new string[3];
            string[] Drogi = System.IO.File.ReadAllLines("Połączenia.txt");
            foreach (string danePołączenie in Drogi)
            {
                x = danePołączenie.Split(',');

                for (int i = 0; i < Mapa.Nodes.Count; i++)
                {
                    if (Mapa.Nodes[i].wartość == x[0])
                        tmp1 = Mapa.Nodes[i];
                    if (Mapa.Nodes[i].wartość == x[1])
                        tmp2 = Mapa.Nodes[i];
                }
                Mapa.Krawędzie.Add(new OdległościMiędzyMiastowe(tmp1, tmp2, Convert.ToInt32(x[2])));
                tmp1 = tmp2 = null;
            }
        }
    }
}