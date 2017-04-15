using Xamarin.Forms;

namespace SampleStepper
{
	public partial class SampleStepperPage : ContentPage
	{
		public SampleStepperPage()
		{
			InitializeComponent();
			this.BindingContext = new MainViewModel();
		}
	}
}
