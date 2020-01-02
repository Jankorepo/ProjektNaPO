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
        GrafMiast Mapa = new GrafMiast();
        string imię, nazwisko, telefon, email;
        int biletyNormalne=0, biletyDziecięce=0, biletyStudenckie=0, biletyEmeryta = 0;
        public BiletWieloosobowy()
        {
            InitializeComponent();
            Odczytaj();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextBiletyNormalne.Text != "")
                biletyNormalne = Convert.ToInt32(TextBiletyNormalne.Text);
            else
                TextBiletyNormalne.Text = "0";
        }

        private void TextBiletyDziecięce_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextBiletyDziecięce.Text != "")
                biletyDziecięce = Convert.ToInt32(TextBiletyDziecięce.Text);
            else
                TextBiletyDziecięce.Text = "0";
        }

        private void TextBiletyStudenckie_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextBiletyStudenckie.Text != "")
                biletyStudenckie = Convert.ToInt32(TextBiletyStudenckie.Text);
            else
                TextBiletyStudenckie.Text = "0";
        }

        private void TextBiletyEmeryckie_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextBiletyEmeryckie.Text != "")
                biletyEmeryta = Convert.ToInt32(TextBiletyEmeryckie.Text);
            else
                TextBiletyEmeryckie.Text = "0";
        }

        private void TextImię_TextChanged(object sender, TextChangedEventArgs e)
        {
            imię = TextImię.Text;
        }

        private void TextNazwisko_TextChanged(object sender, TextChangedEventArgs e)
        {
            nazwisko = TextNazwisko.Text;
        }

        private void TextTelefon_TextChanged(object sender, TextChangedEventArgs e)
        {
            telefon = TextTelefon.Text;
        }

        

        private void TextEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            email = TextEmail.Text;
        }

        private void PoleTextowe10_Copy1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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


            Paragon par = new Paragon(Com1.Text,Com2.Text, imię,nazwisko,telefon,email,biletyNormalne,biletyDziecięce,
                biletyStudenckie,biletyEmeryta, OdległośćOdCelu);
            MessageBox.Show(par.DrukujParagon1());
            biletyNormalne = biletyDziecięce = biletyStudenckie = biletyEmeryta = 0;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Com2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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
    }
}
