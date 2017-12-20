using System;
using ConsoleApp1.QuackBehaviour;

namespace ConsoleApp1.DuckTypes
{
	class RedHeadDuk : Duck
	{
		public RedHeadDuk() : base( new Quack(), new FlyWithWings())
		{
			
		}


		public override void Display()
		{
			Console.WriteLine("I'm red duck that squack a lot");
		}
	}
}
