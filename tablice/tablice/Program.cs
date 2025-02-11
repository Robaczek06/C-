using System;

namespace tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int min = 101;
            int maks = 0;
            float srednia = 0;
            int j = 0;
            int k = 0;
            int[] tab = new int[50];
            Console.Write("wylosowane liczby:  ");
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = r.Next(-10, 100);
                Console.Write(tab[i] + ", ");
            }
            for (int i = 0; i < tab.Length; i++)
            {
                srednia += tab[i];
                if (tab[i] < min) min = tab[i];
                if (tab[i] > maks) maks = tab[i];
            }
            Console.WriteLine();
            srednia /= 50;
            Console.WriteLine("min: " + min);
            Console.WriteLine("maks: " + maks);
            Console.WriteLine("średnia: " + srednia);

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > srednia) j++;
                if (tab[i] < srednia) k++;
            }
            Console.WriteLine("Mniejsze liczby od śr: " + k);
            Console.WriteLine("liczby większe od śr: " + j);
            Console.Write("liczby w odwrotnej kolejności:  ");
            for (int i = tab.Length - 1; i >= 0; i--)
            {
                Console.Write(tab[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
