using ProMedica_Innovations.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProMedica_Innovations.Views
{
    public partial class OpenPdfPage : ContentPage
    {
        public OpenPdfPage()
        {
            InitializeComponent();
        }

        void OpenPdf(object sender, System.EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new TermsOfServicePage("https://www.promedica.org/innovations/Pages/innovation-submission.aspx", true));
        }

        void OpenJpg(object sender, System.EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new TermsOfServicePage("https://media.wuerth.com/stmedia/shop/348px/13367514.jpg", false));
        }
    }
}