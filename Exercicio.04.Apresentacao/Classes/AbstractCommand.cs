using System;
using System.Windows.Input;

namespace Exercicio.Quatro.Apresentacao.Classes
{
    public abstract class AbstractCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;
        public void RaizeCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        public abstract void Execute(object parameter);
    }
}