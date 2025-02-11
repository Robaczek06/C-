using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macierze
{
    internal class Program
    {
        static void Main(string[] args){
            Random random = new Random();
            int[,] data = new int[5,5];
            int maks = -7;
            int min = 7;
            int[] maks_data=new int[5];
            int[] min_data=new int[5];
            for(int i = 0; i <5; i++) {
                for(int j = 0; j <5; j++){
                    data[i, j] = random.Next(-6, 6);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(data[i, j]);
                    Console.Write("  ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (data[i, j] > maks)
                    {
                        maks= data[i, j];
                        maks_data[i] = data[i, j];
                    }
                    if (data[i, j] < min)
                    {
                        min = data[i, j];
                        min_data[i] = data[i, j];
                    }
                }
                maks = -7;
                min = 7;
            }
            Console.WriteLine("minima");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(min_data[i]);
                Console.Write("  ");
            }
            Console.WriteLine() ;
            Console.WriteLine("maksima");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(maks_data[i]);
                Console.Write("  ");
            }
        }
    }
}
