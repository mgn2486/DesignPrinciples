using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStore.Pizza;
using PizzaStore.PizzaInterface;

namespace PizzaStore.PizzaFactory
{
	class PizzaFactory
	{
		public PizzaInterface.Pizza CreatePizza(string type)
		{
			PizzaInterface.Pizza pizza = null;

			if (type.Equals("cheeze"))
			{
				pizza = new CheezPizza();
			}
			if (type.Equals("clam"))
			{
				pizza = new ClamPizza();
			}
			if (type.Equals("eggie"))
			{
				pizza = new EggiePizza();
			}
			if (type.Equals("pepperoni"))
			{
				pizza = new PepperoniPizza();
			}
			if (type.Equals("greek"))
			{
				pizza = new GreekPizza();
			}

			return pizza;
		}
	}
}
