using System;
using System.Windows.Input;

namespace JpkEdytor.Framework
{
    public class RelayCommand<T> : ICommand
    {
        protected readonly Action<T> execute = null;
        protected readonly Predicate<T> canExecute = null;

        public RelayCommand(Action<T> execute)
            : this(execute, null)
        {
        }

        public RelayCommand(Action<T> execute, Predicate<T> canExecute)
        {
            this.execute = execute ?? throw new ArgumentNullException("execute");
            this.canExecute = canExecute;
        }

        public virtual bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute((T)parameter);
        }

        public virtual event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public virtual void Execute(object parameter)
        {
            execute((T)parameter);
        }
    }

    public class RelayCommand : RelayCommand<object>
    {
        public RelayCommand(Action<object> execute)
            : base(execute, null)
        {
        }

        public RelayCommand(Action<object> execute, Predicate<object> canExecute) 
            : base(execute, canExecute)
        {
        }
    }
}
