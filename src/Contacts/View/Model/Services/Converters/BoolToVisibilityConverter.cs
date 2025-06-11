using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace View.ViewModel
{
    /// <summary>
    /// Implements the conversion of bool to Visibility.
    /// </summary>
    public class BoolToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Converts the value that came from the binding to the type,
        /// which is understood by the binding receiver.
        /// </summary>
        /// <param name="value">The value to be converted.</param>
        /// <param name="targetType">The type to convert the value to.</param>
        /// <param name="parameter">Auxiliary parameter.</param>
        /// <param name="culture">The current culture of the application.</param>
        /// <returns>The converted value.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                return Visibility.Visible;
            }

            return Visibility.Hidden;
        }

        /// <summary>
        /// Converts the value received from the binding receiver into a type
        /// that is understood by the binding.
        /// </summary>
        /// <param name="value">The value to be converted.</param>
        /// <param name="targetType">The type to convert the value to.</param>
        /// <param name="parameter">Auxiliary parameter.</param>
        /// <param name="culture">The current culture of the application.</param>
        /// <returns>The converted value.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}