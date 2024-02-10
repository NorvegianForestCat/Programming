using System.Diagnostics;
using System.Windows.Markup;

namespace Programming
{
    public partial class MainForm : Form
    {
        Enum? selectedEnum;

        public MainForm()
        {
            InitializeComponent();
            SeasonValidLabel.Text = String.Empty;
            EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (EnumsListBox.SelectedIndex)
            {
                case 0:
                    selectedEnum = new Color();
                    break;
                case 1:
                    selectedEnum = new EducationForm();
                    break;
                case 2:
                    selectedEnum = new Genre();
                    break;
                case 3:
                    selectedEnum = new Season();
                    break;
                case 4:
                    selectedEnum = new SmartphoneMaker();
                    break;
                case 5:
                    selectedEnum = new Weekday();
                    break;
            }

            InitializeValueListBox();
        }

        private void InitializeValueListBox()
        {
            ValueListBox.Items.Clear();

            foreach (Enum enumElement in Enum.GetValues(selectedEnum.GetType()))
            {
                ValueListBox.Items.Add(enumElement);
            }
        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = ((int)ValueListBox.SelectedItem).ToString();
        }
    }
}