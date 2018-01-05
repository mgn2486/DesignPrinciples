using System;
using ConsoleApp1.QuackBehaviour;

namespace ConsoleApp1.DuckTypes
{
	class RubberDuck : Duck
	{
		public RubberDuck() : base(new MuteQuack(), new FlyNoWay())
		{
			

		}

		public override void Display()
		{
			Console.WriteLine("whatever");
		}
	}
}
