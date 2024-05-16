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
    /// Custom user control for enumerations panel
    /// </summary>
    public partial class EnumerationsPanel : UserControl
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public EnumerationsPanel()
        {
            InitializeComponent();

            enumsListBox.SelectedIndex = 0; // Set a base element for enums list
        }

        /// <summary>
        /// Event handling enumsListBox_SelectedIndexChanged
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void enumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Choosing enum for showing it's elements in values list by existed enums list
            switch (enumsListBox.SelectedIndex)
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

        /// <summary>
        /// Initializing value listBox
        /// </summary>
        /// <param name="selectedEnum">Enum</param>
        private void InitializeValueListBox(Enum selectedEnum)
        {
            valueListBox.Items.Clear(); // Clear values list from existed values

            // Filling values list by new values from selectedEnum
            foreach (Enum enumElement in Enum.GetValues(selectedEnum.GetType()))
            {
                valueListBox.Items.Add(enumElement);
            }
        }

        /// <summary>
        /// Event handling enumsListBox_SelectedIndexChanged
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void valueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Writing an int representation of selected enum element
            intValueTextBox.Text = ((int)valueListBox.SelectedItem).ToString();
        }
    }
}
