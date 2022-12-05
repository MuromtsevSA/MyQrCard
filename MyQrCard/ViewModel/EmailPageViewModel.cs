using MyQrCard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyQrCard.ViewModel
{
    class EmailPageViewModel : ViewModelBase
    {
        private string _phone;
        private string _fio;
        private string _email;

        public INavigation Navigation { get; set; }
        public ICommand SendEmailCommand { protected set; get; }
        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                OnPropertyChanged("Phone");
            }
        }

        public string FIO
        {
            get { return _fio; }
            set
            {
                _fio = value;
                OnPropertyChanged("FIO");
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }
        public EmailPageViewModel(string email)
        {
            _email = email;
            SendEmailCommand = new Command(SendEmail);
        }

        public async void SendEmail()
        {
            if (_email != string.Empty && _fio != string.Empty && _fio != string.Empty)
            {
                Send.SendEmail(_email, _fio, _phone);
                await Application.Current.MainPage.Navigation.PopToRootAsync();
            }
            
        }
    }
}
