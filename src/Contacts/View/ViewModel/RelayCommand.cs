using System;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Implements a command execution class.
    /// </summary>
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// Defines the method to be called when this command is invoked.
        /// </summary>
        private Action<object> execute;

        /// <summary>
        /// Determines whether the command can be executed in the current state.
        /// </summary>
        private Func<object, bool> canExecute;

        /// <summary>
        /// Occurs when the command manager detects a change in the command source.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Creates an instance of the <see cref="RelayCommand"/> class.
        /// </summary>
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        /// <summary>
        /// Determines whether the command can be executed in the current state.
        /// </summary>
        /// <param name="parameter">The data used by this command.</param>
        /// <returns>true</returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Defines the method to be called when calling this command.
        /// </summary>
        /// <param name="parameter">The data used by this command.</param>
        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}