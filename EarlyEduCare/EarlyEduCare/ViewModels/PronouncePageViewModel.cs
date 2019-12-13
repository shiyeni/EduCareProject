using EarlyEduCare.Models;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace EarlyEduCare.ViewModels
{
    public class PronouncePageViewModel : ViewModelBase
    {

        private string _definition;
        public string Definition
        {
            get { return _definition; }
            set { SetProperty(ref _definition, value); }
        }

        private string _word;
        public string Word
        {
            get { return _word; }
            set { SetProperty(ref _word, value); }
        }
        private DelegateCommand _testTwoCommand;
        public DelegateCommand TestTwoCommand =>
            _testTwoCommand ?? (_testTwoCommand = new DelegateCommand(ExecuteTestTwoCommand));

        private string[] randomWords = { "cat", "jump", "Shop", "plan", "test", "pull", "run" };


        private async void ExecuteTestTwoCommand()
        {
            Random rnd = new Random();
            int index = rnd.Next(1, 7);
            var wordAtIndex = randomWords[index];
            var client = new HttpClient();
            var combo = await client.GetStringAsync($"https://api.datamuse.com/words?sp={wordAtIndex}&md=d&max=2");
            var toParse = combo.Substring(1, combo.Length - 2);
            var parsedJson = JsonConvert.DeserializeObject<WordAndDefinition>(toParse);

            //if (combo.Contains(email) && combo.Contains(pass))
            //{ 
            //}
                    var word = parsedJson.word;
            var def = parsedJson.defs[1];
            var defToDisplay = def.Substring(3, def.Length - 3);

            Word = word;
            Definition = defToDisplay;
        }

        public PronouncePageViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

    }
}
