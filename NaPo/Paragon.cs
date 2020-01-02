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
        public string imięKlienta;
        public string nazwiskoKlienta;
        public string nrTelefonuKlienta;
        public string emailKlienta;
        public int liczbaOsobZBiletemNormalnym=0;
        public int liczbaOsobZBiletemDziecięcym=0;
        public int liczbaOsobZBiletemStudenckim=0;
        public int liczbaOsobZBiletemEmeryta=0;
        public int numerParagonu=0;
        public int godzinaDrukuParagonu=0;
        public double odległośćOdCelu = 0;
        public double cenaBiletu = 0;
        public Paragon(string początekPodróży, string celPodróży, string imięKlienta, string nazwiskoKlienta,
            string nrTelefonuKlienta, string emailKlienta, int liczbaOsobZBiletemNormalnym, int liczbaOsobZBiletemDziecięcym,
            int liczbaOsobZBiletemStudenckim, int liczbaOsobZBiletemEmeryta, double odległośćOdCelu)
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
            this.odległośćOdCelu = odległośćOdCelu;

        }
        //public int WyliczOdległośćOdCelu()
        //{

        //    return odległośćOdCelu;
        //}
        public void WyliczCenęBiletu()
        {
            if (this.odległośćOdCelu<=100)
            {
                this.cenaBiletu = ((this.liczbaOsobZBiletemNormalnym * 1.6)+
                    (this.liczbaOsobZBiletemDziecięcym * 0.4)+
                    (this.liczbaOsobZBiletemStudenckim * 0.8)+
                    (this.liczbaOsobZBiletemEmeryta * 1.2))*this.odległośćOdCelu;
            }
            else if (this.odległośćOdCelu > 100 && this.odległośćOdCelu <= 500)
            {
                this.cenaBiletu = ((this.liczbaOsobZBiletemNormalnym * 1) +
                    (this.liczbaOsobZBiletemDziecięcym * 0.25) +
                    (this.liczbaOsobZBiletemStudenckim * 0.5) +
                    (this.liczbaOsobZBiletemEmeryta * 0.75)) * this.odległośćOdCelu;
            }
            else if (this.odległośćOdCelu > 500)
            {
                this.cenaBiletu = ((this.liczbaOsobZBiletemNormalnym * 0.6) +
                    (this.liczbaOsobZBiletemDziecięcym * 0.15) +
                    (this.liczbaOsobZBiletemStudenckim * 0.3) +
                    (this.liczbaOsobZBiletemEmeryta * 0.45)) * this.odległośćOdCelu;
            }
        }
        public string DrukujParagon1()
        {
            WyliczCenęBiletu();
            string wynik = "Bilet imienny z \n" +
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
                "Numer transakcji: " + this.numerParagonu + "\n";
            return wynik;
        }

    }
}
