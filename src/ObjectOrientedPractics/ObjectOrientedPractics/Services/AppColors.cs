using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Provides colors
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// If success
        /// </summary>
        public static Color RightInputColor { get; } = Color.White;

        /// <summary>
        /// If error
        /// </summary>
        public static Color WrongInputColor { get; } = Color.Red;
    }
}