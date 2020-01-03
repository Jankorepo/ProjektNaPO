using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NaPo
{
    abstract class WczytajPliki
    {
        static public List<string> WczytajMiasta(GrafMiast Mapa)
        {
            List<string> Combo = new List<string>();
            string[] miasta = File.ReadAllLines("Miasta.txt");
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
            string[] Drogi = File.ReadAllLines("Połączenia.txt");
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
        public static string NumerParagonu()
        {
            string[] ParagonWartość = File.ReadAllLines("NrParagonu.txt");
            using (StreamWriter writer = new StreamWriter("NrParagonu.txt", false))
            {
                int tmpParagon = Convert.ToInt32(ParagonWartość[0]) + 1;
                writer.WriteLine(tmpParagon);
                writer.Close();
            }
            return ParagonWartość[0];
        }
        public static bool WypiszDoPliku(string wynik, string numerParagonu)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                using (StreamWriter writer = new StreamWriter(path + "/Paragon_" + numerParagonu + ".txt", false))
                {
                    writer.Write(wynik);
                    writer.Close();
                }
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        
    }
}