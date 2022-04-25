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
        }

        public ICommand OpenNextBigIdea { get; }
        public ICommand OpenArticle2 { get; }
        public ICommand OpenArticle3 { get; }

    }
}
