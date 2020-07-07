using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPratice
{
	class Calculator
	{
		//fields
		private string name;
		private DateTime birthday;
		private DayOfWeek birthdayDay;

		//properties
		public string Name
		{
			get { return this.name; }
			set { this.name = value; }
		}

		public DateTime Birthday
		{
			get { return birthday; }
			set { birthday = value; }
		}

		//methods
		public void Dayofbirth()
		{

			birthdayDay =  birthday.Date.DayOfWeek;

			Console.WriteLine("Hi {0}, your birthday was on a {1}", this.name, birthdayDay);
			Console.ReadLine();
		}
	}
}
