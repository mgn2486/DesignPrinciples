using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exp_2_FactoryPattern.Interfaces;

namespace Exp_2_FactoryPattern.Shapes
{
	public class Rectangle : ShapeInterface
	{
		public void draw()
		{
			Console.WriteLine("I am a RECTANGLE: Please draw a RECTANGLE");
		}
	}
}
