using System;
using System.Windows.Forms;
using Programming.Model;

namespace Programming.View.Panels
{
    /// <summary>
    /// A user control that validates and parses a weekday name entered by the user.
    /// Displays confirmation with the day's name and numeric value if valid; otherwise, shows an error message.
    /// </summary>
    public partial class WeekdayPanel : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeekdayPanel"/> class.
        /// Clears the result label on startup.
        /// </summary>
        public WeekdayPanel()
        {
            InitializeComponent();
            weekdayValidLabel.Text = string.Empty;
        }

        /// <summary>
        /// Handles click on the "Parse Weekday" button. Attempts to parse the input as a <see cref="Weekday"/>.
        /// Updates the result label with success or error message.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void parseWeekdayButton_Click(object sender, EventArgs e)
        {
            string input = weekdayValueTextBox.Text?.Trim();

            if (string.IsNullOrEmpty(input))
            {
                weekdayValidLabel.Text = "Please enter a weekday name.";
                return;
            }

            if (Enum.TryParse<Weekday>(input, ignoreCase: true, out var enteredDay))
            {
                int value = (int)(object)enteredDay;
                weekdayValidLabel.Text = $"It's a weekday ({enteredDay} = {value})";
            }
            else
            {
                weekdayValidLabel.Text = "No such weekday exists.";
            }
        }
    }
}