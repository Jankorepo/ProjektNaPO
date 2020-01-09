using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NaPo
{
    /// <summary>
    /// Logika interakcji dla klasy StronaAdmina.xaml
    /// </summary>
    public partial class StronaAdmina : Window
    {
        GrafMiast Mapa = new GrafMiast();

        public StronaAdmina()
        {
            InitializeComponent();
            if (DziałaniaNaPlikach.SprawdźCzyWszystkiePlikiIstnieją() != "Wszystkie pliki istnieją")
            {
                MessageBox.Show(DziałaniaNaPlikach.SprawdźCzyWszystkiePlikiIstnieją());
                this.Close();
            }
               

            foreach (var miasto in DziałaniaNaPlikach.WczytajMiasta(Mapa))
            {
                ComDodajPoł1.Items.Add(miasto);
                ComDodajPoł2.Items.Add(miasto);
                ComUsuńPoł1.Items.Add(miasto);
                ComUsuńPoł2.Items.Add(miasto);
                ComUsuńMiastoIPołączenia.Items.Add(miasto);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DziałaniaNaPlikach.DodajMiasto(TextNoweMiasto.Text);
            ComDodajPoł1.Items.Clear();
            ComDodajPoł2.Items.Clear();
            ComUsuńPoł1.Items.Clear();
            ComUsuńPoł2.Items.Clear();
            ComUsuńMiastoIPołączenia.Items.Clear();
            foreach (var miasto in DziałaniaNaPlikach.WczytajMiasta(Mapa))
            {
                ComDodajPoł1.Items.Add(miasto);
                ComDodajPoł2.Items.Add(miasto);
                ComUsuńPoł1.Items.Add(miasto);
                ComUsuńPoł2.Items.Add(miasto);
                ComUsuńMiastoIPołączenia.Items.Add(miasto);
            }
        }

        private void Klik1_Click(object sender, RoutedEventArgs e)
        {
            DziałaniaNaPlikach.DodajDrogę(ComDodajPoł1.Text, ComDodajPoł2.Text, TextOdległość.Text);
            MessageBox.Show("Pomyślnie dodano nowe połączenie między miastem " + ComDodajPoł1.Text +
                " oraz " + ComDodajPoł2.Text + " z odległością " + TextOdległość.Text + "km.");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(Mapa.Krawędzie==null || Mapa.Krawędzie.Count==0)
            DziałaniaNaPlikach.WczytajDrogi(Mapa);
            OdległościMiędzyMiastowe drogiDoUsunięcia;
            do
            {
                drogiDoUsunięcia = Mapa.Krawędzie.Find(k => (k.start.wartość == ComUsuńPoł1.Text && k.koniec.wartość == ComUsuńPoł2.Text) ||
            (k.start.wartość == ComUsuńPoł2.Text && k.koniec.wartość == ComUsuńPoł1.Text));
                Mapa.Krawędzie.Remove(drogiDoUsunięcia);
            } while (drogiDoUsunięcia != null);
            DziałaniaNaPlikach.UsuńDrogę(Mapa.Krawędzie);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (Mapa.Krawędzie == null || Mapa.Krawędzie.Count == 0)
                DziałaniaNaPlikach.WczytajDrogi(Mapa);
            OdległościMiędzyMiastowe drogiDoUsunięcia;
            do
            {
                drogiDoUsunięcia = Mapa.Krawędzie.Find(k =>k.start.wartość == ComUsuńMiastoIPołączenia.Text ||
                k.koniec.wartość == ComUsuńMiastoIPołączenia.Text);
                Mapa.Krawędzie.Remove(drogiDoUsunięcia);
            } while (drogiDoUsunięcia != null);
            DziałaniaNaPlikach.UsuńDrogę(Mapa.Krawędzie);
            var MiastoDoUsunięcia = Mapa.Nodes.Find(k => k.wartość == ComUsuńMiastoIPołączenia.Text);
            Mapa.Nodes.Remove(MiastoDoUsunięcia);
            DziałaniaNaPlikach.UsuńMiasto(Mapa);


            ComDodajPoł1.Items.Remove(ComUsuńMiastoIPołączenia.Text);
            ComDodajPoł2.Items.Remove(ComUsuńMiastoIPołączenia.Text);
            ComUsuńPoł1.Items.Remove(ComUsuńMiastoIPołączenia.Text);
            ComUsuńPoł2.Items.Remove(ComUsuńMiastoIPołączenia.Text);
            ComUsuńMiastoIPołączenia.Items.Remove(ComUsuńMiastoIPołączenia.Text);
        }

        private void TextNoweMiasto_TextChanged(object sender, TextChangedEventArgs e)
        {
            SprawdzCzyToSąLitery();
            
        }

        private void TextOdległość_TextChanged(object sender, TextChangedEventArgs e)
        {
            SprawdzCzyToSąLiczby();
        }
        public void SprawdzCzyToSąLiczby()
        {
            if (TextOdległość.Text != "" && TextOdległość.Text!="Odległość miedzy tymi miastami")
            {
                try
                {
                    for (int i = 0; i < TextOdległość.Text.Length; i++)
                    {
                        Convert.ToInt32(TextOdległość.Text);
                        Convert.ToString(TextOdległość.Text);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("W tym miejscu mogą być tylko liczby!!!");
                    TextOdległość.Text = "";
                }
            }
        }
        public void SprawdzCzyToSąLitery()
        {
            if (TextNoweMiasto.Text != "" || TextNoweMiasto.Text != "Nazwa miasta")
            {
                try
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (TextNoweMiasto.Text.Contains(Convert.ToString(i)))
                            Convert.ToInt32("a");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("W tym miejscu mogą być tylko litery!!!");
                    TextNoweMiasto.Text = "";
                }
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            List<Osoba> PełnaListaOsob = DziałaniaNaPlikach.WczytajUżytkowników();
            Osoba KlientDoUsunięcia = PełnaListaOsob.Find(k => k.nazwaUżytkownika == TextUsuńNazwęUżytkownika.Text &&
            k.hasło == TextUsuńHasłoUżytkownika.Text);
            if (KlientDoUsunięcia != null)
            {
                PełnaListaOsob.Remove(KlientDoUsunięcia);
                DziałaniaNaPlikach.UsuńUżytkownika(PełnaListaOsob);
                MessageBox.Show("Poprawnie usunięto klienta " + KlientDoUsunięcia.imię + " " + KlientDoUsunięcia.nazwisko +
                    " z nazwą użytkownika " + KlientDoUsunięcia.nazwaUżytkownika);
            }
            else
                MessageBox.Show("Nie ma takiego klienta!");
        }
    }
}
