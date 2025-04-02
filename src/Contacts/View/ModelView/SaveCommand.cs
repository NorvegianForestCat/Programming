using System.Windows.Input;
using View.Model;
using View.Model.Services;
using static System.Net.WebRequestMethods;

namespace View.ModelView
{
    /// <summary>
    /// Save data from into command.
    /// </summary>
    /// <remarks>
    /// It is implementation of <seealso href="https://en.wikipedia.org/wiki/Command_pattern">Command</seealso> Pattern.
    /// </remarks>
    public class SaveCommand : ICommand
    {
        /// <summary>
        /// User contact private property.
        /// </summary>
        private Contact _contact { get; set; }

        /// <summary>
        /// <see cref="Model.Services.ContactSerializer"/> object.
        /// </summary>
        private ContactSerializer _serializer { get; set; }

        /// <summary>
        /// Command execution event.
        /// </summary>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Initialize new <see cref="SaveCommand"/> instance.
        /// </summary>
        /// <param name="contact">
        /// <see cref="Model.Contact">Contact</see> object.
        /// </param>
        public SaveCommand(Contact contact)
        {
            _serializer = new ContactSerializer();
            _contact = contact; 
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
        /// Definition of method to be called when the command <see cref="SaveCommand"/>
        /// is invoked.
        /// </summary>
        /// <param name="parameter">Data used by the command.</param>
        public void Execute(object? parameter)
        {
            _serializer.ContactSave(_contact);
        }
    }
}
