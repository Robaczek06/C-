using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pozycja
{
    internal class Program
    {
        static void Main(string[] args){
            
            Pozycja pozycja = new Pozycja("banan", 2, 20);
            pozycja.Obliczwartosc();
            pozycja.info();
        }
    }
    class Pozycja
    {
        private string nazwaTowaru;
        private int ileSztuk;
        private double cena;

        public  Pozycja() { }
         public Pozycja(string nazwaTowaru, int ileSztuk, double cena){
            this.nazwaTowaru = nazwaTowaru;
            this.ileSztuk = ileSztuk;
            this.cena = cena;
        }
        public double Obliczwartosc() {
            return cena * ileSztuk;
        }
        public void info(){
            string informacja="", cen, szt, razem;
            cen =cena.ToString();
            szt = ileSztuk.ToString();
            razem =Obliczwartosc().ToString();
            int k=0, j;
            if (nazwaTowaru.Length <= 20 && cen.Length <= 10 && szt.ToString().Length <= 4 && razem.ToString().Length <= 10)
            {
                informacja += nazwaTowaru;
                if (nazwaTowaru.Length > 5) k = nazwaTowaru.Length - 5;
                j = 20 - k;
                for (int i = 0; i < j; i++) informacja += ' ';
                k = 0;
                j = 0;

                informacja += cen;
                informacja += " zl";
                if (cen.Length > 1) k = cen.Length - 1;
                j = 10 - k;
                for (int i = 0; i < j; i++) informacja += ' ';
                k = 0;
                j = 0;

                informacja += szt;
                informacja += " szt";
                if (szt.Length > 1) k = szt.Length - 1;
                j = 10 - k;
                for (int i = 0; i < j; i++) informacja += ' ';
                informacja += razem;
                informacja += " zl";
                Console.WriteLine(informacja);

            }
            else Console.WriteLine("złe informacje");
        }
        
    }
    class Zamowienie
    {
        Pozycja[] pozycje = new Pozycja[15];
        int ileDodanych, maksRozmiar;
        public Zamowienie()
        {
            this.maksRozmiar = 10;
        }
        public Zamowienie(Pozycja[] pozycje, int ileDodanych, int maksRozmiar)
        {
            this.pozycje = pozycje;
            this.ileDodanych = ileDodanych;
            this.maksRozmiar = maksRozmiar;
        }
        public void dodajPozycje(Pozycja p)
        {
            Pozycja nazwaTowaru = new Pozycja();
            nazwaTowaru.Obliczwartosc();
            int c = 0, l = 0;
            if (ileDodanych < maksRozmiar)
            {
                if (ileDodanych == 0)
                {
                    pozycje[ileDodanych] = p;
                    ileDodanych++;
                }
                else
                {
                    for (int i = 0; i < ileDodanych; i++)
                    {
                        if (pozycje[i].nazwaTowaru == p.nazwaTowaru)
                        {
                            c++;
                            l = i;
                        }
                    }
                    if (c == 1) pozycje[l].ileSztuk += p.ileSztuk;
                    else
                    {
                        pozycje[ileDodanych] = p;
                        ileDodanych++;
                    }
                }
            }
            else Console.WriteLine("złe wartości");
        }
    }
}
