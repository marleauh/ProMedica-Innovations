using ProMedica_Innovations.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ProMedica_Innovations.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new IdeaDetailViewModel();
        }
    }
}