using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DuckTypes
{
	class RedHeadDuk : Duck
	{
		public RedHeadDuk() : base( new Quack(), new FlyWithWings())
		{
			
		}


		public override void display()
		{
			Console.WriteLine("I'm red duck that squack a lot");
		}
	}
}
