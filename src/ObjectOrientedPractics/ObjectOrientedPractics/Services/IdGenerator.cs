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
        /// Gets and sets busy ids list
        /// </summary>
        public static List<int> BusyIds { get; set; }

        /// <summary>
        /// Gets and sets counter of Ids
        /// </summary>
        private static int Counter { get; set; } = 0;

        /// <summary>
        /// Create ID
        /// </summary>
        /// <returns>ID</returns>
        public static int GetNextId()
        {
            while (BusyIds.Exists(id => id == Counter))
            {
                ++Counter;
            }
            BusyIds.Add(Counter);
            return Counter++;
        }

        /// <summary>
        /// Release Current ID
        /// </summary>
        /// <param name="id">ID</param>
        public static void ReleaseId(int id)
        {
            BusyIds.Remove(id);
        }
    }
}
