using System.ComponentModel;

namespace View.Model
{
    /// <summary>
    /// Stores information about the contact.
    /// </summary>
    public class Contact : INotifyPropertyChanged
    {
        /// <summary>
        /// Full name of the contact.
        /// </summary>
        private string _name;

        /// <summary>
        /// The contact's phone number.
        /// </summary>
        private string _phone;
        /// <summary>
        /// Contact's email address.
        /// </summary>
        private string _email;
        
        /// <summary>
        /// Returns and sets the contact's full name. It cannot be longer than 100 characters.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 100 || value == null)
                {
                    throw new ArgumentException();
                }
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Returns and sets the contact's phone number. It cannot be longer than 100 characters.
        /// </summary>
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                if (value.Length > 100 || value == null)
                {
                    throw new ArgumentException();
                }
                _phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        /// <summary>
        /// Returns and sets the contact's email address. It cannot be longer than 100 characters.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Length > 100 || value == null)
                {
                    throw new ArgumentException();
                }
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Event triggered when data is changed.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Creates an instance of the <see cref="Contact"/> class.
        /// </summary>
        /// <param name="name">Contact's full name. It cannot be longer than 100 characters.</param>
        /// <param name="phone">The contact's phone number. It cannot be longer than 100 characters.</param>
        /// <param name="email">Contact's email address. It cannot be longer than 100 characters.</param>
        public Contact(string name = "Name Surname", string phone = "+0123456789", string email = "mail@no.mail")
        {
            Name = name;
            Phone = phone;
            Email = email;
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public Contact() { }

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