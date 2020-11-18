using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ToDo
{
    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public Action<object> _action { get; set; }
        public Command(Action<object> action)
        {
            _action = action;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action(parameter);
        }
    }
}
