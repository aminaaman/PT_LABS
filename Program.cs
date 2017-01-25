using System;

namespace Amina
{
	class Program
	{
		static bool isPrime(int a)
		{

			int k = 0;
			for (int i = 1; i <= a; ++i)
			{
				if (a % i == 0)
				{
					k++;
				}
			}

			if (k == 2) return true;

			return false;
		}

		static void Main(string[] args)
		{
			int n = args.Length;
			for (int i = 0; i < n; i++)
			{
				string s = args[i]; // "5"
				int p = int.Parse(s); // p = 5

				if (isPrime(p) == false)
				{
					Console.WriteLine(p);
				}
			}
		}
	}
}