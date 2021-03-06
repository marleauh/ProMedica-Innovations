using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ProMedica_Innovations.ViewModels
{
    public class DevelopmentViewModel : BaseViewModel
    {
        public ICommand OpenNextTech { get; }
        public ICommand OpenVenture { get; }
        public ICommand OpenKapios { get; }
        public ICommand OpenWellopp { get; }
        public ICommand OpenInfinity { get; }
        public ICommand OpenIchor { get; }
        public ICommand OpenMedview { get; }

        public DevelopmentViewModel()
        {
            OpenNextTech = new Command(async () => await Browser.OpenAsync("https://www.jumpstartinc.org/startups/"));
            OpenVenture = new Command(async () => await Browser.OpenAsync("https://www.venturemedgroup.com/"));
            OpenKapios = new Command(async () => await Browser.OpenAsync("https://www.kapioshealth.com/"));
            OpenWellopp = new Command(async () => await Browser.OpenAsync("https://wellopp.com/"));
            OpenInfinity = new Command(async () => await Browser.OpenAsync("https://infinityfunds.com/"));
            OpenIchor = new Command(async () => await Browser.OpenAsync("https://www.ichorsystems.com/"));
            OpenMedview = new Command(async () => await Browser.OpenAsync("https://www.medviewsystems.com/"));
        }
    }
}
