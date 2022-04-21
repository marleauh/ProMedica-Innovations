using ProMedica_Innovations.Models;
using System;
using System.Net.Mail;
using Xamarin.Forms;

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
            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("promedicainnovationsapp@gmail.com");
                mail.To.Add("promedicainnovationsapp@gmail.com");
                mail.Subject = "Test Invention";
                mail.Body = $"A new idea has been submitted. A brief summary of the details are listed below \n\n" +
                       $"------------------------------------------------------------------------------ \n\n" +
                       $"First Name : {idea.FirstName}\n" +
                       $"Last  Name : {idea.LastName}\n" +
                       $"Email      : {idea.InvEmail}\n\n" +
                       $"Descript.  : {idea.Description}\n\n" +
                       $"------------------------------------------------------------------------------ \n\n" +
                       $"";

                SmtpServer.Port = 587;
                SmtpServer.Host = "smtp.gmail.com";
                SmtpServer.EnableSsl = true;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("promedicainnovationsapp@gmail.com", "ProMedica4pp");

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                DisplayAlert("Faild", ex.Message, "OK");
            }
            if (!string.IsNullOrWhiteSpace(idea.FirstName))
            {
                await App.Database.SaveIdeaAsync(idea);
            }

            // Navigate backwards
            await Shell.Current.GoToAsync("//SplashScreen");
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var idea = (Idea)BindingContext;
            await App.Database.DeleteIdeaAsync(idea);

            // Navigate backwards
            await Shell.Current.GoToAsync("//SplashScreen");
        }
    }
}