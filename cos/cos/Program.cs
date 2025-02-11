using System;

/********************************************************
 * nazwa funkcji:       <change>
 * 
 * parametry wejściowe: <nazwa parametru> - <co przechowuje parametr>
 * wartość zwracana:    <zaszyfrowane słowo według szablonu>
 * opis funkcji:        <sprawdzanie i zamiana liter>
 * 
 * autor:               <numer PESEL zdającego>
 * ****************************************************/

namespace cos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("podaj słowo ");
            string word = Console.ReadLine();
            change(word);
        }
        static void change(string w)
        {
            string word2 = "";
            w = w.ToLower();
            for (int i = 0; i < w.Length; i++)
            {
                if      (w[i] == 'a') word2 += 'g';
                else if (w[i] == 'g') word2 += 'a';
                else if (w[i] == 'd') word2 += 'e';
                else if (w[i] == 'e') word2 += 'd';
                else if (w[i] == 'r') word2 += 'y';
                else if (w[i] == 'y') word2 += 'r';
                else if (w[i] == 'l') word2 += 'u';
                else if (w[i] == 'u') word2 += 'l';
                else if (w[i] == 'p') word2 += 'o';
                else if (w[i] == 'o') word2 += 'p';
                else if (w[i] == 'k') word2 += 'i';
                else if (w[i] == 'i') word2 += 'k';
                else word2 += w[i];
            }
            Console.WriteLine(word2);
        }
    }
}
