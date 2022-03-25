using ProMedica_Innovations.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProMedica_Innovations.Views
{
    public partial class TermsOfServicePage : ContentPage, INotifyPropertyChanged
    {
        public bool IsBtnVisible;
        public TermsOfServicePage(string uri, bool isPdf)
        {
            InitializeComponent();
            this.BindingContext = new TermsOfServiceViewModel(uri, isPdf);
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            // Navigate to the NoteEntryPage.
            await Navigation.PushAsync(new NewIdeaPage());
        }
    }
}