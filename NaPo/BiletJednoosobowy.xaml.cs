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
    /// Logika interakcji dla klasy BiletJednoosobowy.xaml
    /// </summary>
    public partial class BiletJednoosobowy : Window,IFunkcje
    {
        GrafMiast Mapa = new GrafMiast();
        string imię, nazwisko, telefon, email;
        int biletyNormalne = 0, biletyDziecięce = 0, biletyStudenckie = 0, biletyEmeryta = 0;
        public BiletJednoosobowy()
        {
            InitializeComponent();
            Odczytaj();
            Zniżki();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Klik1_Click(object sender, RoutedEventArgs e)
        {
            Miasto tmp1 = null, tmp2 = null;
            foreach (var item in Mapa.Nodes)
            {
                if (item.wartość == Com1.Text)
                    tmp1 = item;
                if (item.wartość == Com2.Text)
                    tmp2 = item;
            }
            double OdległośćOdCelu = Mapa.AlgorytmDijkstry(tmp1, tmp2);

            if (Com3.Text == "Zwykły")
                biletyNormalne = 1;
            else if (Com3.Text == "Dziecięcy")
                biletyDziecięce = 1;
            else if (Com3.Text == "Uczniowski")
                biletyStudenckie = 1;
            else if (Com3.Text == "Emerycki")
                biletyEmeryta = 1;
            Com3.Items.Clear();
            Zniżki();
            Paragon par = new Paragon(Com1.Text, Com2.Text, imię, nazwisko, telefon, email, biletyNormalne, biletyDziecięce,
                biletyStudenckie, biletyEmeryta, OdległośćOdCelu);
            MessageBox.Show(par.DrukujParagon1());
            biletyNormalne = biletyDziecięce = biletyStudenckie = biletyEmeryta = 0;
        }

        private void Com2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Com3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            imię = TextImię.Text;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            nazwisko = TextNazwisko.Text;
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            telefon = TextTelefon.Text;
        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {
            email = TextEmail.Text;
        }
        public void Odczytaj()
        {
            foreach (var Miasto in WczytajPliki.WczytajMiasta(Mapa))
            {
                Com1.Items.Add(Miasto);
                Com2.Items.Add(Miasto);
            }
            WczytajPliki.WczytajDrogi(Mapa);
        }
        public void Zniżki()
        {
            Com3.Items.Add("Zwykły");
            Com3.Items.Add("Dziecięcy");
            Com3.Items.Add("Uczniowski");
            Com3.Items.Add("Emerycki");
        }
    }
}
