using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prostokąt{
    internal class Program{
        static void Main(string[] args){
            int x, y, a, b;
            string zn,space="";
            Console.WriteLine("podaj współrzędne");
            while (true){
                Console.Write("x:");
                x = int.Parse(Console.ReadLine());
                if (x > 0) break;
            }
            while (true) { 
            Console.Write("y:");
            y = int.Parse(Console.ReadLine());
                if (y > 0) break;
            }
            Console.WriteLine("podaj długość boków");
            while (true){
                Console.Write("a:");
                a = int.Parse(Console.ReadLine());
                if (a > 0) break;
            }
            while (true){
                Console.Write("b:");
                b = int.Parse(Console.ReadLine());
                if (b > 0) break;
            }
            Console.WriteLine("podaj znak");
            zn = Console.ReadLine();
            for (int i = 0; i < x; i++) space += ' ';

            for (int i = 0; i < y; i++) Console.WriteLine();

                for (int i = 0; i < b; i++) {
                Console.Write(space);
                for (int j = 0; j < a; j++) Console.Write(zn);
                Console.WriteLine();
            }
        }
    }
}
