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
        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewIdeaPage()); //This navigates to the Submit Idea page when the "Submit Idea" button is clicked
                                                         //We can make this work with other pages when we make them if needed
        }
    }
}