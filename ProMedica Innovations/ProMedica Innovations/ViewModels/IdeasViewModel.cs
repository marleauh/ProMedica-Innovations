using ProMedica_Innovations.Models;
using ProMedica_Innovations.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProMedica_Innovations.ViewModels
{
    public class IdeasViewModel : BaseViewModel
    {
        private Idea _selectedIdea;

        public ObservableCollection<Idea> Ideas { get; }
        public Command LoadIdeasCommand { get; }
        public Command AddIdeasCommand { get; }
        public Command<Idea> IdeaTapped { get; }

        public IdeasViewModel()
        {
            Title = "Browse";
            Ideas = new ObservableCollection<Idea>();
            LoadIdeasCommand = new Command(async () => await ExecuteLoadIdeasCommand());

            IdeaTapped = new Command<Idea>(OnIdeaSelected);

            AddIdeasCommand = new Command(OnAddIdea);
        }
        
        async Task ExecuteLoadIdeasCommand()
        {
            IsBusy = true;

            try
            {
                Ideas.Clear();
                var ideas = await DataStore.GetIdeasAsync(true);
                foreach (var idea in ideas)
                {
                    Ideas.Add(idea);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedIdea = null;
        }

        public Idea SelectedIdea
        {
            get => _selectedIdea;
            set
            {
                SetProperty(ref _selectedIdea, value);
                OnIdeaSelected(value);
            }
        }

        private async void OnAddIdea(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewIdeaPage));
        }

        async void OnIdeaSelected(Idea idea)
        {
            if (idea == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(IdeaDetailViewModel)}?{nameof(IdeaDetailViewModel.IdeaId)}={idea.Id}");
        }
    }
}