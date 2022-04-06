using ProMedica_Innovations.Models;
using System;
using System.Linq;
using Xamarin.Forms;

namespace ProMedica_Innovations.Views
{
    public partial class IdeasPage : ContentPage
    {
        //IdeasViewModel _viewModel;

        public IdeasPage()
        {
            InitializeComponent();

            //BindingContext = _viewModel = new IdeasViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //_viewModel.OnAppearing();

            IdeasListView.ItemsSource = await App.Database.GetIdeasAsync();
        }
        async void OnAddClicked(object sender, EventArgs e)
        {
            // Navigate to the NoteEntryPage.
            await Shell.Current.GoToAsync(nameof(NewIdeaPage));
        }

        async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                // Navigate to the NoteEntryPage, passing the ID as a query parameter.
                Idea idea = (Idea)e.CurrentSelection.FirstOrDefault();
                await Shell.Current.GoToAsync($"{nameof(NewIdeaPage)}?{nameof(NewIdeaPage.Id)}={idea.Id}");
            }
        }
    }
}