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
    public partial class BiletJednoosobowy : Window, IFunkcje
    {
        public Osoba TenKonkretnyKlient;
        GrafMiast Mapa = new GrafMiast();
        int biletyNormalne = 0, biletyDziecięce = 0, biletyStudenckie = 0, biletyEmeryta = 0;
        public BiletJednoosobowy(Osoba TenKonkretnyKlient)
        {
            this.TenKonkretnyKlient = TenKonkretnyKlient;
            InitializeComponent();
            Odczytaj();
            Com3.Items.Add("Zwykły");
            Com3.Items.Add("Dziecięcy");
            Com3.Items.Add("Uczniowski");
            Com3.Items.Add("Emerycki");
            OdświeżComboBox3(Com3.Text);
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
            OdświeżComboBox3(Com3.Text);
            string czybłąd = SprawdźCzyPoprawneDane();

            if (czybłąd == "brak błędu")
            {
                double OdległośćOdCelu = WywołajAlgorytmDijkastry(Com1.Text, Com2.Text);
                Paragon par = new Paragon(Com1.Text, Com2.Text, TenKonkretnyKlient.imię, TenKonkretnyKlient.nazwisko, TenKonkretnyKlient.telefon,
                    TenKonkretnyKlient.email, biletyNormalne, biletyDziecięce,biletyStudenckie, biletyEmeryta, OdległośćOdCelu, DatePicker1.Text);
                MessageBox.Show(par.DrukujParagon1());
                WyczyśćWszystkiePola();
            }
            else
                MessageBox.Show(czybłąd);
        }

        private void Com2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Com3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void Odczytaj()
        {
            foreach (var Miasto in DziałaniaNaPlikach.WczytajMiasta(Mapa))
            {
                Com1.Items.Add(Miasto);
                Com2.Items.Add(Miasto);
            }
            DziałaniaNaPlikach.WczytajDrogi(Mapa);
        }
        public void OdświeżComboBox3(string text)
        {
            if (text == "Zwykły")
                biletyNormalne = 1;
            else if (text == "Dziecięcy")
                biletyDziecięce = 1;
            else if (text == "Uczniowski")
                biletyStudenckie = 1;
            else if (text == "Emerycki")
                biletyEmeryta = 1;
        }
        public double WywołajAlgorytmDijkastry(string text1, string text2)
        {
            Miasto tmp1 = null, tmp2 = null;
            foreach (var item in Mapa.Nodes)
            {
                if (item.wartość == text1)
                    tmp1 = item;
                if (item.wartość == text2)
                    tmp2 = item;
            }
            return Mapa.AlgorytmDijkstry(tmp1, tmp2);
        }
        public void WyczyśćWszystkiePola()
        {
            biletyNormalne = biletyDziecięce = biletyStudenckie = biletyEmeryta = 0;
            Com1.Text = null;
            Com2.Text = null;
            Com3.Text = null;
            DatePicker1.Text = null;
        }
        public string SprawdźCzyPoprawneDane()
        {
            string błąd = "Podano błędne dane: ";
            if (Com1.Text == null || Com1.Text == "")
                return błąd;
            if (Com2.Text == null || Com2.Text == "")
                return błąd;
            if (Com1.Text == Com2.Text)
                return błąd;
            if (Com3.Text == null || Com3.Text == "")
                return błąd;
            if (DatePicker1 == null || DatePicker1.Text == "")
                return błąd;
            if (biletyNormalne + biletyDziecięce + biletyStudenckie + biletyEmeryta == 0)
                return błąd;
            return "brak błędu";
        }
    }
}
