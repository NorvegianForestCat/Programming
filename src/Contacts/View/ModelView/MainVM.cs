using System.ComponentModel;
using System.Collections.ObjectModel;
using View.Model;
using View.Model.Services;

namespace View.ModelView
{
    /// <summary>
    /// ViewModel between main window and Model.
    /// </summary>
    class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// <see cref="ModelView.DelegateCommand"/> object for saving.
        /// </summary>
        private DelegateCommand? _saveCommand;
        /// <summary>
        /// <see cref="ModelView.DelegateCommand"/> object for loading.
        /// </summary>
        private DelegateCommand? _loadCommand;

        /// <summary>
        /// Contact objects collection.
        /// Gets and sets objects of class <see cref="View.Model.Contact"/>.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; set; }
        /// <summary>
        /// Gets and sets serializer.
        /// </summary>
        public ContactSerializer ContactSerializer { get; set; }
        /// <summary>
        /// Save Command Property.
        /// Gets <see cref="ModelView.DelegateCommand"/> command object for saving.
        /// </summary>
        public DelegateCommand SaveCommand
        {
            get
            {
                return _saveCommand ?? (_saveCommand = new DelegateCommand(obj =>
                {
                    ContactSerializer.ContactsSave(Contacts);
                }));
            }
        }
        /// <summary>
        /// Load Command Property.
        /// Gets <see cref="ModelView.DelegateCommand"/> command object for loading.
        /// </summary>
        public DelegateCommand LoadCommand
        {
            get
            {
                return _loadCommand ?? (_loadCommand = new DelegateCommand(obj =>
                {
                    try
                    {
                        var loadedContacts = ContactSerializer.ContactsLoad();
                        if (loadedContacts != null)
                        {
                            Contacts.Clear();
                            foreach (var contact in loadedContacts)
                            {
                                Contacts.Add(contact);
                            }
                        }
                    }
                    catch
                    {
                        Contacts.Clear();
                    }
                }));
            }
        }

        /// <summary>
        /// Changing property value event.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Initializing <see cref="MainVM"/> object without parameters.
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<Contact>();
            ContactSerializer = new ContactSerializer();
            LoadCommand.Execute(Contacts);
        }

        /// <summary>
        /// Change property event handler.
        /// </summary>
        /// <param name="property">Changed property name.</param>
        public void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
