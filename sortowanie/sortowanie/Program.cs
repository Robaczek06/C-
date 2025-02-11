using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortowanie
{
    internal class Program
    {
        static void Main(string[] args){
            int[] data = new int[100];
            int licznik = 0;
            Random rand = new Random();
            for(int i = 0; i < data.Length; i++) data[i] = rand.Next(1,51);

            //bąbelkowe
            for (int i = 0;i < data.Length-1; i++){
                for(int j = 0; j < data.Length-1-i; j++) {
                    if (data[j] > data[j + 1])
                    {
                        licznik++;
                        (data[j + 1], data[j]) = (data[j], data[j + 1]);
                    }
                }
            }
            Console.Write("liczba zmian: ");
            Console.WriteLine(licznik);
            licznik = 0;

            for (int i = 0; i < data.Length; i++) data[i] = rand.Next(1, 51);

            //wstawianie
            for (int i = 1; i < data.Length; i++) {
                int val = data[i];
                int j = i - 1;
                while(j >= 0 && data[j]>val) {
                    data[j + 1] = data[j];
                    j--;
                   
                }
                data[j+1] = val;
                licznik++;
            }
            Console.Write("liczba zmian: ");
            Console.WriteLine(licznik);

            for (int i = 0; i < data.Length; i++) data[i] = rand.Next(1, 51);
            //przez wybór 
            int k;
            for (int i = 0; i < data.Length; i++)
            {
                k = i;
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[j] < data[k])
                    {
                        k = j;
                        (data[i], data[k]) = (data[k], data[i]);
                        licznik++;
                    }
                }
            }
            Console.Write("liczba zmian: ");
            Console.WriteLine(licznik);
        }
    }
}
