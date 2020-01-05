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
        public StronaAdmina()
        {
            foreach (var miasto in DziałaniaNaPlikach.WczytajMiasta())
            {
                InitializeComponent();
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
            ComUsuńPoł1.Items.Clear();
            ComUsuńMiastoIPołączenia.Items.Clear();
            foreach (var miasto in DziałaniaNaPlikach.WczytajMiasta())
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
    }
}
