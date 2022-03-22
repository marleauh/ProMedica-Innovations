using ProMedica_Innovations.Services;
using ProMedica_Innovations.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProMedica_Innovations
{
    public partial class App : Application
    {
        //Creates Database connection and creates a file on the phone itself if the database file has not already been made
        private static Database database;
        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "idea.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
