using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace EarlyEduCare.ViewModels
{
    public class MainFirstPageViewModel : ViewModelBase
    {
        private DelegateCommand _whatsApp;
        public DelegateCommand WhatsApp =>
            _whatsApp ?? (_whatsApp = new DelegateCommand(ExecuteWhatsApp));

        private async void ExecuteWhatsApp()
        {
            Device.OpenUri(new Uri("whatsapp://send?phone=0715603159"));
        }
        public MainFirstPageViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
    }
}
