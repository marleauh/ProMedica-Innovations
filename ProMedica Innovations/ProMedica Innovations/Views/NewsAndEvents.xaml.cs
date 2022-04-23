using ProMedica_Innovations.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProMedica_Innovations.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsAndEvents : ContentPage
    {
        public NewsAndEvents()
        {
            InitializeComponent();
            BindingContext = new NewsAndEventsViewModel();
        }
    }
}