using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPratice
{
	class Program
	{
		static void Main(string[] args)
		{
			Calculator calculator = new Calculator();

			Console.WriteLine("Enter your name and the date of your " +
				"birthday to receive the day of your birth");

			Console.Write("Name: ");
			calculator.Name = Console.ReadLine();

			Console.Write("Birthday: ");
			calculator.Birthday = Convert.ToDateTime(Console.ReadLine());

			calculator.Dayofbirth();
		}
	}
}
