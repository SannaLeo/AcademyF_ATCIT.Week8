using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AcademyF_ATCIT.Week8.WPF.AppBase.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private string _myProperty = "Testo di prova";
        public string MyProperty
        {
            get
            {
                return _myProperty;
            }
            set
            {
                _myProperty = value;
                NotifyPropertyChanged();
            }
        }

        private int _myProperty2;
        public int MyProperty2
        {
            get
            {
                return _myProperty2;
            }
            set
            {
                _myProperty2 = value;
            }
        }

        private bool _isChecked = true;
        public bool IsChecked
        {
            get { return _isChecked; }
            set
            {
                _isChecked = value;
                NotifyPropertyChanged();
            }
        }

        private DateTime _date = DateTime.Now;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; NotifyPropertyChanged(); }
        }
    }
}
