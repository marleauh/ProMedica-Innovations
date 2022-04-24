using ProMedica_Innovations.Views;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace ProMedica_Innovations.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertiesChanged = delegate { };
        private string email;
        public string Email // username used for admin authentication. 
        {
            get { return email; }
            set
            {
                email = value;
                PropertiesChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        private string password; // password used for admin authentication.
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertiesChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // admin logins
            if (email != "admin" || password != "promedica")
            {
                /* ########## In order to add admin logins you must copy/paste ##########*/
                if (email != "admin2" || password != "password")
                {
                    DisplayInvalidLoginPrompt();
                }
                else
                {
                    await Shell.Current.GoToAsync($"{nameof(IdeasPage)}");
                }
                /* ##########                  ALL OF THIS                     ###########*/
            }
            else
            {
                // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
                await Shell.Current.GoToAsync($"{nameof(IdeasPage)}");
            }
        }
    }
}
