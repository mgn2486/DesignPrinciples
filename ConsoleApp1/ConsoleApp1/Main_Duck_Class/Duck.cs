using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public abstract class Duck
	{
		private IQuackBehaviour _quackBehaviour;
		private IFlyBehaviour _flyBehavior;

		public abstract void display();

		public Duck(IQuackBehaviour quackBehaviour, IFlyBehaviour flyBehavior)
		{
			_quackBehaviour = quackBehaviour;
			_flyBehavior = flyBehavior;
		}

		public void PerformQuack()
		{
			_quackBehaviour.quack();
		}

		public void PerformFly()
		{
			_flyBehavior.fly();
		}
		
		public void swim()
		{
			Console.WriteLine("All ducks float, even decoys!!!");
		}

		public void SetFlyBehaviour(IFlyBehaviour fb)
		{
			_flyBehavior = fb;
		}

		public void SetQuackBehaviour(IQuackBehaviour qb)
		{
			_quackBehaviour = qb;
		}
	}
}
