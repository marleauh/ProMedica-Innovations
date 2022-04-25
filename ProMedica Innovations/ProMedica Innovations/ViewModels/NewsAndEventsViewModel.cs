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
            OpenNextBigIdea = new Command(async () => await Browser.OpenAsync("https://nextbigidea.health/"));
            // command used by button to redirect to ProMedica's Next Big Idea Contest website

            OpenArticle2 = new Command(async () => await Browser.OpenAsync("https://www.prnewswire.com/news-releases/tela-bio-announces-investment-agreement-with-promedica-innovations-venture-fund-300619295.html?tc=eml_cleartime"));
            // command used by button to redirect to ProMedica's Venture Article

            OpenArticle3 = new Command(async () => await Browser.OpenAsync("https://hips.healthcare/member/john-p-pigott"));
            // command used by button to redirect to ProMedica's PI Officer Article

            OpenMaps = new Command(async () => await Browser.OpenAsync("https://www.bing.com/maps?osid=95e1277c-6e9d-47c5-bbd6-608be4fc35c5&cp=41.673405~-83.676729&lvl=16&imgid=8d190d09-75e0-49c1-8a9f-31595803dedf&v=2&sV=2&form=S00027"));
            // command used by button to redirect to ProMedica's Google Listing and Maps Location
        }

        public ICommand OpenNextBigIdea { get; }
        public ICommand OpenArticle2 { get; }
        public ICommand OpenArticle3 { get; }
        public ICommand OpenMaps { get; }

    }
}
