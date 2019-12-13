using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FindMe.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        
        private readonly INavigationService _navigationService;

        private DelegateCommand _imageCommand;
        public DelegateCommand ImageCommand =>
            _imageCommand ?? (_imageCommand = new DelegateCommand(ExecuteImageCommand));
        async void ExecuteImageCommand()
        {
            await NavigationService.NavigateAsync("AddImage");
        }

        private DelegateCommand _profileCommand;
        public DelegateCommand ProfileCommand =>
            _profileCommand ?? (_profileCommand = new DelegateCommand(ExecuteProfileCommand));
        async void ExecuteProfileCommand()
        {
            await NavigationService.NavigateAsync("EditProfile");
        }
        public LoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Find Me";

            _navigationService = navigationService;
        }
    }
    
}
