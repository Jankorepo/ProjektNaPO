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
    public partial class BiletWieloosobowy : Window
    {
        string imię, nazwisko, telefon, email;
        int biletyNormalne=0, biletyDziecięce=0, biletyStudenckie=0, biletyEmeryta = 0;
        public BiletWieloosobowy()
        {
            InitializeComponent();
            Com1.Items.Add("Olsztyn");
            Com1.Items.Add("Kętrzyn");
            Com2.Items.Add("Olsztyn");
            Com2.Items.Add("Kętrzyn");
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
                biletyNormalne = Convert.ToInt32(TextBiletyDziecięce.Text);
            else
                TextBiletyDziecięce.Text = "0";
        }

        private void TextBiletyStudenckie_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextBiletyStudenckie.Text != "")
                biletyNormalne = Convert.ToInt32(TextBiletyStudenckie.Text);
            else
                TextBiletyStudenckie.Text = "0";
        }

        private void TextBiletyEmeryckie_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextBiletyEmeryckie.Text != "")
                biletyNormalne = Convert.ToInt32(TextBiletyEmeryckie.Text);
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
            Paragon par = new Paragon(Com1.Text,Com2.Text, imię,nazwisko,telefon,email,biletyNormalne,biletyDziecięce,
                biletyStudenckie,biletyEmeryta);
            MessageBox.Show(par.DrukujParagon1());
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Com2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
