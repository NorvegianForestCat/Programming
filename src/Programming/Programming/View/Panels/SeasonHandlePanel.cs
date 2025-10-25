namespace Programming.View.Panels
{
    /// <summary>
    /// A user control that allows users to select a season and receive visual or message-based feedback.
    /// The background color changes according to the selected season, and a descriptive message is shown.
    /// </summary>
    public partial class SeasonHandlePanel : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeasonHandlePanel"/> class.
        /// Populates the combo box with all values from the <see cref="Season"/> enumeration.
        /// </summary>
        public SeasonHandlePanel()
        {
            InitializeComponent();

            chooseSeasonComboBox.DataSource = Enum.GetValues<Season>();
        }

        /// <summary>
        /// Handles click on the "Choose Season" button. Displays a message and updates the background color
        /// based on the selected season.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void chooseSeasonButton_Click(object sender, EventArgs e)
        {
            if (chooseSeasonComboBox.SelectedItem is not Season selectedSeason)
                return;

            ShowSeasonMessage(selectedSeason);
            UpdateBackgroundColor(selectedSeason);
        }

        /// <summary>
        /// Displays a friendly message based on the selected season.
        /// </summary>
        /// <param name="season">The selected season.</param>
        private void ShowSeasonMessage(Season season)
        {
            string message = season switch
            {
                Season.Summer => "Hooray! Sunshine!",
                Season.Winter => "Brrr! It's cold!",
                Season.Spring => "Spring is in the air! Leaves are growing.",
                Season.Fall => "Autumn leaves are falling...",
                _ => "Unknown season."
            };

            MessageBox.Show(message, $"Season: {season}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Updates the background color of the panel to reflect the selected season.
        /// </summary>
        /// <param name="season">The selected season.</param>
        private void UpdateBackgroundColor(Season season)
        {
            BackColor = season switch
            {
                Season.Summer => System.Drawing.Color.FromArgb(255, 255, 220), // Light yellow
                Season.Winter => System.Drawing.Color.FromArgb(230, 240, 255), // Light blue
                Season.Spring => System.Drawing.Color.FromArgb(180, 220, 180), // Light green
                Season.Fall => System.Drawing.Color.FromArgb(226, 156, 69),   // Amber (#e29c45)
                _ => SystemColors.Control
            };
        }
    }
}