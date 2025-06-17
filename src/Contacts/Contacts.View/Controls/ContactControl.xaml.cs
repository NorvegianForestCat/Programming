using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace Contacts.View.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        public ContactControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Регулярное выражение.
        /// </summary>
        Regex regex = new Regex(@"^[0-9\s\+\-\(\)]");

        /// <summary>
        /// Проверка ввода в TextBox.
        /// </summary>
        private void ContactPhoneTextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = !regex.IsMatch(e.Text);
        }

        /// <summary>
        /// Проверка вставки в TextBox.
        /// </summary>
        private void ContactPhoneTextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string text = (string)e.DataObject.GetData(typeof(string));
                if (!regex.IsMatch(text))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }
    }
}