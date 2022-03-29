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
        }

        private async void OnMenuIdeaClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
