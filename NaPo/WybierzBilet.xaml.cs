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
    /// <summary>
    /// Logika interakcji dla klasy WybierzBilet.xaml
    /// </summary>
    public partial class WybierzBilet : Window
    {
        public Osoba TenKonkretnyKlient;
        public WybierzBilet(Osoba TenKonkretnyKlient)
        {
            this.TenKonkretnyKlient = TenKonkretnyKlient;
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (T1.Text == "password")
            {
                Hide();
                new StronaAdmina().ShowDialog();
                ShowDialog();
            }
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hide();
            new BiletJednoosobowy(TenKonkretnyKlient).ShowDialog();
            ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Hide();
            new BiletWieloosobowy(TenKonkretnyKlient).ShowDialog();
            ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cena biletu(do 100km):" +
                "\n Normalny: 1,60zł/km" +
                "\n Dziecięcy(do lat 3): 0.40zł/km(-75%)" +
                "\n Szkolny/studencki: 0,80zł/km(-50%)" +
                "\n Emerytalny/osoby niepełosprawnej: 1,20zł/km(-25%)" +

                "\n\n Cena biletu(powyżej 100km):" +
                "\n Normalny: 1,00zł/km" +
                "\n Dziecięcy(do lat 3): 0,25zł/km(-75%)" +
                "\n Szkolny/studencki: 0,50zł/km(-50%)" +
                "\n Emerytalny/osoby niepełosprawnej: 0,75zł/km(-25%)" +

                "\n\n Cena biletu(powyżej 500km):" +
                "\n Normalny: 0,60zł/km" +
                "\n Dziecięcy(do lat 3): 0.15zł/km(-75%)" +
                "\n Szkolny/studencki: 0,30zł/km(-50%)" +
                "\n Emerytalny/osoby niepełosprawnej: 0,45zł/km(-25%)");
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
                "    8.00-15.00\n        ");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
