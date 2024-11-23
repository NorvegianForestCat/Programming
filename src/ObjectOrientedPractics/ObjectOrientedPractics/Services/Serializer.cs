using ObjectOrientedPractics.Model;
using Newtonsoft.Json;
using System.IO;
using System;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Class provides serialize functions
    /// </summary>
    public class Serializer
    {
        /// <summary>
        /// File path
        /// </summary>
        private static string FilePath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"ObjectOrientedPractics\\Serialization.json");

        /// <summary>
        /// Gets and sets json
        /// </summary>
        private static string StoreJson { get; set; } = string.Empty;

        /// <summary>
        /// Serialize files
        /// </summary>
        static Serializer()
        {

            Directory.CreateDirectory(Path.GetDirectoryName(FilePath));
            try
            {
                StoreJson = File.ReadAllText(FilePath);
            }
            catch
            {
                StoreJson = string.Empty;
            }
        }

        /// <summary>
        /// Deserialize store data
        /// </summary>
        /// <returns>Deserialized store data</returns>
        public static Store GetStore()
        {
            if (StoreJson == string.Empty)
            {
                return new Store();
            }
            else
            {
                return JsonConvert.DeserializeObject<Store>(StoreJson);
            }
        }

        /// <summary>
        /// Serialize store data
        /// </summary>
        /// <param name="store">Serializing store</param>
        public static void SetStore(Store store)
        {
            StoreJson = JsonConvert.SerializeObject(store);
            SaveFile();
        }

        /// <summary>
        /// Save json
        /// </summary>
        private static void SaveFile()
        {
            File.WriteAllText(FilePath, StoreJson);
        }
    }
}
