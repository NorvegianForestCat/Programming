using Programming.Model.Geometry;
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
    /// Custom user control for rectangle panel
    /// </summary>
    public partial class RectanglePanel : UserControl
    {
        /// <summary>
        /// Nessesary fields
        /// </summary>
        private const int _numberOfRectangles = 5;
        private Rectangular[] _rectangles;
        private Rectangular _currentRectangle;
        private Random rand;

        /// <summary>
        /// Constructor
        /// </summary>
        public RectanglePanel()
        {
            InitializeComponent();

            _rectangles = new Rectangular[_numberOfRectangles]; // Initialize rectangulars array
            rand = new Random(); // Create a Random object

            // Filling rectangular array and "linked" each with rectangleListBox element
            for (int i = 0; i < _numberOfRectangles; i++)
            {
                _rectangles[i] = new Rectangular(rand.Next(100), rand.Next(100), 1, 1, "White");
                rectangleListBox.Items.Add($"Rectangular {i + 1}");
            }
        }

        /// <summary>
        /// Event handling rectangleListBox_SelectedIndexChanged
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void rectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Fools-check
            if (rectangleListBox.SelectedIndex < 0) return;

            // Choose a correct rectangle following selected
            _currentRectangle = _rectangles[rectangleListBox.SelectedIndex];

            // Filling fields of object
            lengthTextBox.Text = _currentRectangle.Length.ToString();
            widthTextBox.Text = _currentRectangle.Width.ToString();
            rectColorTextBox.Text = _currentRectangle.Color.ToString();
            rectangleCenterTextBox.Text = _currentRectangle.Center.ToString();
            rectangleIDTextBox.Text = _currentRectangle.ID.ToString();

            MessageBox.Show(CollisionManager.IsCollision(_currentRectangle, _rectangles[0]).ToString());
        }

        /// <summary>
        /// Event handling lengthTextBox_TextChanged
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            // Error-checker
            try
            {
                _currentRectangle.Length = int.Parse(lengthTextBox.Text); // Collecting length value

                // Changing TextBox color to white
                if (lengthTextBox.BackColor != ColorTranslator.FromHtml("#FFFFFF"))
                {
                    lengthTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                }
            }
            catch
            {
                // Changing TextBox color to LightPink
                lengthTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
            }
        }

        /// <summary>
        /// Event handling widthTextBox_TextChanged
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            // Error-checker
            try
            {
                _currentRectangle.Width = int.Parse(widthTextBox.Text); // Collecting width value

                // Changing TextBox color to white
                if (widthTextBox.BackColor != ColorTranslator.FromHtml("#FFFFFF"))
                {
                    widthTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                }
            }
            catch
            {
                // Changing TextBox color to LightPink
                widthTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
            }
        }

        /// <summary>
        /// Event handling rectColorTextBox_TextChanged
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void rectColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = rectColorTextBox.Text; // Collecting color value
        }

        /// <summary>
        /// Find Rectangle with max width
        /// </summary>
        /// <param name="rectangularArray">Array of rectangles</param>
        /// <returns>Index</returns>
        private int FindRectangleWithMaxWidth(Rectangular[] rectangularArray)
        {
            double maxWidth = rectangularArray[0].Width;
            int maxWidthIndex = 0;

            // Finding max width index
            for (int i = 0; i < rectangularArray.Length; i++)
            {
                if (rectangularArray[i].Width >= maxWidth)
                {
                    maxWidth = rectangularArray[i].Width;
                    maxWidthIndex = i;
                }
            }

            return maxWidthIndex;
        }

        /// <summary>
        /// Event handling rectFindButton_Click
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void rectFindButton_Click(object sender, EventArgs e)
        {
            int maxWidthIndex = FindRectangleWithMaxWidth(_rectangles); // Found max width index
            rectangleListBox.SelectedIndex = maxWidthIndex; // Changing index of selected element
        }
    }
}
