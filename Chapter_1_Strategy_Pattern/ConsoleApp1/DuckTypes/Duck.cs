using System;

namespace ConsoleApp1.DuckTypes
{
	public abstract class Duck
	{
		private IQuackBehaviour _quackBehaviour;
		private IFlyBehaviour _flyBehavior;

		public Duck(IQuackBehaviour quackBehaviour, IFlyBehaviour flyBehavior)
		{
			_quackBehaviour = quackBehaviour;
			_flyBehavior = flyBehavior;
		}

		public abstract void Display();

		public void PerformQuack()
		{
			_quackBehaviour.Quack();
		}

		public void PerformFly()
		{
			_flyBehavior.Fly();
		}
		
		public void Swim()
		{
			Console.WriteLine("I'm swimming!!!");
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
