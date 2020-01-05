using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NaPo
{
    abstract class DziałaniaNaPlikach
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
        public static List<Osoba> WczytajUżytkowników()
        {
            List < Osoba > Użytkownicy= new List<Osoba>();
            string[] x = new string[8];
            string[] Drogi = File.ReadAllLines("ListaUżytkowników.txt");
            foreach (string danePołączenie in Drogi)
            {
                x = danePołączenie.Split(',');
                Użytkownicy.Add(new Osoba(x[0],x[1],x[2],x[3],x[4],x[5],x[6],x[7]));
            }
            return Użytkownicy;
        }
        public static void DodajUżytkownika(Osoba nowyK)
        {
            string[] WszyscyUżytkownicy = File.ReadAllLines("ListaUżytkowników.txt");
            using (StreamWriter writer = new StreamWriter("ListaUżytkowników.txt", false))
            {
                foreach(var użytkownik in WszyscyUżytkownicy)
                    writer.WriteLine(użytkownik);
                writer.WriteLine(nowyK.imię+","+nowyK.nazwisko + "," + nowyK.telefon + "," + nowyK.email
                    + "," + nowyK.nazwaUżytkownika + "," + nowyK.hasło + "," + nowyK.PESEL + "," + nowyK.CzyAdmin);
                writer.Close();
            }
        }
        static public List<string> WczytajMiasta()
        {
            List<string> Combo = new List<string>();
            string[] miasta = File.ReadAllLines("Miasta.txt");
            foreach (var tmp in miasta)
            {
                Combo.Add(tmp);
            }
            return Combo;
        }
        static public void DodajMiasto(string miasto)
        {
            string[] miasta = File.ReadAllLines("Miasta.txt");
            using (StreamWriter writer = new StreamWriter("Miasta.txt", false))
            {
                foreach (var miasteczko in miasta)
                    writer.WriteLine(miasteczko);
                writer.WriteLine(miasto);
                writer.Close();
            }
        }
        static public void DodajDrogę(string miasto1, string miasto2, string odległość)
        {
            string[] drogi = File.ReadAllLines("Połączenia.txt");
            using (StreamWriter writer = new StreamWriter("Połączenia.txt", false))
            {
                foreach (var droga in drogi)
                    writer.WriteLine(droga);
                writer.WriteLine(miasto1 + "," + miasto2 + "," + odległość);
                writer.Close();
            }
        }
    }
}