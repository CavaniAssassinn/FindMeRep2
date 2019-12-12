using FindMe.Tables;
using System;
using System.IO;
using Xamarin.Forms;
using SQLite;

namespace FindMe.Views
{
    public partial class CreateAccountPage : ContentPage
    {
        /* CreateAccountPage()
        {
            InitializeComponent();
        }*/
        protected override  void OnAppearing()
        {
            base.OnAppearing();
           // listView.ItemsSource = await App.Database.GetRegUserTableAsync();
        }

       private async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EntryUserName.Text) && string.IsNullOrEmpty(EntryUserPhoneNumber.Text) && string.IsNullOrEmpty(EntryUserEmail.Text) && string.IsNullOrEmpty(EntryUserPassword.Text))
            {
                await App.Database.SaveRegUserTableAsync(new RegUserTable
                {
                    Username = EntryUserName.Text,
                    Password = EntryUserPassword.Text,
                    Email = EntryUserEmail.Text,
                    PhoneNumber = int.Parse(EntryUserPassword.Text)
                });

                EntryUserName.Text = EntryUserPhoneNumber.Text = string.Empty;
               // listView.ItemsSource = await App.Database.GetRegUserTableAsync();
            }
        }
        /*private void Button_Clicked(object sender, System.EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<RegUserTable>();

            var item = new RegUserTable()
            {
                Username = EntryUserName.Text,
                Password = EntryUserPassword.Text,
                Email = EntryUserEmail.Text,
                PhoneNumber = EntryUserPhoneNumber.Text

            };

            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Congratulations", "User Registration Successfull", "Yes", "Cancel");

                if (result)
                    await Navigation.PushAsync(new MainPage()); 
            });*/
    }
    //}
}
