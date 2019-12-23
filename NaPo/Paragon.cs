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
        public DateTime dataPodróży;
        public string imięKlienta;
        public string nazwiskoKlienta;
        public string nrTelefonuKlienta;
        public int liczbaOsobZBiletemNormalnym=0;
        public int liczbaOsobZBiletemDziecięcym=0;
        public int liczbaOsobZBiletemStudenckim=0;
        public int liczbaOsobZBiletemEmeryta=0;
        public int rodzajZniżki = 0;
        public int numerParagonu=0;
        public int godzinaDrukuParagonu=0;
        public int odległośćOdCelu = 0;
        public Paragon(string początekPodróży, string celPodróży, string imięKlienta, string nazwiskoKlienta,
            string nrTelefonuKlienta, int liczbaOsobZBiletemNormalnym, int liczbaOsobZBiletemDziecięcym,
            int liczbaOsobZBiletemStudenckim, int liczbaOsobZBiletemEmeryta)
        {
            this.początekPodróży = początekPodróży;
            this.celPodróży = celPodróży;
            this.imięKlienta = imięKlienta;
            this.nazwiskoKlienta = nazwiskoKlienta;
            this.nrTelefonuKlienta = nrTelefonuKlienta;
            this.liczbaOsobZBiletemNormalnym = liczbaOsobZBiletemNormalnym;
            this.liczbaOsobZBiletemDziecięcym = liczbaOsobZBiletemDziecięcym;
            this.liczbaOsobZBiletemStudenckim = liczbaOsobZBiletemStudenckim;
            this.liczbaOsobZBiletemEmeryta = liczbaOsobZBiletemEmeryta;
        }
        public Paragon(string początekPodróży, string celPodróży, string imięKlienta, string nazwiskoKlienta,
            string nrTelefonuKlienta, int rodzajZniżki)
        {
            this.początekPodróży = początekPodróży;
            this.celPodróży = celPodróży;
            this.imięKlienta = imięKlienta;
            this.nazwiskoKlienta = nazwiskoKlienta;
            this.nrTelefonuKlienta = nrTelefonuKlienta;
            this.rodzajZniżki = rodzajZniżki;
        }
        public int WyliczOdległośćOdCelu()
        {
            return 0;
        }
        public string DrukujParagon()
        {
            return "Hello";
        }

    }
}
