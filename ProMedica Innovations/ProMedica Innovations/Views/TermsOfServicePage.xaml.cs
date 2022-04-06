using ProMedica_Innovations.ViewModels;
using System;
using System.ComponentModel;

using Xamarin.Forms;

namespace ProMedica_Innovations.Views
{
    public partial class TermsOfServicePage : ContentPage, INotifyPropertyChanged
    {
        public bool IsBtnVisible;

        public TermsOfServicePage()
        {
            InitializeComponent();
            this.BindingContext = new TermsOfServiceViewModel("https://www.promedica.org/innovations/Pages/innovation-submission.aspx", true);
        }

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