using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Duck mallard = new MallardDuck();
			mallard.performQuack();
			mallard.performFly();

			Console.WriteLine("End of App");
		}
	}
}
