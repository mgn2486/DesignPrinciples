using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.DuckTypes;
using ConsoleApp1.FlyBehaviour;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Duck mallard = new MallardDuck();

			mallard.PerformQuack();
			mallard.PerformFly();
			mallard.display();

			Console.WriteLine("\n #################################################### \n");

			Duck modelDuck = new ModelDuck();

			modelDuck.display();
			modelDuck.PerformFly();
			modelDuck.SetFlyBehaviour(new FlyRocketPowered());
			modelDuck.PerformFly();

			Console.WriteLine("\n #################################################### \n");

			Duck redheaq = new RedHeadDuk();

			redheaq.display();
			redheaq.PerformFly();
			redheaq.SetFlyBehaviour(new FlyRocketPowered());
			redheaq.PerformFly();

			Console.WriteLine("End of App");
			Console.ReadLine();

		}
	}
}
