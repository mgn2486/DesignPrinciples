using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Pizza
{
	class PepperoniPizza : PizzaInterface.Pizza
	{
		public void GetPizza()
		{
			Console.WriteLine("I am the PERPPERONIPIZZA; Please serve me");
		}

		public void Prepare()
		{
			Console.WriteLine("Your Pizza is now being prepared , packe and delivered");
		}
	}
}
