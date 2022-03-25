using ProMedica_Innovations.Models;
using ProMedica_Innovations.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProMedica_Innovations.Views
{
    [QueryProperty(nameof(IdeaId), nameof(IdeaId))]
    public partial class NewIdeaPage : ContentPage
    {
        public string IdeaId
        {
            set
            {
                LoadIdea(value);
            }
        }

        public NewIdeaPage()
        {
            InitializeComponent();

            // Set the BindingContext of the page to a new Note.
            BindingContext = new Idea();
        }

        async void LoadIdea(string ideaId)
        {
            try
            {
                int id = Convert.ToInt32(ideaId);
                // Retrieve the note and set it as the BindingContext of the page.
                Idea idea = await App.Database.GetIdeaAsync(id);
                BindingContext = idea;
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load idea.");
            }
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var idea = (Idea)BindingContext;
            if (!string.IsNullOrWhiteSpace(idea.FirstName))
            {
                await App.Database.SaveIdeaAsync(idea);
            }

            // Navigate backwards
            await Shell.Current.GoToAsync("//LoginPage");
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var idea = (Idea)BindingContext;
            await App.Database.DeleteIdeaAsync(idea);

            // Navigate backwards
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}