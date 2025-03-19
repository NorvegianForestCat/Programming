using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ModelView
{
    class LoadCommand : ICommand
    {
        private ContactSerializer _serializer { get; set; }
        private MainVM _mainVM { get; set; }

        public event EventHandler? CanExecuteChanged;

        public LoadCommand(MainVM viewmodel)
        {
            _mainVM = viewmodel;
            _serializer = new ContactSerializer();
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            Contact loadedContact = _serializer.ContactLoad();

            if (loadedContact != null)
            {
                _mainVM.Email = loadedContact.Email;
                _mainVM.PhoneNumber = loadedContact.PhoneNumber;
                _mainVM.Name = loadedContact.Name;
            }
        }
    }
}
