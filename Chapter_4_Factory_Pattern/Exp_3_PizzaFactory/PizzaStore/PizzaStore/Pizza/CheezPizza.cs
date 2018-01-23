using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStore.PizzaInterface;

namespace PizzaStore.Pizza
{
	class CheezPizza : PizzaInterface.Pizza
	{
		public void GetPizza()
		{
			Console.WriteLine("I am the CHEEZPIZZA; Please serve me");
		}
	}
}
