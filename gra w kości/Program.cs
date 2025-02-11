using System;
using System.Collections.Generic;

namespace gra_w_kości
{
    internal class Program
    {
            /************************************************
             nazwa: Randomizer
             opis: losuje wartości dla kostek od 1 do 6
             parametry: diceNums-ilość kostek wybranych przez użytkownika
                random-parametr do losowania liczb
             zwracany typ i opis: zwraca typ List, listę wylosowanych liczb w danej kostce
             autor: Daria Robak
            ************************************************/
        static List<int> Randomizer(int dicesNum, Random random)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < dicesNum; i++) numbers.Add(random.Next(1, 7));
            return numbers;
        }
        /************************************************
         nazwa: PointsCounter
         opis: zlicza punkty z kostek
         parametry: dice_values-liczby wylosowane dla danej kostki
         diceNum-ilość kostek wybranych przez użytkownika
         zwracany typ i opis: zwraca wartość int, sumę liczb które się pojawiły conajmniej 2 razy
         autor: Daria Robak
        ************************************************/
        static int PointsCounter(List<int> dice_values, int diceNum)
        {
            int points = 0;

            for (int i = 0; i < 7; i++)
            {
                int tempcounter = 0;
                for (int j = 0; j < diceNum; j++)
                {
                    if (dice_values[j] == i) tempcounter++;
                }
                if (tempcounter >= 2) points += tempcounter * i;
            }
            return points;
        }
        static void Main(string[] args)
        {
            int dices;
            Random rnd = new Random();

            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Ile chcesz rzucić kostek? (3-10)");
                    dices = int.Parse(Console.ReadLine());
                    if (dices >= 3 && dices <= 10) break;
                }

                List<int> numbers = Randomizer(dices, rnd);

                for (int i = 0; i < dices; i++) Console.WriteLine("Kostka " + (i + 1).ToString() + ": " + numbers[i].ToString());

                int points = PointsCounter(numbers, dices);

                Console.WriteLine("liczba uzyskanych punktów: " + points.ToString());
                Console.WriteLine("czy chcesz rzucić jeszcze raz? (t/n)");

                string answer = Console.ReadLine();

                if (answer == "n") break;
                else if (answer == "t") continue;
            }

        }
    }
}
