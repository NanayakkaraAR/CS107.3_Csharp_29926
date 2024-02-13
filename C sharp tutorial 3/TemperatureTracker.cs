using System;
namespace tutorial_2
{
	internal class TemperatureTracker 
	{
		static void Main(string[] args)
		{
			TemperatureTracker tracker = new TemperatureTracker();

			tracker.DailyTemperature();
			Console.WriteLine("\n");
			tracker.Report();

			Console.ReadLine();
		}
		
	}
}

