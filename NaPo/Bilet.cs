using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NaPo
{
    class Bilet
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
        public string numerBiletu;
        public string godzinaDrukuParagonu=Convert.ToString(DateTime.Now);
        public double odległośćOdCelu = 0;
        public double cenaBiletu = 0;
        public string data;
        public double CzyJednostronny;
        public Bilet(string początekPodróży, string celPodróży, string imięKlienta, string nazwiskoKlienta,
            string nrTelefonuKlienta, string emailKlienta, int liczbaOsobZBiletemNormalnym, int liczbaOsobZBiletemDziecięcym,
            int liczbaOsobZBiletemStudenckim, int liczbaOsobZBiletemEmeryta, double odległośćOdCelu, string data, double CzyJednostronny)
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
            this.data = data;
            this.CzyJednostronny = CzyJednostronny;

        }
        public void WywołajWyliczCenęBiletu()
        {
            double CenaBiletuNormalnego1 = 0.45;
            double CenaBiletuNormalnego2 = CenaBiletuNormalnego1 * 0.7;
            double CenaBiletuNormalnego3 = CenaBiletuNormalnego2 * 0.7;
            double CenaBiletuNormalnego4 = CenaBiletuNormalnego3* 0.9;
            if (this.odległośćOdCelu<=100)
                WyliczCenęBiletu(CenaBiletuNormalnego1);
            else if (this.odległośćOdCelu > 100 && this.odległośćOdCelu <= 300)
                WyliczCenęBiletu(CenaBiletuNormalnego2);
            else if (this.odległośćOdCelu > 300 && this.odległośćOdCelu <= 500)
                WyliczCenęBiletu(CenaBiletuNormalnego3);
            else if (this.odległośćOdCelu > 500)
                WyliczCenęBiletu(CenaBiletuNormalnego4);
        }
        void WyliczCenęBiletu(double Cena)
        {
            this.cenaBiletu = ((this.liczbaOsobZBiletemNormalnym * Cena) +
                    (this.liczbaOsobZBiletemDziecięcym * Cena * 0.25) +
                    (this.liczbaOsobZBiletemStudenckim * Cena * 0.5) +
                    (this.liczbaOsobZBiletemEmeryta * Cena * 0.75)) * this.odległośćOdCelu;
        }

        public string DrukujBilet(double zniżka)
        {
            WywołajWyliczCenęBiletu();
            this.numerBiletu = DziałaniaNaPlikach.NumerParagonu();
            string CzyWJednąStronę = (CzyJednostronny > 1.5) ? "W obie strony" : "W jedną stronę";
            string BiletDoWydrukowania = "Bilet imienny z \n" +
                "-" + this.początekPodróży + "\ndo\n" +
                "-" + this.celPodróży + "\nNa dzień\n" +
                "-" +this.data+ "\n" + "Rodzaj przejazdu\n" +
                "-" + CzyWJednąStronę + "\n" + "Cena biletu\n" +
                "-" + (this.cenaBiletu*zniżka*CzyJednostronny) + "zł\n\n" +
                "Imię: " + this.imięKlienta + "\n" +
                "Nazwisko: " + this.nazwiskoKlienta + "\n" +
                "Nr.Telefonu: " + this.nrTelefonuKlienta + "\n" +
                "Email: " + this.emailKlienta + "\n" +
                "Ilość biletów normalnych: " + this.liczbaOsobZBiletemNormalnym + "\n" +
                "Ilość biletów dziecięcych: " + this.liczbaOsobZBiletemDziecięcym + "\n" +
                "Ilość biletów uczniowskich/studenckich: " + this.liczbaOsobZBiletemStudenckim + "\n" +
                "Ilość biletów emeryta/osoby niepełosprawnej: " + this.liczbaOsobZBiletemEmeryta + "\n" +
                "Godzina kupna biletu: " + this.godzinaDrukuParagonu + "\n" +
                "Numer transakcji: " + this.numerBiletu + "\n";
            if (DziałaniaNaPlikach.WypiszDoPliku(BiletDoWydrukowania, this.numerBiletu))
                return "Dziękujemy za zakup biletu!\nŻyczymy dobrej podróży\n\nTwój bilet i paragon został zapisany na pulpicie";
            else
                return "Pojawił się błąd z zapisem biletu do pliku na pulpicie";
        }

    }
}
