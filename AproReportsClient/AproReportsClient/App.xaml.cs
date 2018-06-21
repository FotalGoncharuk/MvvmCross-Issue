using MvvmCross.Forms.Core;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace AproReportsClient
{
	public partial class App : MvxFormsApplication
    {
		public App ()
		{
			InitializeComponent();
		}
	}
}
