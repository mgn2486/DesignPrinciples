using System.Collections.Generic;
using WheatherDataApp.Interfaces;

namespace WheatherDataApp.WheatherData
{
	class WeatherData : ISubject
	{
		private List<IObserver> observers;
		private float temperature;
		private float humidity;
		private float pressure;

		public WeatherData()
		{
			observers = new List<IObserver>();
		}

		public void registerObserver(IObserver o)
		{
			observers.Add(o);
		}

		public void RemoveObserver(IObserver o)
		{
			if (observers.Contains(o))
			{
				observers.Remove(o);
			}
		}

		public void NotifyObserver()
		{
			foreach (var observer in observers)
			{
				observer.Update(this.temperature, this.humidity, this.pressure);
			}
		}

		public void measurementsChanged()
		{
			NotifyObserver();
		}

		public void setMeasurements(float temperature, float humidity, float pressure)
		{
			this.temperature = temperature;
			this.humidity = humidity;
			this.pressure = pressure;

			measurementsChanged();
		}
	}
}
