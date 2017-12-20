using System;

namespace ConsoleApp1
{
	class FlyNoWay : IFlyBehaviour
	{
		public void Fly()
		{
			Console.WriteLine("I cannot fly!!!");
		}
	}
}
            