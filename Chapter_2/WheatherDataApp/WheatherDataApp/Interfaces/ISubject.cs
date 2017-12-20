namespace WheatherDataApp.Interfaces
{
	public interface ISubject
	{
		void registerObserver(IObserver o);
		void RemoveObserver(IObserver o);
		void NotifyObserver();
	}
}
