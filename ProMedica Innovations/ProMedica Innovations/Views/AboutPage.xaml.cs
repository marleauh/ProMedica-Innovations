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
            await Shell.Current.GoToAsync("//ItemsPage");
        }
    }
}