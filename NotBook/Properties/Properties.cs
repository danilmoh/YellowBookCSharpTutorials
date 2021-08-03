using System;

namespace Time
{
	class TimePeriod
	{
		private double _seconds;

		public double Hours
		{
			get { return _seconds / 3600 ;}
			set {
				if ( value < 0 || value > 24 )
					throw new ArgumentOutOfRangeException(
						$"{nameof(value)} must be between 0 and 24.");

				_seconds = value * 3600;
			}
		}
	}

	class Program
	{
		static void Main()
		{
			TimePeriod t = new TimePeriod();
			// The property assignment "needs" set accsesor to be called.
			t.Hours = 24;

			// Retrieving the property causes the get acessor to be called.
			Console.WriteLine($"Time in hours: {t.Hours}");
		}
	}		// output: Time in hours: 24
}