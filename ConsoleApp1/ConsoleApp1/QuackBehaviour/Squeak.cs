using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Squeak : IQuackBehaviour
	{
		public void quack()
		{
			Console.WriteLine(" Squeak Squeak Squeak Squeak Squeak");
		}
	}
}
