using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer_Basic.Interfaces;

namespace Observer_Basic.ConcreteClasses
{
	class ConcreteObserverClass : Observer
	{
		private string _name;
		private ConcreteSubjectClass _subject;
		private string _observerstate;
		
		public ConcreteObserverClass(ConcreteSubjectClass subject, string name)
		{
			_subject = subject;
			_name = name;
		}

		public void Update()
		{
			_observerstate = _subject.SubjectState;
			Console.WriteLine("Observer {0}'s new state is {1}", _name, _observerstate);
		}
		// Gets or sets subject

		public ConcreteSubjectClass Subject
		{
			get { return _subject; }
			set { _subject = value; }
		}
	}
}
