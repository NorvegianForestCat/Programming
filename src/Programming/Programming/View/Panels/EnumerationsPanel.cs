namespace Programming.View.Panels
{
    /// <summary>
    /// A user control that allows browsing available enumerations and viewing their members and underlying integer values.
    /// The left list displays enum types; the right list shows all values of the selected enum.
    /// </summary>
    public partial class EnumerationsPanel : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationsPanel"/> class.
        /// </summary>
        public EnumerationsPanel()
        {
            InitializeComponent();
            enumsListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Handles selection change in the enums list. Populates the value list with members of the selected enum.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void enumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (enumsListBox.SelectedIndex == -1) return;

            Type enumType = GetSelectedEnumType();
            if (enumType != null && Enum.GetValues(enumType).Length > 0)
            {
                InitializeValueListBox(Enum.GetValues(enumType).GetValue(0) as Enum);
            }
        }

        /// <summary>
        /// Maps the currently selected index in <see cref="enumsListBox"/> to its corresponding enum type.
        /// </summary>
        /// <returns>The <see cref="Type"/> of the selected enum, or <see langword="null"/> if invalid.</returns>
        private Type? GetSelectedEnumType()
        {
            return enumsListBox.SelectedIndex switch
            {
                0 => typeof(Color),
                1 => typeof(EducationForm),
                2 => typeof(Genre),
                3 => typeof(Season),
                4 => typeof(SmartphoneMaker),
                5 => typeof(Weekday),
                _ => null
            };
        }

        /// <summary>
        /// Populates the <see cref="valueListBox"/> with all members of the specified enumeration.
        /// </summary>
        /// <param name="selectedEnum">An instance of the enum whose values will be displayed. Used to determine the type.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selectedEnum"/> is <see langword="null"/>.</exception>
        private void InitializeValueListBox(Enum selectedEnum)
        {
            if (selectedEnum is null)
                throw new ArgumentNullException(nameof(selectedEnum));

            valueListBox.Items.Clear();

            foreach (var value in Enum.GetValues(selectedEnum.GetType()).Cast<Enum>())
            {
                valueListBox.Items.Add(value);
            }

            valueListBox.SelectedIndex = -1;
            intValueTextBox.Clear();
        }

        /// <summary>
        /// Handles selection change in the value list. Displays the underlying integer value of the selected enum member.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void valueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (valueListBox.SelectedItem is Enum selectedEnum)
            {
                intValueTextBox.Text = ((int)(object)selectedEnum).ToString();
            }
            else
            {
                intValueTextBox.Clear();
            }
        }
    }
}