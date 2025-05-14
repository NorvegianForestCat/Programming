using System.IO;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace View.Model.Services
{
    /// <summary>
    /// Service class for serializing contact data.
    /// </summary>
    /// <remarks>
    /// Class has methods for saving and loading data from MyDocuments/Contacts/contacts.json file.
    /// </remarks>
    class ContactSerializer
    {
        /// <summary>
        /// Path to json directory.
        /// </summary>
        private string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            + @"\Contacts";
        /// <summary>
        /// Name of json file.
        /// </summary>
        private string _jsonFile = @"\contacts.json";

        /// <summary>
        /// Serialization of <see cref="View.Model.Contact"/> objects into JSON-object.
        /// </summary>
        /// <param name="contacts">
        /// <see cref="View.Model.Contact"/> object.
        /// </param>
        public void ContactsSave(ObservableCollection<Contact> contacts)
        {
            string jsonContacts = JsonConvert.SerializeObject(contacts);

            if(!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }

            using (StreamWriter writer = new StreamWriter(_path + _jsonFile))
            {
                writer.WriteLine(jsonContacts);
            }
        }

        /// <summary>
        /// Deserialization of <see cref="View.Model.Contact"/> objects onto JSON-object.
        /// </summary>
        /// <returns>
        /// Deserialized <see cref="View.Model.Contact"/> object.
        /// </returns>
        public ObservableCollection<Contact> ContactsLoad()
        {
            string jsonContacts = string.Empty;

            using (StreamReader reader = new StreamReader(_path + _jsonFile))
            {
                jsonContacts = reader.ReadLine() ?? string.Empty;
            }

            ObservableCollection<Contact> contacts = 
                JsonConvert.DeserializeObject<ObservableCollection<Contact>>(jsonContacts) 
                ?? new ObservableCollection<Contact>();

            return contacts;
        }
    }
}
