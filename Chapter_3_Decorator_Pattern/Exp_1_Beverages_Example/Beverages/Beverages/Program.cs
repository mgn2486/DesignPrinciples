using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverages
{
	//This is the main class for all beverages
	public abstract class Beverage
	{
		public string description = "Unknown beverage";

		public abstract string GetDescription();
		//{
		//	return description;
		//}

		public abstract double cost();
	}

	public abstract class CondimentDecorator : Beverage
	{
		//public abstract string GetDescription();
	}

	public class Espresso : Beverage
	{
		public Espresso()
		{
			description = "Espresso";
		}

		public override string GetDescription()
		{
			return "Espresso";
		}

		public override double cost()
		{
			return 1.99;
		}
	}

	public class HouseBlend : Beverage
	{
		public override string GetDescription()
		{
			return "House Blend";
		}

		public override double cost()
		{
			return 0.89;
		}
	}
	//&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&

	public class DarkRoast : Beverage
	{
		public DarkRoast()
		{
			description = "DarkRoast";
		}

		public override string GetDescription()
		{
			return "DarkRoast";
		}

		public override double cost()
		{
			return 0.99;
		}
	}

//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

	public class Mocha : CondimentDecorator
	{
		private Beverage beverage;
		public Mocha(Beverage beverage)
		{
			this.beverage = beverage;
		}
		public override string GetDescription()
		{
			return beverage.GetDescription() + ", Mocha";
		}

		public override double cost()
		{
			return 0.20 + beverage.cost();
		}
	}

//&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&

	public class Whip : CondimentDecorator
	{
		private Beverage beverage;
		public Whip(Beverage beverage)
		{
			this.beverage = beverage;
		}
		public override string GetDescription()
		{
			return beverage.GetDescription() + ", Whip";
		}
		public override double cost()
		{
			return 0.10 + beverage.cost();
		}
	}

//&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&

	class Program
	{
		static void Main(string[] args)
		{
			Beverage beverage = new Espresso();

			Console.WriteLine(beverage.GetDescription() + " - R "+beverage.cost()+"\n");

			Beverage beverage2 = new DarkRoast();
			beverage2 = new Mocha(beverage2);
			beverage2 = new Mocha(beverage2);
			beverage2 = new Whip(beverage2);

			Console.WriteLine(beverage2.GetDescription() + " - R "+ beverage2.cost());
			
			Console.ReadLine();

		}

	}
}
