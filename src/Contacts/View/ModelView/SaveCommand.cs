using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ModelView
{
    class SaveCommand : ICommand
    {
        private Contact _contact { get; set; }

        private ContactSerializer _serializer { get; set; }

        public event EventHandler? CanExecuteChanged;

        public SaveCommand(Contact contact)
        {
            _serializer = new ContactSerializer();
            _contact = contact;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _serializer.ContactSave(_contact);
        }
    }
}
