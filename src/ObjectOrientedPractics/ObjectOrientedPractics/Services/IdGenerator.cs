using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Static service class generating ID values
    /// </summary>
    internal static class IdGenerator
    {
        /// <summary>
        /// Class fields
        /// </summary>
        private static int _idCounter;

        /// <summary>
        /// Property IdCounter. Gets and returns ints.
        /// </summary>
        private static int IdCounter { get; set; }

        /// <summary>
        /// Method generating inline IDs
        /// </summary>
        /// <returns>ID</returns>
        public static int GetNextId()
        {
            return IdCounter++;
        }
    }
}
