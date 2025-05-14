using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace View.ModelView
{
    /// <summary>
    /// Command delegates actions to view
    /// </summary>
    class DelegateCommand : ICommand
    {
        /// <summary>
        /// Method calls action function.
        /// </summary>
        private Action<object> execute;

        /// <summary>
        /// Method calls executationability of command.
        /// </summary>
        private Func<object, bool> canExecute;

        /// <summary>
        /// Dispatching the command call.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Instance of <see cref="DelegateCommand"/> command.
        /// </summary>
        public DelegateCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        /// <summary>
        /// Can command execute in current state.
        /// </summary>
        /// <param name="parameter">Parameters of command.</param>
        /// <returns>true if command executable else false.</returns>
        public bool CanExecute(object parameter )
        {
            return canExecute == null || canExecute(parameter);
        }

        /// <summary>
        /// Delegate the action method.
        /// </summary>
        /// <param name="parameter">Command parameters.</param>
        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
