using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exp_2_FactoryPattern.Interfaces;

namespace Exp_2_FactoryPattern.Shapes
{
	public class circle : ShapeInterface
	{
		public void draw()
		{
			Console.WriteLine("I am a CIRCLE: Please draw a CIRCLE");
		}
	}
}
