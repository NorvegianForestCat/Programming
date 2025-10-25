using System;
using System.Linq;
using System.Windows.Forms;
using Programming.Model.Geometry;

namespace Programming.View.Panels
{
    /// <summary>
    /// A user control for managing and displaying a collection of rectangles.
    /// Allows viewing, editing rectangle properties, and finding the rectangle with maximum width.
    /// </summary>
    public partial class RectanglePanel : UserControl
    {
        private const int NumberOfRectangles = 5;
        private readonly Rectangular[] _rectangles;
        private Rectangular _currentRectangle = null!;
        private readonly Random _random = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="RectanglePanel"/> class.
        /// Populates the rectangle list with random test data.
        /// </summary>
        public RectanglePanel()
        {
            InitializeComponent();

            _rectangles = new Rectangular[NumberOfRectangles];

            for (int i = 0; i < NumberOfRectangles; i++)
            {
                var length = _random.Next(10, 200);
                var width = _random.Next(10, 200);
                var x = _random.Next(50, 300);
                var y = _random.Next(50, 300);
                var color = "White";

                _rectangles[i] = new Rectangular(length, width, x, y, color);
                rectangleListBox.Items.Add($"Rectangular {i + 1}");
            }

            // Выбираем первый элемент по умолчанию
            rectangleListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Handles selection change in the rectangle list. Updates UI fields with selected rectangle's data.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void rectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rectangleListBox.SelectedIndex < 0) return;

            _currentRectangle = _rectangles[rectangleListBox.SelectedIndex];
            UpdateUiFromCurrentRectangle();
        }

        /// <summary>
        /// Updates all text boxes to reflect the current rectangle's properties.
        /// </summary>
        private void UpdateUiFromCurrentRectangle()
        {
            lengthTextBox.Text = ((int)_currentRectangle.Length).ToString();
            widthTextBox.Text = ((int)_currentRectangle.Width).ToString();
            rectColorTextBox.Text = _currentRectangle.Color ?? string.Empty;
            rectangleCenterTextBox.Text = $"({(int)_currentRectangle.Center.X}, {(int)_currentRectangle.Center.Y})";
            rectangleIDTextBox.Text = _currentRectangle.ID.ToString();
        }

        /// <summary>
        /// Handles changes to the length text box. Validates input as positive integer.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(lengthTextBox.Text, out int value) && value > 0)
            {
                _currentRectangle.Length = value;
                ApplyValidStyle(lengthTextBox);
            }
            else
            {
                ApplyErrorStyle(lengthTextBox);
            }
        }

        /// <summary>
        /// Handles changes to the width text box. Validates input as positive integer.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(widthTextBox.Text, out int value) && value > 0)
            {
                _currentRectangle.Width = value;
                ApplyValidStyle(widthTextBox);
            }
            else
            {
                ApplyErrorStyle(widthTextBox);
            }
        }

        /// <summary>
        /// Handles changes to the color text box. Updates the rectangle's color.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void rectColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = rectColorTextBox.Text;
            // Цвет не валидируется — допускается любое значение
        }

        /// <summary>
        /// Applies error visual style (pink background) to a text box.
        /// </summary>
        /// <param name="textBox">The text box to highlight.</param>
        private static void ApplyErrorStyle(TextBox textBox)
        {
            textBox.BackColor = System.Drawing.Color.LightPink;
        }

        /// <summary>
        /// Resets the background color of a text box to default (white).
        /// </summary>
        /// <param name="textBox">The text box to reset.</param>
        private static void ApplyValidStyle(TextBox textBox)
        {
            textBox.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Finds the index of the rectangle with the maximum width.
        /// </summary>
        /// <param name="rectangularArray">The array of rectangles to search.</param>
        /// <returns>The index of the rectangle with the maximum width.</returns>
        /// <exception cref="ArgumentException">Thrown when the array is null or empty.</exception>
        private static int FindRectangleWithMaxWidth(Rectangular[] rectangularArray)
        {
            if (rectangularArray == null || rectangularArray.Length == 0)
                throw new ArgumentException("Rectangle array cannot be null or empty.", nameof(rectangularArray));

            return rectangularArray
                .Select((rect, index) => new { rect.Width, index })
                .OrderByDescending(x => x.Width)
                .First().index;
        }

        /// <summary>
        /// Handles click on the "Find Largest Width" button. Selects the rectangle with maximum width.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void rectFindButton_Click(object sender, EventArgs e)
        {
            int maxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            rectangleListBox.SelectedIndex = maxWidthIndex;
        }
    }
}