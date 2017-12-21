using System;
using WheatherDataApp.WheatherData;

namespace WheatherDataApp
{
	class Program
	{
		static void Main(string[] args)
		{
			WeatherData weatherData = new WeatherData();

			CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(weatherData);
			//ForeCastDisplay foreCastDisplay = new ForeCastDisplay(weatherData);

			weatherData.setMeasurements(10, 65, 30.4f);
			weatherData.setMeasurements(60, 22, 38.4f);
			weatherData.setMeasurements(30, 20, 25.4f);

			Console.ReadLine();
		}
	}
}
