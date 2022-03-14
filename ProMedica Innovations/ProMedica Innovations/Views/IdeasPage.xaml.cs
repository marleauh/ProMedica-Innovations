using ProMedica_Innovations.Models;
using ProMedica_Innovations.ViewModels;
using ProMedica_Innovations.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProMedica_Innovations.Views
{
    public partial class IdeasPage : ContentPage
    {
        IdeasViewModel _viewModel;

        public IdeasPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new IdeasViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}