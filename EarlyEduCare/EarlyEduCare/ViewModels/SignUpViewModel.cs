using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EarlyEduCare.ViewModels
{
    public class SignUpViewModel : ViewModelBase
    {
        private DelegateCommand _submitFormCommand;
        public DelegateCommand SubmitFormCommand =>
            _submitFormCommand ?? (_submitFormCommand = new DelegateCommand(ExecuteSubmitFormCommand));

       private async void ExecuteSubmitFormCommand()
        {
            await NavigationService.NavigateAsync("Login", useModalNavigation: true);
        }
        public SignUpViewModel(INavigationService navigation) : base(navigation)
        {

        }
    }
}
