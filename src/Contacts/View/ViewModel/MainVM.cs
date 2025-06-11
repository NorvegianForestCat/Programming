using System.Collections.ObjectModel;
using System.ComponentModel;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Implements a representation model.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// The command to save a contact.
        /// </summary>
        private RelayCommand _saveCommand;
        /// <summary>
        /// The contact upload command.
        /// </summary>
        private RelayCommand _loadCommand;
        /// <summary>
        /// The command to add a contact.
        /// </summary>
        private RelayCommand _addCommand;
        /// <summary>
        /// Contact editing command.
        /// </summary>
        private RelayCommand _editCommand;
        /// <summary>
        /// The contact deletion command.
        /// </summary>
        private RelayCommand _removeCommand;
        /// <summary>
        /// The command to apply changes.
        /// </summary>
        private RelayCommand _applyCommand;
        /// <summary>
        /// The undo command.
        /// </summary>
        private RelayCommand _cancelCommand;
        /// <summary>
        /// Current contact.
        /// </summary>
        private Contact _currentContact;
        /// <summary>
        /// The contact being edited.
        /// </summary>
        private Contact _editContact;

        /// <summary>
        /// Returns and sets the contact list.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; set; }

        /// <summary>
        /// Returns and sets the contract serializer.
        /// </summary>
        public ContactSerializer ContactSerializer { get; set; }

        /// <summary>
        /// Returns and sets the current contact.
        /// </summary>
        public Contact CurrentContact
        {
            get
            {
                return _currentContact;
            }
            set
            {
                _currentContact = value;
                OnPropertyChanged(nameof(CurrentContact));
                OnPropertyChanged(nameof(IsEnabled));

                EditContact = null;
                OnPropertyChanged(nameof(Visibility));
                OnPropertyChanged(nameof(IsReadOnly));
                UpdateEditContact();
            }
        }

        /// <summary>
        /// Returns and sets the contact to be edited.
        /// </summary>
        public Contact EditContact
        {
            get
            {
                return _editContact;
            }
            set
            {
                _editContact = value;
                OnPropertyChanged(nameof(EditContact));
            }
        }

        /// <summary>
        /// The command to save a contact.
        /// </summary>
        public RelayCommand SaveCommand
        {
            get
            {
                return _saveCommand ?? (_saveCommand = new RelayCommand(obj =>
                {
                    ContactSerializer.SaveContacts(Contacts);
                }));
            }
        }

        /// <summary>
        /// The contact upload command.
        /// </summary>
        public RelayCommand LoadCommand
        {
            get
            {
                return _loadCommand ?? (_loadCommand = new RelayCommand(obj =>
                {
                    try
                    {
                        var loadedContacts = ContactSerializer.LoadContact();
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
        /// The command to add a contact.
        /// </summary>
        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand ?? (_addCommand = new RelayCommand(obj =>
                {
                    LoadCommand.Execute(Contacts);
                    EditContact = new Contact("", "", "");

                    OnPropertyChanged(nameof(IsReadOnly));
                    OnPropertyChanged(nameof(Visibility));
                }));
            }
        }

        /// <summary>
        /// Contact editing command.
        /// </summary>
        public RelayCommand EditCommand
        {
            get
            {
                return _editCommand ?? (_editCommand = new RelayCommand(obj =>
                {
                    OnPropertyChanged(nameof(IsReadOnly));
                    OnPropertyChanged(nameof(Visibility));
                }));
            }
        }

        /// <summary>
        /// The contact deletion command.
        /// </summary>
        public RelayCommand RemoveCommand
        {
            get
            {
                return _removeCommand ?? (_removeCommand = new RelayCommand(obj =>
                {
                    int index = Contacts.IndexOf(CurrentContact);
                    Contacts.Remove(CurrentContact);
                    SaveCommand.Execute(Contacts);
                    if (index < Contacts.Count)
                    {
                        CurrentContact = Contacts[index];
                    }
                    else if (Contacts.Count > 0)
                    {
                        CurrentContact = Contacts[Contacts.Count - 1];
                    }
                    else
                    {
                        CurrentContact = null;
                    }
                }));
            }
        }

        /// <summary>
        /// The command to apply changes.
        /// </summary>
        public RelayCommand ApplyCommand
        {
            get
            {
                return _applyCommand ?? (_applyCommand = new RelayCommand(obj =>
                {
                    if (IsEnabled)
                    {
                        CurrentContact.Name = EditContact.Name;
                        CurrentContact.Phone = EditContact.Phone;
                        CurrentContact.Email = EditContact.Email;
                        CurrentContact = CurrentContact;
                    }
                    else
                    {
                        Contacts.Add(EditContact);
                        CurrentContact = Contacts.Last();
                    }

                    SaveCommand.Execute(Contacts);
                }));
            }
        }

        /// <summary>
        /// The Undo command.
        /// </summary>
        public RelayCommand CancelCommand
        {
            get
            {
                return _cancelCommand ?? (_cancelCommand = new RelayCommand(obj =>
                {
                    CurrentContact = null;
                }));
            }
        }

        /// <summary>
        /// Returns whether it is read-only.
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return EditContact == null;
            }
        }

        /// <summary>
        /// Returns whether it is available.
        /// </summary>
        public bool IsEnabled
        {
            get
            {
                return CurrentContact != null;
            }
        }

        /// <summary>
        /// Returns visibility.
        /// </summary>
        public bool Visibility
        {
            get
            {
                return EditContact != null;
            }
        }

        /// <summary>
        /// Event triggered when data is changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Creates an instance of the <see cref="MainVM"/> class.
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<Contact>();
            ContactSerializer = new ContactSerializer();
            LoadCommand.Execute(Contacts);
            OnPropertyChanged(nameof(IsReadOnly));
        }

        /// <summary>
        /// Updates the contact being edited.
        /// </summary>
        public void UpdateEditContact()
        {
            if (CurrentContact != null)
            {
                EditContact = new Contact(CurrentContact.Name, CurrentContact.Phone, CurrentContact.Email);
            }
            else
            {
                EditContact = null;
            }
        }

        /// <summary>
        /// Notifies the system of a property change. 
        /// </summary>
        /// <param name="property">The</param> property
        public void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}