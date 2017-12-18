using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class MallardDuck : Duck
	{
		public MallardDuck()
		{
			IQuackBehaviour quackBehaviour = new Quack();
			IFlyBehaviour flyBehaviour = new FlyWithWings();
		}

		public override void display()
		{
			Console.WriteLine("I'm a real Mallard duck");
		}

	}
}
