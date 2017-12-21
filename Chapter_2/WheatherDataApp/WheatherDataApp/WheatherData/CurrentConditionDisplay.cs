using System;
using WheatherDataApp.Interfaces;

namespace WheatherDataApp.WheatherData
{
	class CurrentConditionDisplay : IObserver, IDisplayElement
	{
		private float temperature;
		private float humidity;
		private ISubject weatherData;
		private float heatIndex;

		public CurrentConditionDisplay(ISubject weatherData)
		{
			this.weatherData = weatherData;
			weatherData.registerObserver(this);   // Explain.............
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
	}
}
