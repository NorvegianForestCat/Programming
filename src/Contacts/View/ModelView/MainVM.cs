using System.ComponentModel;
using View.Model;

namespace View.ModelView
{
    /*
    - предоставлять свойства Name, PhoneNumber и Email для привязки со стороны MainView; 
    - экземпляр контакта Contact, в котором должна храниться вся актуальная информация с пользовательского интерфейса. 
     */
    class MainVM : INotifyPropertyChanged
    {
        public Contact Contact { get; set; }
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

        public event PropertyChangedEventHandler PropertyChanged;

        public MainVM()
        {
            Contact = new Contact();
        }
    }
}
