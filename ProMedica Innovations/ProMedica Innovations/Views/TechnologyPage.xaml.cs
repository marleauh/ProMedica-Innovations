using ProMedica_Innovations.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProMedica_Innovations.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TechnologyPage : ContentPage
    {
        public TechnologyPage()
        {
            InitializeComponent();
            BindingContext = new TechnologyViewModel();
        }
    }
}