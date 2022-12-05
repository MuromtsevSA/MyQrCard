using Microsoft.Maui.Controls;
using MyQrCard.View;
using System.Data;
using System.Windows.Input;

namespace MyQrCard.ViewModel
{
    class MainPageViewModel : ViewModelBase
    {
        private string _email;

        public ICommand NextPageCommand { get; set; }
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }
        
        public MainPageViewModel()
        {
            NextPageCommand = new Command(NextPage);
        }

        public async void NextPage()
        {
            if(_email != string.Empty)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new EmailPage(_email), true);
            }
        }
    }
}
