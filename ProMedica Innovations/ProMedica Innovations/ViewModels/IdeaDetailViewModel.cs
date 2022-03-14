using ProMedica_Innovations.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProMedica_Innovations.ViewModels
{
    [QueryProperty(nameof(IdeaId), nameof(IdeaId))]
    public class IdeaDetailViewModel : BaseViewModel
    {
        private string ideaId;
        private string FirstName;
        private string LastName;
        private string Email;
        private string Phone;
        private string Description;
        private string Availability;
        private string Referral;
        private bool Employee;
        public string Id { get; set; }

        public string firstname
        {
            get => FirstName;
            set => SetProperty(ref FirstName, value);
        }

        public string lastname
        {
            get => LastName;
            set => SetProperty(ref LastName, value);
        }

        public string email
        {
            get => Email;
            set => SetProperty(ref Email, value);
        }
        public string phone
        {
            get => Phone;
            set => SetProperty(ref Phone, value);
        }

        public string description
        {
            get => Description;
            set => SetProperty(ref Description, value);
        }
        public string availability
        {
            get => Availability;
            set => SetProperty(ref Availability, value);
        }
        public string referral
        {
            get => Referral;
            set => SetProperty(ref Referral, value);
        }
        public bool employee
        {
            get => Employee;
            set => SetProperty(ref Employee, value);
        }

        public string IdeaId
        {
            get
            {
                return ideaId;
            }
            set
            {
                ideaId = value;
                LoadIdeaId(value);
            }
        }

        public async void LoadIdeaId(string ideaId)
        {
            try
            {
                var idea = await DataStore.GetIdeaAsync(ideaId);
                Id = idea.Id;
                FirstName = idea.FirstName;
                LastName = idea.LastName;
                Email = idea.Email;
                Phone = idea.Phone;
                Description = idea.Description;
                Availability = idea.Availability;
                Referral = idea.Referral;
                Employee = idea.Employee;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Idea");
            }
        }
    }
}
