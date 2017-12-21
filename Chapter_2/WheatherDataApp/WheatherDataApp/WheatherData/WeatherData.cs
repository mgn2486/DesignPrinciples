using System;
using System.Collections.Generic;
using System.Configuration;
using WheatherDataApp.Interfaces;

namespace WheatherDataApp.WheatherData
{
	class WeatherData : IObservable<TemperatureReadings>
	{
		//private List<IObserver> observers;
		List<IObserver<TemperatureReadings>> observers;
		private float temperature;
		private float humidity;
		private float pressure;

		public WeatherData()
		{
			//observers = new List<IObserver>();
			observers = new List<IObserver<TemperatureReadings>>();
		}

		public void registerObserver(IObserver<TemperatureReadings> o)
		{
			observers.Add(o);
		}

		//public void RemoveObserver(IObserver o)
		//{
		//	if (observers.Contains(o))
		//	{
		//		observers.Remove(o);
		//	}
		//}

		public void NotifyObserver()
		{
			//foreach (var observer in observers)
			//{
			//	observer.Update(this.temperature, this.humidity, this.pressure);
			//}

			var newReading = new TemperatureReadings()
			{
				Humidity = this.humidity,
				Temperature = this.temperature,
				Pressure = this.pressure

			};

			foreach (var observer in observers)
				observer.OnNext(newReading);
		}



		public void measurementsChanged()
		{
			NotifyObserver();
		}

		//remove the arguments add the object created
		public void setMeasurements(float temperature, float humidity, float pressure)
		{
			this.temperature = temperature;
			this.humidity = humidity;
			this.pressure = pressure;

			measurementsChanged();
		}


		public IDisposable Subscribe(IObserver<TemperatureReadings> observer)
		{
			registerObserver(observer);

			return new Unsubscriber(observers, observer);
		}

		private class Unsubscriber : IDisposable
		{
			private List<IObserver<TemperatureReadings>> _observers;
			private IObserver<TemperatureReadings> _observer;

			public Unsubscriber(List<IObserver<TemperatureReadings>> observers, IObserver<TemperatureReadings> observer)
			{
				this._observers = observers;
				this._observer = observer;
			}

			public void Dispose()
			{
				if (!(_observer == null)) _observers.Remove(_observer);
			}
		}
	}
}
