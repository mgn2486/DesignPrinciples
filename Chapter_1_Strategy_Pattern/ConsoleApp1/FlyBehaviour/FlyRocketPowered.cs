using System;

namespace ConsoleApp1.FlyBehaviour
{
	class FlyRocketPowered : IFlyBehaviour
	{
		public void Fly()
		{
			Console.WriteLine("I'm flying with a rocket !!!");
		}
	}
}
