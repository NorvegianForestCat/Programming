using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    /// Custom user control for weekday panel
    /// </summary>
    public partial class WeekdayPanel : UserControl
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public WeekdayPanel()
        {
            InitializeComponent();

            weekdayValidLabel.Text = String.Empty; // Clear the label for selected weekday
        }

        /// <summary>
        /// Event handling parseWeekdayButton click
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void parseWeekdayButton_Click(object sender, EventArgs e)
        {
            // Fool-check
            if (weekdayValueTextBox.Text == String.Empty) return;

            // Validating entered text in WeekdayValuetextBox by occurence in Weekday enum
            if (Enum.TryParse(weekdayValueTextBox.Text, out Weekday enteredDay) && Enum.IsDefined(typeof(Weekday), enteredDay))
            {
                // Changing a text according to entered day
                weekdayValidLabel.Text = $"Это день недели ({enteredDay.ToString()} = {(int)enteredDay})";
            }
            else
            {
                // "This object does not exist" message
                weekdayValidLabel.Text = "Нет такого дня недели";
            }
        }
    }
}
