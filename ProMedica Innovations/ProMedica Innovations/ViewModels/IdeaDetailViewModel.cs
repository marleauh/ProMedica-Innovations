using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace ProMedica_Innovations.ViewModels
{
    [QueryProperty(nameof(IdeaId), nameof(IdeaId))]
    public class IdeaDetailViewModel : BaseViewModel
    {
        private int ideaId;                          // Id from Idea object used for data context
        private string firstname;
        private string lastname;
        private string email;
        private string phone;
        private string description;
        private string availability;
        private string referral;
        private bool employee;
        public string Id { get; set; }                  // primary key

        public string FirstName
        {
            get => firstname;
            set => SetProperty(ref firstname, value);
        }

        public string LastName
        {
            get => lastname;
            set => SetProperty(ref lastname, value);
        }

        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }
        public string Phone
        {
            get => phone;
            set => SetProperty(ref phone, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }
        public string Availability
        {
            get => availability;
            set => SetProperty(ref availability, value);
        }
        public string Referral
        {
            get => referral;
            set => SetProperty(ref referral, value);
        }
        public bool Employee
        {
            get => employee;
            set => SetProperty(ref employee, value);
        }

        public int IdeaId
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
        // Loads data from individual record into ViewModel
        public async void LoadIdeaId(int ideaId)
        {
            try
            {
                var idea = await DataStore.GetIdeaAsync(ideaId);
                FirstName = idea.FirstName;
                LastName = idea.LastName;
                Email = idea.InvEmail;
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
