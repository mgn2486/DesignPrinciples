using System;

namespace ConsoleApp1.QuackBehaviour
{
	class Quack : IQuackBehaviour
	{
		void IQuackBehaviour.Quack()
		{
			Console.WriteLine("Quack Quack Quack Quack");
		}
	}
}
