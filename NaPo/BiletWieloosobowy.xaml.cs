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
    /// Logika interakcji dla klasy BiletWieloosobowy.xaml
    /// </summary>
    public partial class BiletWieloosobowy : Window,IFunkcje
    {
        public Osoba TenKonkretnyKlient;
        GrafMiast Mapa = new GrafMiast();
        int biletyNormalne=0, biletyDziecięce=0, biletyStudenckie=0, biletyEmeryta = 0;
        double CzyJednostronny = 1;
        public BiletWieloosobowy(Osoba TenKonkretnyKlient)
        {
            this.TenKonkretnyKlient = TenKonkretnyKlient;
            InitializeComponent();
            Odczytaj();
            if (DziałaniaNaPlikach.SprawdźCzyWszystkiePlikiIstnieją() != "Wszystkie pliki istnieją")
            {
                MessageBox.Show(DziałaniaNaPlikach.SprawdźCzyWszystkiePlikiIstnieją());
                this.Close();
            }
            Com3.Items.Add("Jednostronny");
            Com3.Items.Add("W obie strony");
        }
        private void Klik1_Click(object sender, RoutedEventArgs e)
        {
            string czybłąd = SprawdźCzyPoprawneDane();
            if (Com3.Text == "W obie strony")
                CzyJednostronny = 1.8;
            if (czybłąd == "brak błędu")
            {
                double OdległośćOdCelu = WywołajAlgorytmDijkastry(Com1.Text, Com2.Text);
                Bilet par = new Bilet(Com1.Text, Com2.Text, TenKonkretnyKlient.imię, TenKonkretnyKlient.nazwisko, TenKonkretnyKlient.telefon,
                    TenKonkretnyKlient.email, biletyNormalne, biletyDziecięce,biletyStudenckie, biletyEmeryta, OdległośćOdCelu, DatePicker1.Text, CzyJednostronny);
                if(biletyDziecięce+biletyStudenckie+biletyNormalne+biletyEmeryta>=5 && biletyDziecięce + biletyStudenckie + biletyNormalne + biletyEmeryta <20)
                    MessageBox.Show(par.DrukujParagon1(0.10));
                else if (biletyDziecięce + biletyStudenckie + biletyNormalne + biletyEmeryta >= 20)
                    MessageBox.Show(par.DrukujParagon1(0.75));
                else
                    MessageBox.Show(par.DrukujParagon1(1));
                WyczyśćWszystkiePola();
            }
            else
                MessageBox.Show(czybłąd);

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (TextBiletyNormalne.Text != "")
            {
                try
                {
                    biletyNormalne = Convert.ToInt32(TextBiletyNormalne.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("W tym miejscu mogą być tylko liczby!!!");
                    TextBiletyNormalne.Text = "0";
                }
            }
            else
                TextBiletyNormalne.Text = "0";
        }

        private void TextBiletyDziecięce_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextBiletyDziecięce.Text != "")
            {
                try
                {
                    biletyDziecięce = Convert.ToInt32(TextBiletyDziecięce.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("W tym miejscu mogą być tylko liczby!!!");
                    TextBiletyDziecięce.Text = "0";
                }
            }
            else
                TextBiletyDziecięce.Text = "0";
        }

        private void TextBiletyStudenckie_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextBiletyStudenckie.Text != "")
            {
                try
                {
                    biletyStudenckie = Convert.ToInt32(TextBiletyStudenckie.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("W tym miejscu mogą być tylko liczby!!!");
                    TextBiletyStudenckie.Text = "0";
                }
            }
            else
                TextBiletyStudenckie.Text = "0";
        }

        private void TextBiletyEmeryckie_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextBiletyEmeryckie.Text != "")
            {
                try
                {
                    biletyEmeryta = Convert.ToInt32(TextBiletyEmeryckie.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("W tym miejscu mogą być tylko liczby!!!");
                    TextBiletyEmeryckie.Text = "0";
                }
            }
            else
                TextBiletyEmeryckie.Text = "0";
        }




        private void PoleTextowe10_Copy1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Com2_SelectionChanged(object sender, SelectionChangedEventArgs e)
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

        private void Com3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
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
            TextBiletyNormalne.Text = "0";
            TextBiletyDziecięce.Text = "0";
            TextBiletyStudenckie.Text = "0";
            TextBiletyEmeryckie.Text = "0";
            Com1.Text = null;
            Com2.Text = null;
            Com3.Text = null;
            DatePicker1.Text = null;
        }
        public string SprawdźCzyPoprawneDane()
        {

            string błąd = "Podano błędne dane: ";
            if (Com1.Text == null || Com1.Text=="")
                return błąd;
            if (Com2.Text == null || Com2.Text == "")
                return błąd;
            if (Com3.Text == null || Com2.Text == "")
                return błąd;
            if (Com1.Text == Com2.Text)
                return błąd;
            if (DatePicker1==null || DatePicker1.Text == "")
                return błąd;
            if (biletyNormalne + biletyDziecięce + biletyStudenckie + biletyEmeryta == 0)
                return błąd;
            return "brak błędu";
        }
    }
}
