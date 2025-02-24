﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Provides functions for collisions
    /// </summary>
    static class CollisionManager
    {
        /// <summary>
        /// Rectangle collision
        /// </summary>
        /// <param name="rectangular1">Rectangle</param>
        /// <param name="rectangular2">Rectanlge</param>
        /// <returns>Is collision?</returns>
        public static bool IsCollision(Rectangular rectangular1, Rectangular rectangular2)
        {
            if (Math.Abs(rectangular1.Center.X - rectangular2.Center.X) < Math.Abs(rectangular1.Width / 2 + rectangular2.Width / 2) &
               Math.Abs(rectangular1.Center.Y - rectangular2.Center.Y) < Math.Abs(rectangular1.Length / 2 + rectangular2.Length / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Ring collision
        /// </summary>
        /// <param name="rectangular1">Ring</param>
        /// <param name="rectangular2">Ring</param>
        /// <returns>Is collision?</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double C = Math.Sqrt(Math.Pow(Math.Abs(ring1.Center.X - ring2.Center.X), 2) - Math.Pow(Math.Abs(ring1.Center.Y - ring2.Center.Y), 2));
            if (C < ring1.ExternalRadius + ring2.ExternalRadius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
