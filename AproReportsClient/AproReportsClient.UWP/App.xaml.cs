using MvvmCross.Forms.Platforms.Uap.Core;
using MvvmCross.Forms.Platforms.Uap.Views;

namespace AproReportsClient.UWP
{
    sealed partial class App
    {
        public App()
        {
            this.InitializeComponent();
        }
    }

    public abstract class UwpApplication : 
        MvxWindowsApplication<MvxFormsWindowsSetup<Core.App, AproReportsClient.App>, Core.App, AproReportsClient.App, MainPage>
    {
    }
}
