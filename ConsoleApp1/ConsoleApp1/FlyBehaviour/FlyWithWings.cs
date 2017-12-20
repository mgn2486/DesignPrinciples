using System;

namespace ConsoleApp1
{
	public class FlyWithWings : IFlyBehaviour
	{
		public void Fly()
		{
			Console.WriteLine("I can fly!!!");
		}
	}
}
