using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FindMe.Tables;

namespace FindMe.Views
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new CreateAccountPage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EntryUser.Text) || string.IsNullOrEmpty(EntryPassword.Text))
            {
                await DisplayAlert("Empty Values", "Please enter Username and Password", "OK");
                await Navigation.PushAsync(new MainPage());

            }


        }
    }
}