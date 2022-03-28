using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProMedica_Innovations.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        private async void IdeaButtonClicked(object sender, EventArgs e)
        {
            //Controls what happens when the button "Submit Idea" button is pressed


            await Shell.Current.GoToAsync("//TermsOfServicePage");
        }

    }
}