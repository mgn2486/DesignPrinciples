using System;

namespace Observer_Basic.Interfaces
{
	public interface Subject
	{
		void attach(Observer observer);

		void Dettach(Observer observer);

		void Notify();

	}
}
