using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FlyBehaviour
{
	class FlyRocketPowered : IFlyBehaviour
	{
		public void fly()
		{
			Console.WriteLine("I'm flying with a rocket !!!");
		}
	}
}
