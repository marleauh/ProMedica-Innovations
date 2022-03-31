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
        public ICommand InventorsCommand { private set; get; }
        public ICommand TechnologyCommand { private set; get; }
        public ICommand VenturesCommand { private set; get; }
        public ICommand DevelopmentCommand { private set; get; }
        public ICommand PITeamCommand { private set; get; }

        public SplashScreenViewModel()
        {
            AboutCommand = new Command(OnAboutButtonClicked);
            SubmitCommand = new Command(OnSubmitButtonClicked);
            InventorsCommand = new Command(OnInventorsButtonClicked);
            TechnologyCommand = new Command(OnTechnologyButtonClicked);
            VenturesCommand = new Command(OnVenturesButtonClicked);
            DevelopmentCommand = new Command(OnDevelopmentButtonClicked);
            PITeamCommand = new Command(OnPITeamButtonClicked);
        }

        private async void OnAboutButtonClicked(object sender)
        {
            await Shell.Current.GoToAsync("//AboutPage");
        }

        private async void OnSubmitButtonClicked(object sender)
        {
            await Shell.Current.GoToAsync("//TermsOfServicePage"); //Goes immediately to the terms of service page
        }
        private async void OnInventorsButtonClicked(object sender)
        {
            await Shell.Current.GoToAsync("InventorsPage");
        }
        private async void OnTechnologyButtonClicked(object sender)
        {
            await Shell.Current.GoToAsync("TechnologyPage");
        }
        private async void OnVenturesButtonClicked(object sender)
        {
            await Shell.Current.GoToAsync("VenturesPage");
        }
        private async void OnDevelopmentButtonClicked(object sender)
        {
            await Shell.Current.GoToAsync("DevelopmentPage");
        }
        private async void OnPITeamButtonClicked(object sender)
        {
            await Shell.Current.GoToAsync("PITeamPage");
        }
    }
}
