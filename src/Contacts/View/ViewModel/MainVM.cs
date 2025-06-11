using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Реализует модель представления.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Команда сохранения контакта.
        /// </summary>
        private RelayCommand _saveCommand;
        /// <summary>
        /// Команда загрузки контакта.
        /// </summary>
        private RelayCommand _loadCommand;
        /// <summary>
        /// Команда добавления контакта.
        /// </summary>
        private RelayCommand _addCommand;
        /// <summary>
        /// Команда редактирования контакта.
        /// </summary>
        private RelayCommand _editCommand;
        /// <summary>
        /// Команда удаления контакта.
        /// </summary>
        private RelayCommand _removeCommand;
        /// <summary>
        /// Команда применения изменений.
        /// </summary>
        private RelayCommand _applyCommand;
        /// <summary>
        /// Команда отмены изменений.
        /// </summary>
        private RelayCommand _cancelCommand;
        /// <summary>
        /// Текущий контакт.
        /// </summary>
        private Contact _currentContact;
        /// <summary>
        /// Редактируемый контакт.
        /// </summary>
        private Contact _editContact;
        
        /// <summary>
        /// Возвращает и задаёт список контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; set; }
        /// <summary>
        /// Возвращает и задаёт сериализатор контакта.
        /// </summary>
        public ContactSerializer ContactSerializer { get; set; }

        /// <summary>
        /// Возвращает и задаёт текущий контакт.
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
                OnPropertyChanged(nameof(ApplyIsVisible));
                OnPropertyChanged(nameof(IsReadOnly));
                UpdateEditContact();
            }
        }
        /// <summary>
        /// Возвращает и задаёт редактируемый контакт.
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
                OnPropertyChanged(nameof(ApplyIsEnabled));

                if (_editContact != null)
                {
                    _editContact.PropertyChanged += EditContact_PropertyChanged;
                }
            }
        }

        /// <summary>
        /// Команда сохранения контакта.
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
        /// Команда загрузки контакта.
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
        /// Команда добавления контакта.
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
                    OnPropertyChanged(nameof(ApplyIsVisible));
                }));
            }
        }
        /// <summary>
        /// Команда редактирования контакта.
        /// </summary>
        public RelayCommand EditCommand
        {
            get
            {
                return _editCommand ?? (_editCommand = new RelayCommand(obj =>
                {
                    OnPropertyChanged(nameof(IsReadOnly));
                    OnPropertyChanged(nameof(ApplyIsVisible));
                }));
            }
        }
        /// <summary>
        /// Команда удаления контакта.
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
        /// Команда применения изменений.
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
        /// Команда отмены изменений.
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
        /// Возвращает, только ли на чтение.
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return EditContact == null;
            }
        }
        /// <summary>
        /// Возвращает, доступно ли.
        /// </summary>
        public bool IsEnabled
        {
            get
            {
                return CurrentContact != null;
            }
        }
        /// <summary>
        /// Возвращает, доступно ли применение.
        /// </summary>
        public bool ApplyIsEnabled
        {
            get
            {
                return EditContact != null && string.IsNullOrWhiteSpace(EditContact.Error);
            }
        }
        /// <summary>
        /// Возвращает видимость.
        /// </summary>
        public bool ApplyIsVisible
        {
            get
            {
                return EditContact != null;
            }
        }

        /// <summary>
        /// Событие, срабатывающее при изменении данных.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<Contact>();
            ContactSerializer = new ContactSerializer();
            LoadCommand.Execute(Contacts);
            OnPropertyChanged(nameof(IsReadOnly));
        }

        /// <summary>
        /// Обновляет редактируемый контакт.
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
        /// Вызов проверки, должна ли быть доступна кнопка Apply.
        /// </summary>
        private void EditContact_PropertyChanged(object sender, EventArgs e)
        {
            OnPropertyChanged(nameof(ApplyIsEnabled));
        }

        /// <summary>
        /// Извещает систему об изменении свойства. 
        /// </summary>
        /// <param name="property">Свойство</param>
        public void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}