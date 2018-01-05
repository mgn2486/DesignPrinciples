using System;
using WheatherDataApp.Interfaces;

namespace WheatherDataApp.WheatherData
{
	class CurrentConditionDisplay :  IDisplayElement, IObserver<TemperatureReadings>
	{
		private float temperature;
		private float humidity;
		//private ISubject weatherData;
		private float heatIndex;
		private IDisposable unsubscriber;

		public CurrentConditionDisplay(IObservable<TemperatureReadings> provider)//(ISubject weatherData)
		{
			//this.weatherData = weatherData;
			//weatherData.registerObserver(this);   // Explain.............
			this.unsubscriber = provider.Subscribe(this);
		}

		public void Update(float temperature, float humidity, float pressure)
		{
			this.temperature = temperature;
			this.humidity = humidity;
			this.heatIndex = (temperature * (float)1.85362) + humidity + pressure;
			Display();
		}

		public void Display()
		{
			Console.WriteLine("The current conditions: "+temperature+" F Degrees and "+humidity+" humidity");
			Console.WriteLine("The HeatWave is Currently: "+heatIndex);
		}

		public void OnNext(TemperatureReadings newReading)
		{
			this.Update(newReading.Temperature, newReading.Humidity, newReading.Pressure );
		}

		public void OnError(Exception error)
		{
			throw new NotImplementedException();
		}

		public void OnCompleted()
		{
			throw new NotImplementedException();
		}
	}
}
