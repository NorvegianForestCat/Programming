using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Provides functions for rectangle generation
    /// </summary>
    static class RectangleFactory
    {
        /// <summary>
        /// Randomize rectangle
        /// </summary>
        /// <returns></returns>
        public static Rectangular Randomize()
        {
            Random rand = new Random();

            return new Rectangular(rand.Next(10, 100), rand.Next(10, 100), rand.Next(50, 300), rand.Next(50, 300), "Green");
        }
    }
}
