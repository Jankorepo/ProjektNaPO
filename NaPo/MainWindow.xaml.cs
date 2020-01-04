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
using System.Windows.Shapes;

namespace NaPo
{
    public partial class MainWindow : Window
    {
        
        string NowaNazwa, NoweHaslo, NoweImię, NoweNazwisko, NowyTelefon, NowyEmail, NowyPESEL;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Jesteśmy firmą bez celu i doświadczenia, a nawet posiadamy flotę busów z lat 60");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("      Nr. telefonu\n999-888-777\n\n      Siedziba firmy:\n" +
                "Ul.Kościuszki 15/12, 19-123 Warszawa" +
                "\n\nGodziny otwarcia:\nPoniedziałek-Piątek\n    7.00-21.00\nSobota\n" +
                "    8.00-15.00\n        " );
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            
        }
        private void TextLogNazwaUżytkownika_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextLogHasło_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextRejNazwaUżytkownika_TextChanged(object sender, TextChangedEventArgs e)
        {
            NowaNazwa = TextRejNazwaUżytkownika.Text;
        }


        private void TextRejHasło_TextChanged(object sender, TextChangedEventArgs e)
        {
            NoweHaslo = TextRejHasło.Text;
        }

        private void TextRejImię_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextRejImię.Text != "")
            {
                try
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (TextRejImię.Text.Contains(Convert.ToString(i)))
                            Convert.ToInt32("a");
                    }
                    NoweImię = TextRejImię.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("W tym miejscu mogą być tylko litery!!!");
                    TextRejImię.Text = "";
                }
            }
        }

        private void TextRejNazwisko_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextRejNazwisko.Text != "")
            {
                try
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (TextRejNazwisko.Text.Contains(Convert.ToString(i)))
                            Convert.ToInt32("a");
                    }
                    NoweNazwisko = TextRejNazwisko.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("W tym miejscu mogą być tylko litery!!!");
                    TextRejNazwisko.Text = "";
                }
            }
        }

        private void TextRejTelefon_TextChanged(object sender, TextChangedEventArgs e)
        {
            NowyTelefon = TextRejTelefon.Text;
        }
        private void TextRejEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            NowyEmail = TextRejEmail.Text;
        }
        private void TextRejPESEL_TextChanged(object sender, TextChangedEventArgs e)
        {
            NowyPESEL = TextRejPESEL.Text;
        }
    }
}
