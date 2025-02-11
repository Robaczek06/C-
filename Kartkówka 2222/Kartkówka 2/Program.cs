using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartkówka_2
{
    internal class Program
    {
        static void Main(string[] args){
            Random random = new Random();
            int licznik = 0;
            int[,] data = new int[3,5];

            for (int i = 0; i < 3; i++){
                for (int j = 0; j < 5; j++) data[i,j]= random.Next(1,51);
            }

            for (int i = 0; i < 3; i++){
                for (int j = 0; j < 5; j++)Console.Write(data[i,j]+" ");
                Console.WriteLine();
            }

            for(int i = 0;i < 3; i++) {
                for (int j = 0; j < 5; j++){
                    for (int k = 1; k < 51; k++)
                    {
                        if (data[i, j] % k == 0) licznik++;
                    }
                 if(licznik<=2) Console.WriteLine(data[i,j]);
                   licznik = 0;
                }
            }
        }
    }
}
