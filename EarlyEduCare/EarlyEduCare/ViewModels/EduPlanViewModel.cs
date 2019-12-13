using EarlyEduCare.Models;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EarlyEduCare.ViewModels
{
    public class EduPlanViewModel : ViewModelBase
    {
        private DelegateCommand _testTwoCommand;
        public DelegateCommand TestTwoCommand =>
            _testTwoCommand ?? (_testTwoCommand = new DelegateCommand(ExecuteTestTwoCommand));

        private async void ExecuteTestTwoCommand()
        {
            await NavigationService.NavigateAsync("BurgerMenu/Navigation/MainFirstPage", useModalNavigation: true);
        }
        public EduPlanViewModel(INavigationService navigation) : base(navigation)
        {

        }
        //
       
    }
}
