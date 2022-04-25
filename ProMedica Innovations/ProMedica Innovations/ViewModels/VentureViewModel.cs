using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ProMedica_Innovations.ViewModels
{
    public class VentureViewModel : BaseViewModel
    {
        public ICommand OpenFund { get; }
        public ICommand OpenNWFund { get; }
        public VentureViewModel()
        {
            OpenFund = new Command(async () => await Browser.OpenAsync("https://www.promedica.org/innovations/ventures/#venturefund-nav"));
            // command used by button to redirect to ProMedica's Venture Fund website
            OpenNWFund = new Command(async () => await Browser.OpenAsync("https://www.promedica.org/innovations/ventures/#ohiotech-nav"));
        }



    }
}
