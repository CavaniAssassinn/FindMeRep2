using Prism;
using Prism.Ioc;
using FindMe.ViewModels;
using FindMe.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FindMe.Services.Interfaces;
using System.IO;
using System;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FindMe
{
    public partial class App
    {
        static Database database;

        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3"));
                }
                return database;
            }
        }
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<CreateAccountPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<PrismMasterDetailPage1, PrismMasterDetailPage1ViewModel>(); 
            containerRegistry.RegisterForNavigation<AboutUs, AboutUsViewModel>();
            containerRegistry.RegisterForNavigation<EditProfile, EditProfileViewModel>();
            containerRegistry.RegisterForNavigation<AddImage, AddImageViewModel>();
            containerRegistry.RegisterForNavigation<AddCaption, AddCaptionViewModel>();
        }
    }
}
