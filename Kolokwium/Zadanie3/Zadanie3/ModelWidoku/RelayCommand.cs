
using System;
using System.Windows.Input;

public class RelayCommand : ICommand
{
    readonly Func<object, bool> canExecute;
    readonly Action<object> execute;

    public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
    {
        if (execute == null) throw new ArgumentException("Parametr 'execute' nie może być pusty (null)");
        this.execute = execute;
        this.canExecute = canExecute;
    }

    public bool CanExecute(object parameter)
    {
        return (canExecute == null) ? true : canExecute(parameter);
    }

    public event EventHandler CanExecuteChanged
    {
        add
        {
            if (canExecute != null) CommandManager.RequerySuggested += value;
        }
        remove
        {
            if (canExecute != null) CommandManager.RequerySuggested -= value;
        }
    }

    public void Execute(object parameter)
    {
        execute(parameter);
    }
}