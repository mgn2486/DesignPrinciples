using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Pizza
{
	class GreekPizza : PizzaInterface.Pizza
	{
		public void GetPizza()
		{
			Console.WriteLine("I am the GREEKPIZZA; Please serve me");
		}
	}
}
