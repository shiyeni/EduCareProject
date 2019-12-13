using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EarlyEduCare.ViewModels
{
    public class BurgerMenuViewModel : ViewModelBase
    {


        
        private DelegateCommand _fieldName;
        public DelegateCommand OpenPdfCommand =>
            _fieldName ?? (_fieldName = new DelegateCommand(ExecuteOpenPdfCommand));

        private async void ExecuteOpenPdfCommand()
        {
            await NavigationService.NavigateAsync("Login");

        }
        public BurgerMenuViewModel(INavigationService navigation) : base(navigation)
        {

        }

    }
}
