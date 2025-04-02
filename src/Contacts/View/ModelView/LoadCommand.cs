using System.Windows.Input;
using View.Model;
using View.Model.Services;
using static System.Net.WebRequestMethods;

namespace View.ModelView
{
    /// <summary>
    /// Load data from file command.
    /// </summary>
    /// <remarks>
    /// It is implementation of <seealso href="https://en.wikipedia.org/wiki/Command_pattern">Command</seealso> Pattern.
    /// </remarks>
    public class LoadCommand : ICommand
    {
        /// <summary>
        /// <see cref="Model.Services.ContactSerializer"/> object.
        /// </summary>
        private ContactSerializer _serializer { get; set; }

        /// <summary>
        /// <see cref="ModelView.MainVM"/> ViewModel object.
        /// </summary>
        /// <remarks>
        /// It is part of <seealso href="https://learn.microsoft.com/en-us/dotnet/architecture/maui/mvvm">MVVM</seealso>
        /// architectural pattern.
        /// </remarks>
        private MainVM _mainVM { get; set; }

        /// <summary>
        /// Command execution event.
        /// </summary>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Initialize new <see cref="LoadCommand"/> instance.
        /// </summary>
        /// <param name="mainVM">
        /// <see cref="ModelView.MainVM">ViewModel</see> object.
        /// </param>
        public LoadCommand(MainVM mainVM)
        {
            _mainVM = mainVM;
            _serializer = new ContactSerializer();
        }

        /// <summary>
        /// Determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">Data used by the command.</param>
        /// <returns>
        /// <code>true</code> if this command can be executed; 
        /// otherwise, <code>false</code>.
        /// </returns>
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        /// <summary>
        /// Definition of method to be called when the command <see cref="LoadCommand"/>
        /// is invoked.
        /// </summary>
        /// <param name="parameter">Data used by the command.</param>
        public void Execute(object? parameter)
        {
            Contact loadedContact = _serializer.ContactLoad();

            if(loadedContact != null)
            {
                _mainVM.Email = loadedContact.Email;
                _mainVM.PhoneNumber = loadedContact.PhoneNumber;
                _mainVM.Name = loadedContact.Name;
            }
        }
    }
}
