using ProMedica_Innovations.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ProMedica_Innovations.Views
{
    public partial class IdeaDetailPage : ContentPage
    {
        public IdeaDetailPage()
        {
            InitializeComponent();
            BindingContext = new IdeaDetailViewModel();
        }
    }
}