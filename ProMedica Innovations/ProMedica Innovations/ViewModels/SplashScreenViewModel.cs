using ProMedica_Innovations.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProMedica_Innovations.ViewModels
{
    class SplashScreenViewModel
    {
        public ICommand AboutCommand { private set; get; }
        public ICommand SubmitCommand { private set; get; }

        public SplashScreenViewModel()
        {
            AboutCommand = new Command(OnAboutButtonClicked);
            SubmitCommand = new Command(OnSubmitButtonClicked);
        }

        private async void OnAboutButtonClicked(object sender)
        {
            await Shell.Current.GoToAsync(nameof(AboutPage));
        }

        private async void OnSubmitButtonClicked(object sender)
        {
            await Shell.Current.GoToAsync("//TermsOfServicePage"); //Goes immediately to the terms of service page
        }
    }
}
