using System.Collections.ObjectModel;
using View.Model;
using View.Model.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Реализует модель представления.
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Текущий контакт.
        /// </summary>
        [ObservableProperty]
        private Contact _currentContact;
        /// <summary>
        /// Редактируемый контакт.
        /// </summary>
        [ObservableProperty]
        private Contact _editContact;
        
        /// <summary>
        /// Команда сохранения контакта.
        /// </summary>
        public RelayCommand SaveCommand;
        /// <summary>
        /// Команда загрузки контакта.
        /// </summary>
        public RelayCommand LoadCommand { get; }
        /// <summary>
        /// Команда добавления контакта.
        /// </summary>
        public RelayCommand AddCommand { get; }
        /// <summary>
        /// Команда редактирования контакта.
        /// </summary>
        public RelayCommand EditCommand { get; }
        /// <summary>
        /// Команда удаления контакта.
        /// </summary>
        public RelayCommand RemoveCommand { get; }
        /// <summary>
        /// Команда применения изменений.
        /// </summary>
        public RelayCommand ApplyCommand { get; }
        /// <summary>
        /// Команда отмены изменений.
        /// </summary>
        public RelayCommand CancelCommand { get; }
        /// <summary>
        /// Возвращает и задаёт список контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; }
        /// <summary>
        /// Возвращает и задаёт сериализатор контакта.
        /// </summary>
        public ContactSerializer ContactSerializer { get; }

        /// <summary>
        /// Возвращает, только ли на чтение.
        /// </summary>
        public bool IsReadOnly => EditContact == null;
        /// <summary>
        /// Возвращает, доступно ли.
        /// </summary>
        public bool IsEnabled => CurrentContact != null;
        /// <summary>
        /// Возвращает, доступно ли применение.
        /// </summary>
        public bool ApplyIsEnabled => EditContact != null && string.IsNullOrWhiteSpace(EditContact.Error);
        /// <summary>
        /// Возвращает видимость.
        /// </summary>
        public bool ApplyIsVisible => EditContact != null;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<Contact>();
            ContactSerializer = new ContactSerializer();
            SaveCommand = new RelayCommand(Save);
            LoadCommand = new RelayCommand(Load);
            AddCommand = new RelayCommand(Add);
            EditCommand = new RelayCommand(Edit);
            RemoveCommand = new RelayCommand(Remove);
            ApplyCommand = new RelayCommand(Apply);
            CancelCommand = new RelayCommand(Cancel);

            //LoadCommand.Execute(Contacts);
            //OnPropertyChanged(nameof(IsReadOnly));
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

        private void Save() => ContactSerializer.SaveContacts(Contacts);
        private void Load()
        {
            try
            {
                ObservableCollection<Contact> loadedContacts = ContactSerializer.LoadContact();
                if (loadedContacts != null)
                {
                    Contacts.Clear();
                    foreach (Contact contact in loadedContacts)
                    {
                        Contacts.Add(contact);
                    }
                }
            }
            catch
            {
                Contacts.Clear();
            }
        }
        private void Add()
        {
            EditContact = new Contact("", "", "");
            Edit();
        }
        private void Edit()
        {
            OnPropertyChanged(nameof(IsReadOnly));
            OnPropertyChanged(nameof(ApplyIsVisible));
        }
        private void Remove()
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
        }
        private void Apply() 
        {
            if (IsEnabled)
            {
                CurrentContact.Name = EditContact.Name;
                CurrentContact.Phone = EditContact.Phone;
                CurrentContact.Email = EditContact.Email;

                Contact currentContact = CurrentContact;
                
                CurrentContact = null;
                CurrentContact = currentContact;
            }
            else
            {
                Contacts.Add(EditContact);
                CurrentContact = Contacts.Last();
            }

            SaveCommand.Execute(Contacts);
        }
        private void Cancel() 
        {
            CurrentContact = null;
        }

        partial void OnCurrentContactChanged(Contact value)
        {
            OnPropertyChanged(nameof(CurrentContact));
            OnPropertyChanged(nameof(IsEnabled));
            EditContact = null;
            OnPropertyChanged(nameof(ApplyIsVisible));
            OnPropertyChanged(nameof(IsReadOnly));
            UpdateEditContact();
        }
        partial void OnEditContactChanged(Contact value)
        {
            OnPropertyChanged(nameof(EditContact));
            OnPropertyChanged(nameof(ApplyIsEnabled));
            if (_editContact != null)
            {
                _editContact.PropertyChanged += EditContact_PropertyChanged;
            }
        }

        /// <summary>
        /// Вызов проверки, должна ли быть доступна кнопка Apply.
        /// </summary>
        private void EditContact_PropertyChanged(object sender, EventArgs e)
        {
            OnPropertyChanged(nameof(ApplyIsEnabled));
        }
    }
}