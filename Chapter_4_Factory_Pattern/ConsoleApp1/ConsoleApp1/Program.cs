using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public interface Shape
	{
		void draw();
	}

	public class Circle : Shape
	{
		public void draw()
		{
			Console.WriteLine("I am the CIRCLE Please draw me:  ");
		}
	}

	public class Rectangle : Shape
	{
		public void draw()
		{
			Console.WriteLine("I am the RECTANGLE Please draw me:  ");
		}
	}

	public class Square : Shape
	{
		public void draw()
		{
			Console.WriteLine("I am the SQUARE Please draw me:  ");
		}
	}

	public class ShapeFactory
	{
		public Shape GetShapeType(String shapeType)
		{
			if (shapeType == null)
			{
				return null;
			}
			if (shapeType.Equals("circle"))
			{
				return new Circle();
			}
			if (shapeType.Equals("rectangle"))
			{
				return new Rectangle();
			}
			if (shapeType.Equals("square"))
			{
				return new Square();
			}
			return null;
		}
	}

	
	class Program
	{
		static void Main(string[] args)
		{
			ShapeFactory shapeFactory = new ShapeFactory();

			Shape shape1 = shapeFactory.GetShapeType("circle");
			shape1.draw();

			Shape shape2 = shapeFactory.GetShapeType("rectangle");
			shape2.draw();

			Shape shape3 = shapeFactory.GetShapeType("square");
			shape3.draw();

			Console.ReadLine();
		}
	}
}
