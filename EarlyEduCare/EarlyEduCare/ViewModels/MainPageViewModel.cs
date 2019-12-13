using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EarlyEduCare.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        //login command

        private DelegateCommand _loginCreateCommandame;
        public DelegateCommand LoginCreateCommand =>
            _loginCreateCommandame ?? (_loginCreateCommandame = new DelegateCommand(ExecuteLoginCreateCommand));

        //sign up command
        private DelegateCommand _signUpCommand;
        public DelegateCommand SignUpCreateCommand =>
            _signUpCommand ?? (_signUpCommand = new DelegateCommand(ExecuteCommandName));

        //sign up function
        private async void ExecuteCommandName()
        {
            await NavigationService.NavigateAsync("SignUp");
        }

        //login function
        private async void ExecuteLoginCreateCommand()
        {
            await NavigationService.NavigateAsync("Login");
        }
        
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "EarlyEduCare";
            
        }
    }
}
