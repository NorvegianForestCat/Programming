using System.Collections.ObjectModel;
using System.IO;
using Newtonsoft.Json;

namespace View.Model.Services
{
    /// <summary>
    /// Serializes the Contact class.
    /// </summary>
    public class ContactSerializer
    {
        /// <summary>
        /// The path in the data folder.
        /// </summary>
        private string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) 
            + @"\Contacts";

        /// <summary>
        /// The name of the data file.
        /// </summary>
        private string _file = @"\contacts.json";

        /// <summary>
        /// Method for saving contacts.
        /// </summary>
        /// <param name="contacts">Saved contacts</param>
        public void SaveContacts(ObservableCollection<Contact> contacts)
        {
            string jsonContacts = JsonConvert.SerializeObject(contacts);
            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }

            using(StreamWriter streamWriter = new StreamWriter(_path + _file))
            {
                streamWriter.WriteLine(jsonContacts);
            }
        }

        /// <summary>
        /// Method for downloading contacts from a file.
        /// </summary>
        /// <returns>Downloaded contacts</returns>
        public ObservableCollection<Contact> LoadContact()
        {
            string readContacts = String.Empty;
         
            using(StreamReader streamReader = new StreamReader(_path + _file))
            {
                readContacts = streamReader.ReadLine();
            }
            
            ObservableCollection<Contact> contacts = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(readContacts);
            return contacts;
        }
    }
}