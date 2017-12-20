using System;
using ConsoleApp1.QuackBehaviour;

namespace ConsoleApp1.DuckTypes
{
	public class MallardDuck : Duck
	{
		public MallardDuck()
			:base(new Quack(), new FlyWithWings())
		{
		}

		public override void Display()
		{
			Console.WriteLine("I'm a real Mallard duck");
		}

	}
}
