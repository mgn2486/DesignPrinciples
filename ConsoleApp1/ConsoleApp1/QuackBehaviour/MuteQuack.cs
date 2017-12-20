using System;

namespace ConsoleApp1.QuackBehaviour
{
	class MuteQuack : IQuackBehaviour
	{
		public void Quack()
		{
			Console.WriteLine("<< Slience >>");
		}
	}
}
