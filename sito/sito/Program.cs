using System;

namespace sito
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("podaj koniec zakresu");
			int n = int.Parse(Console.ReadLine());
			bool[] data = new bool[n + 1];

			for (int i = 2; i < n + 1; i++) data[i] = true;

			for (int i = 2; i * i < n; i++){
				if (data[i])
					for (int j = i * i; j <= n; j += i)
						data[j] = false;
			}
			for (int i = 0; i < n + 1; i++) if (data[i] == true) Console.Write(i+" ");
			Console.WriteLine();
		}
	}
}