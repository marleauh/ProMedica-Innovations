using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ProMedica_Innovations.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About PI";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://promedica.org/innovations/about-pi/"));
            // command used by button to redirect to ProMedica's website
        }

        public ICommand OpenWebCommand { get; }
    }
}