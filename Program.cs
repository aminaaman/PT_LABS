using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amina
{
	class Program
	{
		class Complex 
		{
			public int x;
			public int y;
			public Complex(int x, int y) //constructor that initializes info
			{
				this.x = x;
				this.y = y;
			}

			public override string ToString() //function that outputs data as a string
			{
				return x + "/" + y;
			}

			public static Complex operator +(Complex x, Complex y) //function for overloading +
			{ 
				Complex c = new Complex(x.x * y.y + y.x * x.y, x.y * y.y);
				return c;
			}
			public static Complex operator -(Complex x, Complex y) //function for overloading -
			{
				Complex c = new Complex(x.x * y.y - y.x * x.y, x.y * y.y);
				return c;
			}
			public static Complex operator *(Complex x, Complex y) //fuction for overloading *
			{
				Complex c = new Complex(x.x * y.x, x.y * y.y);
				return c;
			}
			// 1/2 : 5/4 = (1 * 4)/(2 * 5)
			public static Complex operator /(Complex x, Complex y) //function for overloading /
			{
				Complex c = new Complex(x.x * y.y, y.x * x.y);
				return c;
			}

			static void Main(string[] args)
			{
				Complex a = new Complex(1, 2);
				Complex b = new Complex(2, 3);

				Complex c = a / b;
				Console.WriteLine(c);
				Console.ReadKey();
			}

		}
	}
}
		
