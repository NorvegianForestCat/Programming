using System.IO;
using Newtonsoft.Json;

namespace View.Model.Services
{
    /// <summary>
    /// Service class for serializing contact data.
    /// </summary>
    class ContactSerializer
    {
        /// <summary>
        /// Path to json directory.
        /// </summary>
        private string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Contacts";
        /// <summary>
        /// Name of json file.
        /// </summary>
        private string _jsonFile = @"\contacts.json";

        /// <summary>
        /// Serialization of <see cref="View.Model.Contact"/> object into JSON-object.
        /// </summary>
        /// <param name="contact">
        /// <see cref="View.Model.Contact"/> object.
        /// </param>
        public void ContactSave(Contact contact)
        {
            string jsonContact = JsonConvert.SerializeObject(contact);

            if(!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }

            using (StreamWriter writer = new StreamWriter(_path + _jsonFile))
            {
                writer.WriteLine(jsonContact);
            }
        }

        /// <summary>
        /// Deserialization of <see cref="View.Model.Contact"/> object onto JSON-object.
        /// </summary>
        /// <returns>Deserialized <see cref="View.Model.Contact"/> object.</returns>
        public Contact ContactLoad()
        {
            string jsonContact = string.Empty;

            using (StreamReader reader = new StreamReader(_path + _jsonFile))
            {
                jsonContact = reader.ReadLine();
            }

            Contact contact = JsonConvert.DeserializeObject<Contact>(jsonContact) ?? new Contact();

            return contact;
        }
    }
}
