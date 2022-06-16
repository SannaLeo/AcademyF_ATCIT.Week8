using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AcademyF_ATCIT.Week8.Day2Demo.Commands
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private Action<object?> _executeMethod;
        private Predicate<object?> _canExecute;

        public bool CanExecute(object? parameter)
        {
            return _canExecute == null ? true : _canExecute.Invoke(parameter);
        }

        public void Execute(object? parameter)
        {
            _executeMethod?.Invoke(parameter);
        }
    }
}
