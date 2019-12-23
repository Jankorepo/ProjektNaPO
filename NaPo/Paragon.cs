using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaPo
{
    class Paragon
    {
        public string początekPodróży;
        public string celPodróży;
        ////public 
        public string imięKlienta;
        public string nazwiskoKlienta;
        public string nrTelefonuKlienta;
        public string emailKlienta;
        public int liczbaOsobZBiletemNormalnym=0;
        public int liczbaOsobZBiletemDziecięcym=0;
        public int liczbaOsobZBiletemStudenckim=0;
        public int liczbaOsobZBiletemEmeryta=0;
        public string rodzajZniżki;
        public int numerParagonu=0;
        public int godzinaDrukuParagonu=0;
        public int odległośćOdCelu = 0;
        public int cenaBiletu = 0;
        public Paragon(string początekPodróży, string celPodróży, string imięKlienta, string nazwiskoKlienta,
            string nrTelefonuKlienta, string emailKlienta, int liczbaOsobZBiletemNormalnym, int liczbaOsobZBiletemDziecięcym,
            int liczbaOsobZBiletemStudenckim, int liczbaOsobZBiletemEmeryta)
        {
            this.początekPodróży = początekPodróży;
            this.celPodróży = celPodróży;
            this.imięKlienta = imięKlienta;
            this.nazwiskoKlienta = nazwiskoKlienta;
            this.nrTelefonuKlienta = nrTelefonuKlienta;
            this.emailKlienta = emailKlienta;
            this.liczbaOsobZBiletemNormalnym = liczbaOsobZBiletemNormalnym;
            this.liczbaOsobZBiletemDziecięcym = liczbaOsobZBiletemDziecięcym;
            this.liczbaOsobZBiletemStudenckim = liczbaOsobZBiletemStudenckim;
            this.liczbaOsobZBiletemEmeryta = liczbaOsobZBiletemEmeryta;

        }
        public Paragon(string początekPodróży, string celPodróży, string imięKlienta, string nazwiskoKlienta,
            string nrTelefonuKlienta,string emailKlienta, string rodzajZniżki)
        {
            this.początekPodróży = początekPodróży;
            this.celPodróży = celPodróży;
            this.imięKlienta = imięKlienta;
            this.nazwiskoKlienta = nazwiskoKlienta;
            this.nrTelefonuKlienta = nrTelefonuKlienta;
            this.emailKlienta = emailKlienta;
            this.rodzajZniżki = rodzajZniżki;
        }
        public int WyliczOdległośćOdCelu()
        {
            return 0;
        }
        public string DrukujParagon1()
        {
            return ("Bilet imienny z \n" +
                "-" + this.początekPodróży + "\ndo\n" +
                "-" + this.celPodróży + "\nNa dzień\n" +

                "-" + "01.01.1900" + "\n" + "Cena biletu\n" +
                "-" + this.cenaBiletu + "\n\n" +
                "Imię: " + this.imięKlienta + "\n" +
                "Nazwisko: " + this.nazwiskoKlienta + "\n" +
                "Nr.Telefonu: " + this.nrTelefonuKlienta + "\n" +
                "Email: " + this.emailKlienta + "\n" +
                "Ilość biletów normalnych: " + this.liczbaOsobZBiletemNormalnym + "\n" +
                "Ilość biletów dziecięcych: " + this.liczbaOsobZBiletemDziecięcym + "\n" +
                "Ilość biletów uczniowskich/studenckich: " + this.liczbaOsobZBiletemStudenckim + "\n" +
                "Ilość biletów emeryta/osoby niepełosprawnej: " + this.liczbaOsobZBiletemEmeryta + "\n" +
                "Godzina kupna biletu: " + this.godzinaDrukuParagonu + "\n" +
                "Numer transakcji: " + this.numerParagonu + "\n");
        }
        public string DrukujParagon2()
        {
            return ("Bilet imienny z \n" +
                "-" + this.początekPodróży + "\ndo\n" +
                "-" + this.celPodróży + "\nNa dzień\n" +
                
                "-" + "01.01.1900" + "\n" +"Cena biletu\n"+
                "-" + this.cenaBiletu + "\n\n" +
                "Imię: " + this.imięKlienta + "\n" +
                "Nazwisko: " + this.nazwiskoKlienta + "\n" +
                "Nr.Telefonu: " + this.nrTelefonuKlienta + "\n" +
                "Email: " + this.emailKlienta + "\n" +
                "Rodzaj biletu: " + this.rodzajZniżki + "\n" +
                "Godzina kupna biletu: " + this.godzinaDrukuParagonu + "\n" +
                "Numer transakcji: " + this.numerParagonu + "\n");
        }

    }
}
