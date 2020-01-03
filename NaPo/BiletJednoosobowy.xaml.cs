﻿using System;
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
        GrafMiast Mapa = new GrafMiast();
        string imię, nazwisko, telefon, email;
        int biletyNormalne = 0, biletyDziecięce = 0, biletyStudenckie = 0, biletyEmeryta = 0;
        public BiletJednoosobowy()
        {
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
                Paragon par = new Paragon(Com1.Text, Com2.Text, imię, nazwisko, telefon, email, biletyNormalne, biletyDziecięce,
                biletyStudenckie, biletyEmeryta, OdległośćOdCelu, DatePicker1.Text);
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextImię.Text != "")
            {
                try
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (TextImię.Text.Contains(Convert.ToString(i)))
                            Convert.ToInt32("a");
                    }
                    imię = TextImię.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("W tym miejscu mogą być tylko litery!!!");
                    TextImię.Text = "";
                }
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (TextNazwisko.Text != "")
            {
                try
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (TextNazwisko.Text.Contains(Convert.ToString(i)))
                            Convert.ToInt32("a");
                    }
                    nazwisko = TextNazwisko.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("W tym miejscu mogą być tylko litery!!!");
                    TextNazwisko.Text = "";
                }
            }
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            if (TextTelefon.Text != "")
            {
                try
                {
                    Convert.ToInt32(TextTelefon.Text);
                    telefon = TextTelefon.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("W tym miejscu mogą być tylko liczby!!!");
                    TextTelefon.Text = "";
                }
            }
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
            TextImię.Text = "";
            TextNazwisko.Text = "";
            TextTelefon.Text = "";
            TextEmail.Text = "";
            Com1.Text = null;
            Com2.Text = null;
            Com3.Text = null;
            DatePicker1.Text = null;
        }
        string SprawdźCzyPoprawneDane()
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
            if (imię == null || imię == "")
                return błąd;
            if (nazwisko == null || nazwisko == "")
                return błąd;
            if (telefon == null || telefon == "")
                return błąd;
            if (email == null || email == "")
                return błąd;
            if (biletyNormalne + biletyDziecięce + biletyStudenckie + biletyEmeryta == 0)
                return błąd;
            return "brak błędu";
        }
    }
}
