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
        public Command<Idea> ItemTapped { get; }

        public IdeasViewModel()
        {
            Title = "Browse";
            Ideas = new ObservableCollection<Idea>();
            LoadIdeasCommand = new Command(async () => await ExecuteLoadIdeasCommand());

            ItemTapped = new Command<Idea>(OnIdeaSelected);

            AddIdeasCommand = new Command(OnAddItem);
        }

        async Task ExecuteLoadIdeasCommand()
        {
            IsBusy = true;

            try
            {
                Ideas.Clear();
                var ideas = await DataStore.GetIdeasAsync(true);
                foreach (var item in ideas)
                {
                    Ideas.Add(item);
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
            SelectedItem = null;
        }

        public Idea SelectedItem
        {
            get => _selectedIdea;
            set
            {
                SetProperty(ref _selectedIdea, value);
                OnIdeaSelected(value);
            }
        }

        private async void OnAddItem(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewItemPage));
        }

        async void OnIdeaSelected(Idea idea)
        {
            if (idea == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={idea.Id}");
        }
    }
}