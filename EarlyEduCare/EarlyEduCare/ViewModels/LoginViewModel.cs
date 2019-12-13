using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EarlyEduCare.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private DelegateCommand _sendFormCommand;
        public DelegateCommand SendFormCommand =>
            _sendFormCommand ?? (_sendFormCommand = new DelegateCommand(ExecuteSendFormCommand));

       private async void ExecuteSendFormCommand()
        {
            
            await NavigationService.NavigateAsync("EduPlan", useModalNavigation : true);
        }
        public LoginViewModel(INavigationService navigation) : base(navigation)
        {

        }
    }
}
