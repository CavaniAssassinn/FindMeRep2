using Xamarin.Forms;

namespace FindMe.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void ToolbarItem_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AboutUs());
        }

        private async void ImageButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
