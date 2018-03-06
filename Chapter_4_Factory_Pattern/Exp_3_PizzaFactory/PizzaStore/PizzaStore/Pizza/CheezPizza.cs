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

		public void Prepare()
		{
			Console.WriteLine("Your Pizza is now being prepared , packe and delivered");
		}
	}
}
