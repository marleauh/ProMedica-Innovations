using ProMedica_Innovations.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProMedica_Innovations.ViewModels
{
    public class NewIdeaViewModel : BaseViewModel
    {
        private string firstname;
        private string lastname;
        private string gender;
        private string ethnicity;
        private string email;
        private string phone;
        private string description;
        private string availability;
        private string referral;
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
                && !String.IsNullOrWhiteSpace(email)
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
                Email = Email,
                Phone = Phone,
                Description = Description,
                Availability = Availability,
                Referral = Referral,
                Employee = Employee,
            };

            await DataStore.AddIdeaAsync(newIdea);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
