using System;

namespace Pesel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pesel");
            string pesel = Console.ReadLine();
            if (pesel.Length == 11)
            {
                Console.Write("zgodność peselu ");
                Console.WriteLine(zgodnosc(pesel));
                if(zgodnosc(pesel))plec(pesel);
            }
            else Console.WriteLine("zły pesel");
        }
        /*
            nazwa funkcji: zgodnosc
            opis funkcji: sprawdza poprawność peselu na podstawie sumy kontrolnej
            parametry: pesel-numer pesel wpisany wcześniej przez użytkownika
            zwracany typ i opis: bool-w zależności od tego czy pesel jest zgodny, zwracanie jest prawda albo fałsz
         */
        static bool zgodnosc(string pesel)
        {
            int s = 0;
            int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            for (int i = 0; i < pesel.Length - 1; i++) s += int.Parse(pesel[i].ToString()) * wagi[i];
            int m = s % 10;
            int r;
            if (m == 0) _ = 0;
            r = 10 - m;
            if (r == int.Parse(pesel[10].ToString())) return true;
            else return false;
        }
        /*
        nazwa funkcji: plec
        opis funkcji: sprawdza płeć na podstawie peselu
        parametry: pesel-numer pesel wpisany wcześniej przez użytkownika
        zwracany typ i opis: void- wypisuje "M" jeżeli to jest mężczyzna, "K" jeżeli jest to kobieta
        */
        static void plec(string pesel)
        {
            if (int.Parse(pesel[9].ToString()) % 2 == 0 || int.Parse(pesel[9].ToString()) == 0) Console.WriteLine("K");
            else Console.WriteLine("M");
        }
    }
}
