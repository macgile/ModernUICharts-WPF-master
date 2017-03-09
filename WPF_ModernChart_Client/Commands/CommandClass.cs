using System;
using System.Windows.Input;

namespace WPF_ModernChart_Client.Commands
{
    public class RelayCommand : ICommand
    {
        Action handler;

        public RelayCommand(Action h)
        {
            handler =  h;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            handler();
        }
    }
}
