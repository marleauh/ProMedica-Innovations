using ProMedica_Innovations.Models;
using ProMedica_Innovations.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProMedica_Innovations.Views
{
    public partial class NewIdeaPage : ContentPage
    {
        public Idea Idea { get; set; }

        public NewIdeaPage()
        {
            InitializeComponent();
            BindingContext = new NewIdeaViewModel();
        }
    }
}