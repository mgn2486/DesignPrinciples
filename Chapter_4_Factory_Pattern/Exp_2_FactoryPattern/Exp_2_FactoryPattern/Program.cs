using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exp_2_FactoryPattern.FactoryPattern;
using Exp_2_FactoryPattern.Interfaces;

namespace Exp_2_FactoryPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			ShapeFactory shapeFactory = new ShapeFactory();

			ShapeInterface shape1 = shapeFactory.getShapeType("circle");
			shape1.draw();

			ShapeInterface shape2 = shapeFactory.getShapeType("rectangle");
			shape2.draw();


			ShapeInterface shape3 = shapeFactory.getShapeType("square");
			shape3.draw();

			Console.ReadLine();
		}

	}

}
