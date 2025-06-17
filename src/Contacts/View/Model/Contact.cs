using System;
using System.ComponentModel;

namespace View.Model
{
    /// <summary>
    /// Хранит информацию о контакте.
    /// </summary>
    public class Contact : INotifyPropertyChanged, IDataErrorInfo
    {
        /// <summary>
        /// ФИО контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private string _phone;

        /// <summary>
        /// Почта контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Возвращает и задаёт ФИО контакта. Не может быть длиннее 100 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона контакта. Не может быть длиннее 100 символов.
        /// </summary>
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        /// <summary>
        /// Возвращает и задаёт почту контакта. Не может быть длиннее 100 символов.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Получение ошибки.
        /// </summary>
        /// <param name="columnName">Свойство, в котором возникла ошибка</param>
        /// <returns>Текст ошибки.</returns>
        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case nameof(Name):
                        if (string.IsNullOrEmpty(Name) || Name.Length > 100)
                        {
                            error = "Name length must be > 0 and <= 100";
                        }
                        break;
                    case nameof(Phone):
                        if (string.IsNullOrEmpty(Phone) || Phone.Length > 100)
                        {
                            error = "Phone can contains only digits and symbols '+()- '. Example: 7 (999) 111-22-33";
                        }
                        break;
                    case nameof(Email):
                        if (string.IsNullOrEmpty(Email) || Email.Length > 100 || !Email.Contains("@"))
                        {
                            error = "Name length must be > 0, <= 100 and contains the symbol '@'";
                        }
                        break;
                }
                return error;
            }
        }

        /// <summary>
        /// Полученная ошибка.
        /// </summary>
        public string Error =>  this[nameof(Name)] + this[nameof(Phone)] + this[nameof(Email)];

        /// <summary>
        /// Событие, срабатывающее при изменении данных.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">ФИО контакта. Не может быть длиннее 100 символов.</param>
        /// <param name="phone">Номер телефона контакта. Не может быть длиннее 100 символов.</param>
        /// <param name="email">Email контакта. Не может быть длиннее 100 символов.</param>
        public Contact(string name = "Смирнов Юрий", string phone = "+7-913-111-22-33", string email = "yuri.smirnov@no.mail")
        {
            Name = name;
            Phone = phone;
            Email = email;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Извещает систему об изменении свойства. 
        /// </summary>
        /// <param name="prop">Свойство</param>
        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}