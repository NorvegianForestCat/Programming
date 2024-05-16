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
    /// Custom user control for season panel
    /// </summary>
    public partial class SeasonHandlePanel : UserControl
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SeasonHandlePanel()
        {
            InitializeComponent();

            chooseSeasonComboBox.DataSource = Enum.GetValues(typeof(Season)); // Filling a season ComboBox
        }

        /// <summary>
        /// Event handling chooseSeasonButton click
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void chooseSeasonButton_Click(object sender, EventArgs e)
        {
            // Fool-check
            if (chooseSeasonComboBox.SelectedItem == null) return;

            // Performing some operations according to selected season 
            switch (chooseSeasonComboBox.SelectedItem)
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
                    MessageBox.Show("Leaves..");
                    break;
                case Season.Spring:
                    // Changing background color by according color (#559c45)
                    MessageBox.Show("Leaves!");
                    break;
            }
        }
    }
}
