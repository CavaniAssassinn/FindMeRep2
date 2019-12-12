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
        public LoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Find Me";

            _navigationService = navigationService;
        }
    }
    
}
