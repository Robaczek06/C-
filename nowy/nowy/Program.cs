using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nowy{
    internal class Program{
        static void Main(string[] args){
            double c, a, b, d;

            while (true) { 
            Console.WriteLine("podaj cene towaru");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj ilość rat");
            b = int.Parse(Console.ReadLine());
                if (a >= 500 && a <= 10000 && b >= 6 && b <= 48) break;
            }
            if (b >= 6 && b <= 12) c = 0.025;
            else if (b >= 13 && b <= 24) c = 0.05;
            else c = 0.10;
                d = (a/b) +(c*a);
            Console.WriteLine(d);
            Random r = new Random();
            int x = r.Next(11);
            Console.WriteLine(x);
        }
    }
}
