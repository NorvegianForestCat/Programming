using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    internal static class IdGenerator
    {
        private static int _idCounter;
        private static int IdCounter { get; set; }

        public static int GetNextId()
        {
            return ++IdCounter;
        }
    }
}
