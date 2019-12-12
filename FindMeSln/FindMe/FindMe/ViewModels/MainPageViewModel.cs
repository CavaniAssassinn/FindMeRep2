using Prism.Commands;
using Prism.Navigation;

namespace FindMe.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        private DelegateCommand _loginCommand;
            public DelegateCommand LoginCommand =>
                _loginCommand ?? (_loginCommand = new DelegateCommand(ExecuteLoginCommand));
            
        private DelegateCommand _signupCommand;
            public DelegateCommand SignUpCommand =>
                _signupCommand ?? (_signupCommand = new DelegateCommand(ExecuteSignUpCommand));
        
        private DelegateCommand _aboutusCommand;
        public DelegateCommand AboutUsCommand =>
            _aboutusCommand ?? (_aboutusCommand = new DelegateCommand(ExecuteAboutUsCommand));
             async void ExecuteSignUpCommand()
            {
                await NavigationService.NavigateAsync("CreateAccountPage");
            }
            async void ExecuteLoginCommand()
            {

            await NavigationService.NavigateAsync("LoginPage");
            }
             async void ExecuteAboutUsCommand()
             {
                 await NavigationService.NavigateAsync("AboutUs");
             }
            public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
            {
             Title = "Find Me";
            
             _navigationService = navigationService;
            }
    }
}
