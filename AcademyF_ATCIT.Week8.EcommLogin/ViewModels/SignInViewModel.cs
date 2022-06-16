using AcademyF_ATCIT.Week8.Core;
using AcademyF_ATCIT.Week8.Core.BusinessLayer;
using AcademyF_ATCIT.Week8.EcommLogin.Messages;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AcademyF_ATCIT.Week8.EcommLogin.ViewModels
{
    public class SignInViewModel : ViewModelBase
    {
        private string _username;
        private string _password;
        private bool _isBusy = false;
        private IBusinessLayer BL;

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                RaisePropertyChanged();
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged();
            }
        }

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                RaisePropertyChanged();
            }
        }

        public ICommand LoginCommand { get; set; }


        public SignInViewModel()
        {
            LoginCommand = new RelayCommand(ExecuteLogin, CanExecuteLogin);
            Username = "Iserisci qui il tuo username";
            Password = "Password";
            BL = DependencyContainer.Resolve<IBusinessLayer>();
        }


        private bool CanExecuteLogin()
        {
            return
                !string.IsNullOrWhiteSpace(Username) &&
                !string.IsNullOrWhiteSpace(Password) &&
                !IsBusy;
        }

        private void ExecuteLogin()
        {
            IsBusy = !IsBusy;
            var user = BL.GetUserbyUsername(Username);
            DialogMessage dialog = new DialogMessage { Content = $"Sto effettuando il login per {Username}" };
            DialogMessage dialog2 = new DialogMessage { Content = "Non esiste un utente con quel username!" };
            if (user != null && user.Password == Password)
            {
                Messenger.Default.Send(dialog);
                IsBusy = !IsBusy;
                var showHomeMessage = new ShowViewMessage
                {
                    ViewName = "HomeView"
                };
                Messenger.Default.Send(showHomeMessage);
            }
            else
            {
                Messenger.Default.Send(dialog2);
                IsBusy = !IsBusy;
            }
        }

    }
}
