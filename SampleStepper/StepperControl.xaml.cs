using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SampleStepper
{
	public partial class StepperControl : ContentView
	{
		public static readonly BindableProperty NumericProperty = BindableProperty.Create("IsNumeric",
																		typeof(double),
																		typeof(StepperControl),
																		0.0,
																		BindingMode.TwoWay,
																		propertyChanged: NumericValueChanged);

		public static readonly BindableProperty MaxValueProperty = BindableProperty.Create("MaxValue",
																		typeof(double),
																		typeof(StepperControl),
																		0.0,
																		BindingMode.TwoWay,
																		propertyChanged: MaxValueChanged);


		void ButtonMinus_Clicked(object o, System.EventArgs e)
		{
			if (IsNumeric > 0) {
				IsNumeric -= 1;
			}
		}

		void ButtonPlus_Clicked(object o, System.EventArgs e)
		{
			if (IsNumeric < MaxValue) {
				IsNumeric += 1;
			}
		}

		public StepperControl()
		{
			InitializeComponent();
		}

		public double IsNumeric {
			get { return (double)GetValue(NumericProperty); }
			set { SetValue(NumericProperty, value); }
		}

		public double MaxValue {
			get { return (double)GetValue(MaxValueProperty); }
			set { SetValue(MaxValueProperty, value); }
		}

		private static void NumericValueChanged(BindableObject bindable, object oldValue, object newValue)
		{
			(bindable as StepperControl).NumericLabel.Text = Convert.ToString(newValue);
		}

		private static void MaxValueChanged(BindableObject bindable, object oldValue, object newValue)
		{
		}
	}
}
