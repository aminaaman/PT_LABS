using System;
using System.IO; //library for using StreamReader and StreamWriter

namespace Amina
{
	class Program
	{
		static void Ex1()
		{ 
			StreamReader sr = new StreamReader(@"/Users/Adela/Documents/a.txt"); //showing the path
			string[] arr = sr.ReadLine().Split(); // "1 3 5 7 9 11" -> arr[0] = "1", arr[1] = "3"...

			int min = 320000;   
			int max = -1;		

			foreach (string i in arr)    //converting array to string 
			{
				int a = int.Parse(i); //converting string to integer


				//checking the min
				if (a < min)
				{
					min = a;
				}

				//checking the max
				if (a > max)
				{
					max = a;
				}


			}
			Console.WriteLine(min);
			Console.WriteLine(max);

			sr.Close();
		}
		static void Main(string[] args)
		{
			Ex1();
			Console.ReadKey();
		}
	}
}