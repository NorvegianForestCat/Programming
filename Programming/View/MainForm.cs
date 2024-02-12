using System.Diagnostics;
using System.Windows.Markup;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            WeekdayValidLabel.Text = String.Empty; // Clear the label for selected weekday
            EnumsListBox.SelectedIndex = 0; // Set a base element for enums list

            ChooseSeasonComboBox.DataSource = Enum.GetValues(typeof(Season)); // Filling a season ComboBox
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Choosing enum for showing it's elements in values list by existed enums list
            switch (EnumsListBox.SelectedIndex)
            {
                case 0:
                    // Select enum Color and fill values its enum elements
                    InitializeValueListBox(new Color());
                    break;

                case 1:
                    // Select enum EducationForm and fill values its enum elements
                    InitializeValueListBox(new EducationForm());
                    break;

                case 2:
                    // Select enum Genre and fill values its enum elements
                    InitializeValueListBox(new Genre());
                    break;

                case 3:
                    // Select enum Season and fill values its enum elements
                    InitializeValueListBox(new Season());
                    break;

                case 4:
                    // Select enum SmartphoneMaker and fill values its enum elements
                    InitializeValueListBox(new SmartphoneMaker());
                    break;

                case 5:
                    // Select enum Weekday and fill values its enum elements
                    InitializeValueListBox(new Weekday());
                    break;
            }
        }

        // Filling a values list
        private void InitializeValueListBox(Enum selectedEnum)
        {
            ValueListBox.Items.Clear(); // Clear values list from existed values

            // Filling values list by new values from selectedEnum
            foreach (Enum enumElement in Enum.GetValues(selectedEnum.GetType()))
            {
                ValueListBox.Items.Add(enumElement);
            }
        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Writing an int representation of selected enum element
            IntValueTextBox.Text = ((int)ValueListBox.SelectedItem).ToString();
        }

        private void ParseWeekdayButton_Click(object sender, EventArgs e)
        {
            // Fool-check
            if (WeekdayValueTextBox.Text == String.Empty) return;

            // Validating entered text in WeekdayValuetextBox by occurence in Weekday enum
            if (Enum.TryParse(WeekdayValueTextBox.Text, out Weekday enteredDay) && Enum.IsDefined(typeof(Weekday), enteredDay))
            {
                // Changing a text according to entered day
                WeekdayValidLabel.Text = $"Это день недели ({enteredDay.ToString()} = {(int)enteredDay})";
            }
            else
            {
                // "This object does not exist" message
                WeekdayValidLabel.Text = "Нет такого дня недели";
            }
        }

        private void ChooseSeasonButton_Click(object sender, EventArgs e)
        {
            // Fool-check
            if (ChooseSeasonComboBox.SelectedItem == null) return;

            // Performing some operations according to selected season 
            switch(ChooseSeasonComboBox.SelectedItem) 
            {
                case Season.Summer:
                    // Showing a message box with some text (Ура! Солнце!)
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Winter:
                    // Showing a message box with some text (Бррр! Холодно!)
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Fall:
                    // Changing background color by according color (#e29c45)
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                case Season.Spring:
                    // Changing background color by according color (#559c45)
                    this.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
            }
        }
    }
}