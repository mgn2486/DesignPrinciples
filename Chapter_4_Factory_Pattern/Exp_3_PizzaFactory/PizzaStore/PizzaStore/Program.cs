using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
	class Program
	{
		static void Main(string[] args)
		{
			
			PizzaFactory.PizzaFactory myPizza = new PizzaFactory.PizzaFactory();

			PizzaInterface.Pizza thePizza = myPizza.CreatePizza("cheeze");
			thePizza.GetPizza();
			thePizza.Prepare();

			PizzaInterface.Pizza thePizza1 = myPizza.CreatePizza("eggie");
			thePizza1.GetPizza();

			PizzaInterface.Pizza thePizza2 = myPizza.CreatePizza("clam");
			thePizza2.GetPizza();

			PizzaInterface.Pizza thePizza3 = myPizza.CreatePizza("pepperoni");
			thePizza3.GetPizza();

			
			Console.ReadLine();
		}

		
	}
}
