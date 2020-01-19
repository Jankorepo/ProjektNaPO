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
            MessageBox.Show("Jesteśmy prężnie rozwijającą się firmą, która swoje pierwsze kroki stawiała w grudniu 2019 roku. " +
                "Bogata flota pojazdów oraz dynamicznie rozwijający się zespół pozwoliły nam dotrzeć do milionów klientów. " +
                "Firma jest zarządzana przez szefostwo: Adama Jankowiaka oraz Jakuba Jabłońskiego. " +
                "Naszym celem jest dalszy rozwój oraz dotarcie do klientów poza granicami Polski.");
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
            List<Osoba> Użytkownicy = DziałaniaNaPlikach.WczytajUżytkowników();
            try
            {
                Osoba CzyIstniejeTakiUżytkownik = Użytkownicy.Find(k => k.nazwaUżytkownika == TextLogNazwaUżytkownika.Text && k.hasło == TextLogHasło.Text);
                string dlaczegToNieDziała = CzyIstniejeTakiUżytkownik.nazwaUżytkownika;
                if (CzyIstniejeTakiUżytkownik.CzyAdmin == "nie")
                {
                    WyczyśćWszystkiePola();
                    Hide();
                    new WybierzBilet(CzyIstniejeTakiUżytkownik).ShowDialog();
                    ShowDialog();
                }
                else
                {
                    WyczyśćWszystkiePola();
                    Hide();
                    new StronaAdmina().ShowDialog();
                    ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd przy logowaniu, proszę spróbować jeszcze raz");
            }

        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(SprawdźCzyPoprawneDane()== "brak błędu")
            {
                List<Osoba> Użytkownicy = DziałaniaNaPlikach.WczytajUżytkowników();
                Osoba CzyIstniejeJużTakieKonto = Użytkownicy.Find(k => k.nazwaUżytkownika == TextRejNazwaUżytkownika.Text);
                if (CzyIstniejeJużTakieKonto==null)
                {
                    Osoba nowyKlient;
                    if(NowaNazwa.Contains("Admin")|| NowaNazwa.Contains("admin"))
                        nowyKlient=new Osoba(NoweImię, NoweNazwisko, NowyTelefon, NowyEmail, NowaNazwa, NoweHaslo, NowyPESEL, "tak");
                    else
                        nowyKlient =new Osoba(NoweImię, NoweNazwisko, NowyTelefon, NowyEmail, NowaNazwa, NoweHaslo, NowyPESEL, "nie");
                    DziałaniaNaPlikach.DodajUżytkownika(nowyKlient);
                    MessageBox.Show("Założono nowe konto\n Witaj " + NoweImię + " " + NoweNazwisko);
                    WyczyśćWszystkiePola();
                }
                else
                    MessageBox.Show("Uwaga!\n Ta nazwa użytkownika jest już zajęta");

            }
            else
            {
                MessageBox.Show(SprawdźCzyPoprawneDane());
            }

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
                    foreach (var litera in TextRejImię.Text)
                    {
                        if (!((litera <= 'z' && litera >= 'a') || (litera <= 'Z' && litera >= 'A') || litera==' ' || litera == 'ę'))
                            Convert.ToInt32("a");
                    }
                    NoweImię = TextRejImię.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("W tym miejscu mogą być tylko zwykłe litery!!!");
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
                    foreach (var litera in TextRejNazwisko.Text)
                    {
                        if (!((litera <= 'z' && litera >= 'a') || (litera <= 'Z' && litera >= 'A') || litera == ' '))
                            Convert.ToInt32("a");
                    }
                    NoweNazwisko = TextRejNazwisko.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("W tym miejscu mogą być tylko zwykłe litery!!!");
                    TextRejNazwisko.Text = "";
                }
            }
        }

        private void TextRejTelefon_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextRejTelefon.Text!= "Podaj swój nr telefonu" && TextRejTelefon.Text != "")
                try
                {
                    for (int i = 0; i < TextRejTelefon.Text.Length; i++)
                    {
                        Convert.ToInt32(TextRejTelefon.Text);
                        Convert.ToString(TextRejTelefon.Text);
                    }
                    NowyTelefon = TextRejTelefon.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("W tym miejscu mogą być tylko liczby!!!");
                TextRejTelefon.Text = "";
                }
        }
        private void TextRejEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            NowyEmail = TextRejEmail.Text;
        }
        private void TextRejPESEL_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (TextRejPESEL.Text != "Podaj swój PESEL" && TextRejPESEL.Text != "")
            {
                try
                {
                    for (int i = 0; i < TextRejPESEL.Text.Length; i++)
                    {
                        Convert.ToInt64(TextRejPESEL.Text);
                        Convert.ToString(TextRejPESEL.Text);
                    }
                    NowyPESEL = TextRejPESEL.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("W tym miejscu mogą być tylko liczby!!!");
                    TextRejPESEL.Text = "";
                }
            }
                
        }
        public string SprawdźCzyPoprawneDane()
        {

            string błąd = "Podano błędne dane: ";
            if (TextRejNazwaUżytkownika.Text == null || TextRejNazwaUżytkownika.Text == "" || TextRejNazwaUżytkownika.Text.Length<3)
                return błąd;
            if (TextRejHasło.Text == null || TextRejHasło.Text == "" || TextRejHasło.Text.Length<3)
                return błąd;
            if (TextRejImię.Text == null || TextRejImię.Text == "" || TextRejImię.Text.Length==1)
                return błąd;
            if (TextRejNazwisko.Text == null || TextRejNazwisko.Text == "" || TextRejNazwisko.Text.Length==1)
                return błąd;
            if (TextRejTelefon.Text == null || TextRejTelefon.Text == "" || TextRejTelefon.Text.Length!=9)
                return błąd;
            if (TextRejEmail.Text == null || TextRejEmail.Text == "" || !TextRejEmail.Text.Contains("@"))
                return błąd;
            if (TextRejPESEL.Text == null || TextRejPESEL.Text == "" || TextRejPESEL.Text.Length!=11)
                return błąd;
            return "brak błędu";
        }
        public void WyczyśćWszystkiePola()
        {
            TextLogNazwaUżytkownika.Text = "Podaj nazwę użytownika";
            TextLogHasło.Text = "Podaj hasło";
            TextRejNazwaUżytkownika.Text = "Podaj nazwę użytownika";
            TextRejHasło.Text = "Podaj hasło";
            TextRejImię.Text = "Podaj swoje imię";
            TextRejNazwisko.Text = "Podaj swoje nazwisko";
            TextRejTelefon.Text = "Podaj swój nr telefonu";
            TextRejEmail.Text = "Podaj swój adres email";
            TextRejPESEL.Text = "Podaj swój PESEL";
        }
    }
}
