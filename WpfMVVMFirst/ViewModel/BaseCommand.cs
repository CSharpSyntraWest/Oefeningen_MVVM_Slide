using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfMVVMFirst.ViewModel
{
    class BaseCommand : ICommand
    {
        Action _actie;
        public BaseCommand(Action actie)
        {
            _actie = actie;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _actie.Invoke();
        }
    }
}
