using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exp_2_FactoryPattern.Interfaces;

namespace Exp_2_FactoryPattern.Shapes
{
	public class Square : ShapeInterface
	{
		public void draw()
		{
			Console.WriteLine("I am a SQUARE: Please draw me a SQUARE");
		}
	}
}
