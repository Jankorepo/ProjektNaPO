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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (T1.Text == "password")
                this.Content = new StronaAdmina();
        }

        private void Main_Navigated(object sender, NavigationEventArgs e)
        {

        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cena biletu za każdy wynajętny pojazd:" +
                "\n Bus (max 8 osób): 2,70zł/km" +
                "\n Bus VIP*(max 6 osób): 5,20zł/km" +
                "\n Autobus (max 40 osób): 10,00zł/km" +
                "\n Autobus VIP*(max 30 osób): 18,00zł/km" +
                "\n Pojazd osobowy(max 3 osoby): 1,50zł/km" +
                "\n Limuzyna(max 8 osób): 7,00zł/km" +
                "\n\n\nZniżki:" +
                "\nBilet dla dzieci: -50%" +
                "\nBilet szkolny/studencki: -25%:" +
                "\nBilet emeryta/osoby niepełosprawnej: -40%:" +
                "\n\n *VIP=(wygodniejsze fotele, więcej miejsca)");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Jesteśmy firmą bez doświadczenia ale posiadamy flotę busów z lat 80");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("      Nr. telefonu\n999-888-777\n\n      Siedziba firmy:\n" +
                "Ul.Kościuszki 15/12, 19-123 Warszawa" +
                "\n\nGodziny otwarcia:\nPoniedziałek-Piątek\n    7.00-21.00\nSobota\n" +
                "     8.00-15.00\n        " );
        }
    }
}
