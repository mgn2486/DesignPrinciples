using System;
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
			mallard.Display();

			Console.WriteLine("\n #################################################### \n");

			Duck modelDuck = new ModelDuck();

			modelDuck.Display();
			modelDuck.PerformFly();
			modelDuck.SetFlyBehaviour(new FlyRocketPowered());
			modelDuck.PerformFly();

			Console.WriteLine("\n #################################################### \n");

			Duck redheaq = new RedHeadDuk();

			redheaq.Display();
			redheaq.PerformFly();
			redheaq.SetFlyBehaviour(new FlyRocketPowered());
			redheaq.PerformFly();

			Console.WriteLine("End of App");
			Console.ReadLine();

		}
	}
}
