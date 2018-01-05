using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer_Basic.Interfaces;

namespace Observer_Basic.ConcreteClasses
{
	class ConcreteSubjectClass : Subject
	{
		private string _subjectState;
		private List<Observer> _observers = new List<Observer>();

		public string SubjectState
		{
			get { return _subjectState; }
			set { _subjectState = value; }
		}
		public void attach(Observer observer)
		{
			_observers.Add(observer);
		}

		public void Dettach(Observer observer)
		{
			_observers.Remove(observer);
		} 

		public void Notify()
		{
			foreach (Observer o in _observers)
			{
				o.Update();
			}
		}
	}
}
