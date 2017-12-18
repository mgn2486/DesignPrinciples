using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class FlyWithWings : IFlyBehaviour
	{
		public void fly()
		{
			Console.WriteLine("I can fly!!!");
		}
	}
}
