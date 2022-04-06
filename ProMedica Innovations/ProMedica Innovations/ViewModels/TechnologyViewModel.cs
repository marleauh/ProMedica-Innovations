using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ProMedica_Innovations.ViewModels
{
    public class TechnologyViewModel : BaseViewModel
    {
        public ICommand OpenFlexScore { get; }
        public ICommand OpenLacs { get; }

        public ICommand OpenPdf { get; }

        public TechnologyViewModel()
        {
            OpenFlexScore = new Command(async () => await Browser.OpenAsync("https://www.venturemedgroup.com/"));
            OpenLacs = new Command(async () => await Browser.OpenAsync("https://www.kapioshealth.com/laboratoryassuredcompliancesolution.html"));
            OpenPdf = new Command(async () => await Browser.OpenAsync("https://www.promedica.org/innovations/_assets/documents/style-library/snippets/radialcheckdevice.pdf"));
        }

    }
}
