using ProMedica_Innovations.ViewModels;
using ProMedica_Innovations.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ProMedica_Innovations
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(IdeaDetailPage), typeof(IdeaDetailPage));
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
            Routing.RegisterRoute(nameof(NewIdeaPage), typeof(NewIdeaPage));
            Routing.RegisterRoute(nameof(IdeasPage), typeof(IdeasPage));
            Routing.RegisterRoute(nameof(TechnologyPage), typeof(TechnologyPage));
            Routing.RegisterRoute(nameof(InventorPage), typeof(InventorPage));
            Routing.RegisterRoute(nameof(VenturePage), typeof(VenturePage));
            Routing.RegisterRoute(nameof(DevelopmentPage), typeof(DevelopmentPage));
            Routing.RegisterRoute(nameof(PITeamPage), typeof(PITeamPage));
        }

        private async void OnMenuIdeaClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
