using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AcademyF_ATCIT.Week8.Day2Demo.ViewModels.SignIn
{
    public class SignInViewModel : ViewModelBase
    {
        private string _username;
        private string _messaggio = "";
        private string _password;
        private bool _isbusy = false;

        

        public string Username 
        { 
            get 
            { 
                return _username;
            } 
            set { 
                _username = value; 
                RaisePropertyChanged();
            } 
        }


        public string Password 
        { 
            get 
            { 
                return _password; 
            } 
            set 
            { _password = value; 
                RaisePropertyChanged();
            } 
        }

        public string Messaggio 
        { 
            get 
            { return _messaggio; 
            } 
            set 
            { _messaggio = value; 
                RaisePropertyChanged();
            } 
        }
        public bool IsBusy
        {
            get { return _isbusy; }
            set { _isbusy = value; RaisePropertyChanged(); }
        }

        public ICommand LoginCommand { get; set; }

        public SignInViewModel()
        {
            Username = "Inserisci lo username";
            Password = "Inserisci la password";
            LoginCommand = new RelayCommand(ExecuteLogin, CanExecuteLogin);   
        }

        private bool CanExecuteLogin()
        {
            return !string.IsNullOrEmpty(_username) && !string.IsNullOrEmpty(_password) && !IsBusy;
        }

        private void ExecuteLogin()
        {
            MessageBox.Show("Sto effettuando il login per " + $"{Username}");
        }
    }
}
