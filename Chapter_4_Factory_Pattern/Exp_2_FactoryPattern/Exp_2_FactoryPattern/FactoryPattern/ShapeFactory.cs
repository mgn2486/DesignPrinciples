using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exp_2_FactoryPattern.Interfaces;
using Exp_2_FactoryPattern.Shapes;

namespace Exp_2_FactoryPattern.FactoryPattern
{
	class ShapeFactory
	{
		public ShapeInterface getShapeType(string shapeType)
		{
			if (shapeType == null)
			{
				return null;
			}
			if (shapeType.Equals("circle"))
			{
				return new circle();
			}
			if (shapeType.Equals("square"))
			{
				return new Square();
			}
			if (shapeType.Equals("rectangle"))
			{
				return new Rectangle();
			}

			return null;
		}
	}
}
