using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartkówka
{
    internal class Program
    {
        static void Main(string[] args) {
            int a,b=0;
            float avg1,avg2, parz = 0, nieparz = 0, sum1 = 0, sum2 = 0;
            string num;
            while (true) { 
            Console.WriteLine("podaj liczbę z zakresu (1000,10000)");
            a =int.Parse(Console.ReadLine());
            if(a >=1000 && a<=10000 ) break; 
            else  Console.WriteLine("zła wartość");
            }
            num = a+"";

            for(int i = 0; i < num.Length; i++) {
                char v = num[i];
                string s = v.ToString();
                b += int.Parse(s);
            }

            for (int i = 0; i < num.Length; i++){
                char v = num[i];
                string s = v.ToString();

                if (int.Parse(s) % 2 != 0)
                {
                    sum1 += int.Parse(s);
                    nieparz++;
                }
                else if (int.Parse(s) % 2 == 0)
                {
                    sum2 += int.Parse(s);
                    parz++;
                }

            }
            avg1 = sum1 / nieparz;
            avg2 = sum2 / parz;
            Console.WriteLine("suma cyfr: "+b);
            Console.WriteLine("liczby nieparzystych jest: " + nieparz);
            Console.WriteLine("suma arytmetyczna ich: "+ avg1);
            Console.WriteLine("liczby parzystych jest: " + parz);
            Console.WriteLine("suma arytmetyczna ich: " +avg2);
            Console.WriteLine("stosunek "+ (avg2/avg1));


        }
    }
}
