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
        public ICommand InventorCommand { private set; get; }
        public ICommand TechnologyCommand { private set; get; }
        public ICommand VentureCommand { private set; get; }
        public ICommand DevelopmentCommand { private set; get; }
        public ICommand PITeamCommand { private set; get; }

        public SplashScreenViewModel()
        {
            AboutCommand = new Command(OnAboutButtonClicked);
            SubmitCommand = new Command(OnSubmitButtonClicked);
            InventorCommand = new Command(OnInventorButtonClicked);
            TechnologyCommand = new Command(OnTechnologyButtonClicked);
            VentureCommand = new Command(OnVentureButtonClicked);
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
        private async void OnInventorButtonClicked(object sender)
        {
            await Shell.Current.GoToAsync("InventorPage");
        }
        private async void OnTechnologyButtonClicked(object sender)
        {
            await Shell.Current.GoToAsync("TechnologyPage");
        }
        private async void OnVentureButtonClicked(object sender)
        {
            await Shell.Current.GoToAsync("VenturePage");
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
