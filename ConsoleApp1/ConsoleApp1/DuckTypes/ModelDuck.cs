using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DuckTypes
{
	class ModelDuck : Duck
	{
		//IFlyBehaviour _flyBehaviour;
		//private IQuackBehaviour _quackBehaviour;

		public ModelDuck()
			: base(new Quack(), new FlyNoWay())
		{
		}
		public override void display()
		{
			Console.WriteLine("I'm a model duck !!!");
		}
	}
}
