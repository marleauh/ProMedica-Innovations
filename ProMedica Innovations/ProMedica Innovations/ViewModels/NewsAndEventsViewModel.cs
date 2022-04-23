using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ProMedica_Innovations.ViewModels
{
    public class NewsAndEventsViewModel : BaseViewModel
    {
        public NewsAndEventsViewModel()
        {
            Title = "Read More";
            OpenNextBigIdea = new Command(async () => await Browser.OpenAsync("https://nextbigidea.health/"));
            // command used by button to redirect to ProMedica's Next Big Idea Contest website
        }

        public ICommand OpenNextBigIdea { get; }
    }
}
