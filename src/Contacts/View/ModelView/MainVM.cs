using System.ComponentModel;
using View.Model;

namespace View.ModelView
{
    /// <summary>
    /// ViewModel between main window and Model.
    /// </summary>
    class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Contact object.
        /// Gets and sets object of class <see cref="View.Model.Contact"/>.
        /// </summary>
        public Contact Contact { get; set; }
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
                }
            }
        }

        /// <summary>
        /// Changing property value event.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Initializing <see cref="MainVM"/> object without parameters.
        /// </summary>
        public MainVM()
        {
            Contact = new Contact();
        }
    }
}
