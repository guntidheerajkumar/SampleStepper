using System;
using PropertyChanged;

namespace SampleStepper
{
	[ImplementPropertyChanged]
	public class MainViewModel
	{
		public double Age { get; set; } = 0;

		public double MaximumAge { get; set; } = 10;

		public MainViewModel()
		{
		}
	}
}
