using System;
using ConsoleApp1.QuackBehaviour;

namespace ConsoleApp1.DuckTypes
{
	class ModelDuck : Duck
	{
		public ModelDuck()
			: base(new Quack(), new FlyNoWay())
		{
		}
		public override void Display()
		{
			Console.WriteLine("I'm a model duck !!!");
		}
	}
}
