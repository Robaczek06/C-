using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuinka_v2
{
    internal class Program
    {
        static void Main(string[] args){
            int wielkosc,ilosc;
            while (true) { 
                Console.Write("podaj wielkosc ");
                wielkosc=int.Parse(Console.ReadLine());
                Console.WriteLine("podaj ilosc trójkątów ");
                ilosc=int.Parse(Console.ReadLine());
                if (wielkosc > 1 && ilosc > 0) break;
            }
            for (int j=0; j<ilosc; j++) { 
                for (int i = 1; i <= wielkosc; i++){
                    for (int k = 1; k <= wielkosc - i; k++) Console.Write(" ");
                    for (int k = 1; k <= i * 2 - 1; k++) Console.Write("*");
                    Console.WriteLine();
                }
           }

            for (int p = 1; p <= wielkosc; p++) { 
                for (int k = 1; k <= wielkosc - 2; k++) Console.Write(" ");
                if(wielkosc>4) Console.Write("***\n");
                else Console.Write(" *\n");
            }
        }
    }
}
