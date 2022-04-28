using ProMedica_Innovations.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProMedica_Innovations.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VenturePage : ContentPage
    {
        public VenturePage()
        {
            InitializeComponent();
            BindingContext = new VentureViewModel();
        }
    }
}