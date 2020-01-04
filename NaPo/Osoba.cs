using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaPo
{
    public class Osoba
    {
        public string imię;
        public string nazwisko;
        public string telefon;
        public string email;
        public string nazwaUżytkownika;
        public string hasło;
        public string PESEL;
        public string CzyAdmin;
        public Osoba(string imię, string nazwisko, string telefon, string email, string nazwaUżytkownika, string hasło, string PESEL, string czyAdmin)
        {
            this.imię = imię;
            this.nazwisko = nazwisko;
            this.telefon = telefon;
            this.email = email;
            this.nazwaUżytkownika = nazwaUżytkownika;
            this.hasło = hasło;
            this.PESEL = PESEL;
            this.CzyAdmin = czyAdmin;
        }
    }
}
