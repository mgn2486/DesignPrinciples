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
			:base(new Quack(), new FlyWithWings())
		{
		}

		public override void display()
		{
			Console.WriteLine("I'm a real Mallard duck");
		}

	}
}
