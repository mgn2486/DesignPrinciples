using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public abstract class Duck
	{
		private readonly IQuackBehaviour _quackBehaviour = new Quack();
		private IFlyBehaviour _flyBehavior = new FlyWithWings();

		public abstract void display();

		protected Duck()
		{

		}

		public void performQuack()
		{
			_quackBehaviour.quack();
		}

		public void performFly()
		{
			_flyBehavior.fly();
		}

		public void swim()
		{
			Console.WriteLine("All ducks float, even decoys!!!");
		}
	}
}
