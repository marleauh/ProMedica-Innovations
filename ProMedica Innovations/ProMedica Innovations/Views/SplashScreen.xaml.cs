using ProMedica_Innovations.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProMedica_Innovations.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashScreen : ContentPage
    {
        public SplashScreen()
        {
            var vm = new SplashScreenViewModel();
            this.BindingContext = vm;
            InitializeComponent();
        }
    }
}