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
        }

        public ICommand OpenWebCommand { get; }
    }
}