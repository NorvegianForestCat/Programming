using System.ComponentModel;
using View.Model;

namespace View.ModelView
{
    /// <summary>
    /// ViewModel between main window and Model.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// <see cref="ModelView.SaveCommand"/> object.
        /// </summary>
        private SaveCommand? _saveCommand;

        /// <summary>
        /// <see cref="ModelView.LoadCommand"/> object.
        /// </summary>
        private LoadCommand? _loadCommand;

        /// <summary>
        /// Contact object.
        /// Gets and sets object of class <see cref="View.Model.Contact"/>.
        /// </summary>
        public Contact Contact { get; set; }

        /// <summary>
        /// Save Command Property.
        /// Gets <see cref="ModelView.SaveCommand"/> command object.
        /// </summary>
        public SaveCommand SaveCommand
        {
            get
            {
                return _saveCommand ?? (_saveCommand = new SaveCommand(Contact));
            }
        }

        /// <summary>
        /// Save Command Property.
        /// Gets <see cref="ModelView.LoadCommand"/> command object.
        /// </summary>
        public LoadCommand LoadCommand
        {
            get
            {
                return _loadCommand ?? (_loadCommand = new LoadCommand(this));
            }
        }

        /// <summary>
        /// Contact name.
        /// Gets and sets object's name of class <see cref="View.Model.Contact"/>
        /// as a string.
        /// </summary>
        public string Name
        {
            get => Contact.Name;
            set
            {
                if (value != null)
                {
                    Contact.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        /// <summary>
        /// Contact phone number.
        /// Gets and sets object's phone number of class 
        /// <see cref="View.Model.Contact"/> as a string.
        /// </summary>
        public string PhoneNumber
        {
            get => Contact.PhoneNumber;
            set
            {
                if (value != null)
                {
                    Contact.PhoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
            }
        }

        /// <summary>
        /// Contact email.
        /// Gets and sets object's email of class <see cref="View.Model.Contact"/>
        /// as a string.
        /// </summary>
        public string Email
        {
            get => Contact.Email;
            set
            {
                if (value != null)
                {
                    Contact.Email = value;
                    OnPropertyChanged(nameof(Email));
                }
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
            Contact = new Contact();
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
