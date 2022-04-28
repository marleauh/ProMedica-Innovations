using ProMedica_Innovations.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ProMedica_Innovations.ViewModels
{
    public class NewIdeaViewModel : BaseViewModel
    {
        private string firstname;
        private string lastname;
        private string gender;
        private string ethnicity;
        private string citizenship_status;
        private string target_market;
        private string invemail;
        private string phone;
        private string idea_title;
        private string description;
        private bool is_new_idea;
        private string availability;
        private string referral;
        private string branch;
        private bool employee;
        public NewIdeaViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(firstname)
                && !String.IsNullOrWhiteSpace(lastname)
                && !String.IsNullOrWhiteSpace(gender)
                && !String.IsNullOrWhiteSpace(ethnicity)
                && !String.IsNullOrWhiteSpace(citizenship_status)
                && !String.IsNullOrWhiteSpace(target_market)
                && !String.IsNullOrWhiteSpace(invemail)
                && !String.IsNullOrWhiteSpace(phone)
                && !String.IsNullOrWhiteSpace(description)
                && !String.IsNullOrWhiteSpace(availability);
        }

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
        public string Gender
        {
            get => gender;
            set => SetProperty(ref gender, value);
        }
        public string Ethnicity
        {
            get => ethnicity;
            set => SetProperty(ref ethnicity, value);
        }
        public string CitizenshipStatus
        {
            get => citizenship_status;
            set => SetProperty(ref citizenship_status, value);
        }
        public string TargetMarket
        {
            get => target_market;
            set => SetProperty(ref target_market, value);
        }
        public string InvEmail
        {
            get => invemail;
            set => SetProperty(ref invemail, value);
        }
        public string Phone
        {
            get => phone;
            set => SetProperty(ref phone, value);
        }
        public string IdeaTitle
        {
            get => idea_title;
            set => SetProperty(ref idea_title, value);
        }
        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }
        public bool IsNewIdea
        {
            get => is_new_idea;
            set => SetProperty(ref is_new_idea, value);
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
        public string Branch
        {
            get => branch;
            set => SetProperty(ref branch, value);
        }
        public bool Employee
        {
            get => employee;
            set => SetProperty(ref employee, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            Idea newIdea = new Idea()
            {
                Id = Guid.NewGuid().GetHashCode(),
                FirstName = FirstName,
                LastName = LastName,
                Gender = Gender,
                Ethnicity = Ethnicity,
                CitizenshipStatus = CitizenshipStatus,
                TargetMarket = TargetMarket,
                InvEmail = InvEmail,
                Phone = Phone,
                IdeaTitle = IdeaTitle,
                Description = Description,
                IsNewIdea = IsNewIdea,
                Availability = Availability,
                Referral = Referral,
                Branch = Branch,
                Employee = Employee,
            };

            await DataStore.AddIdeaAsync(newIdea);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
