using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer_Basic.ConcreteClasses;

namespace Observer_Basic
{
	class Program
	{
		static void Main(string[] args)
		{
			// Configure Observer pattern

			ConcreteSubjectClass s = new ConcreteSubjectClass();

			s.attach(new ConcreteObserverClass(s, "X"));
			s.attach(new ConcreteObserverClass(s, "Y"));
			s.attach(new ConcreteObserverClass(s, "Z"));

			// Change subject and notify observers

			s.SubjectState = "ABC";
			s.Notify();

			// Wait for user

			Console.ReadKey();
		}
	}

	
}
