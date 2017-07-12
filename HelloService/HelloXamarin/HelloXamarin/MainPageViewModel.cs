using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace HelloXamarin
{
    public class MainPageViewModel
    {
        public ObservableCollection<string> Values { get; } = new ObservableCollection<string>();

        public Command GetAllCommand { get; }

        public MainPageViewModel()
        {
            GetAllCommand = new Command(GetAll);
        }

        private async void GetAll()
        {
            var helloApiService =
                new HelloApiService(
                    new Uri("http://helloapiservice.azurewebsites.net"),
                    new AnonymousServiceClientCredentials());
            var values = await helloApiService.GetAllAsync();
            foreach (var value in values)
            {
                Values.Add(value);
            }
        }
    }
}
