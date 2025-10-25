using Programming.Model.Geometry;

namespace Programming.View.Controls
{
    /// <summary>
    /// A user control that allows users to add, remove, and edit rectangles on a canvas.
    /// Detects and visualizes collisions between rectangles in real time.
    /// </summary>
    public partial class RectangleCollisionControl : UserControl
    {
        private readonly List<Rectangular> _rectangles = new();
        private readonly List<Panel> _rectanglePanels = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="RectangleCollisionControl"/> class.
        /// </summary>
        public RectangleCollisionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles click on the "Add Rectangle" button. Adds a new random rectangle to the collection and canvas.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void addRectangleButton_Click(object sender, EventArgs e)
        {
            var rectangle = RectangleFactory.Randomize();
            _rectangles.Add(rectangle);
            rectangleColListBox.Items.Add(rectangle);

            var panel = CreatePanelForRectangle(rectangle);
            _rectanglePanels.Add(panel);
            rectangleCanvasPanel.Controls.Add(panel);

            FindCollisions();
        }

        /// <summary>
        /// Handles click on the "Remove Rectangle" button. Removes the selected rectangle from the collection and canvas.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void removeRectangleButton_Click(object sender, EventArgs e)
        {
            int index = rectangleColListBox.SelectedIndex;
            if (index == -1) return;

            rectangleCanvasPanel.Controls.Remove(_rectanglePanels[index]);
            _rectanglePanels.RemoveAt(index);

            rectangleColListBox.Items.RemoveAt(index);
            _rectangles.RemoveAt(index);

            ClearRectangleInfo();
            FindCollisions();
        }

        /// <summary>
        /// Handles selection changes in the rectangle list. Updates input fields with selected rectangle's data.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void rectangleColListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = rectangleColListBox.SelectedIndex;
            if (index == -1)
            {
                ClearRectangleInfo();
            }
            else
            {
                UpdateRectangleInfo(_rectangles[index]);
            }
        }

        /// <summary>
        /// Handles text change in ID TextBox (used for display only).
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void selectedRectangleIDTextBox_TextChanged(object sender, EventArgs e)
        {
            // Поле только для чтения — просто обновляем при смене выбора
            // Этот обработчик нужен, чтобы дизайнер не ругался, что не хватает подписки
        }

        /// <summary>
        /// Handles MouseLeave on X TextBox: updates center X coordinate.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void selectedRectangleXTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (!TryParsePositiveInt(selectedRectangleXTextBox.Text, out int value)) return;

            int index = rectangleColListBox.SelectedIndex;
            if (index == -1) return;

            _rectangles[index].Center = new Point2D(value, _rectangles[index].Center.Y);
            UpdatePanelPosition(index);
            RefreshListItem(index);
            FindCollisions();
            ApplyValidStyle(selectedRectangleXTextBox);
        }

        /// <summary>
        /// Handles MouseLeave on Y TextBox: updates center Y coordinate.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void selectedRectangleYTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (!TryParsePositiveInt(selectedRectangleYTextBox.Text, out int value)) return;

            int index = rectangleColListBox.SelectedIndex;
            if (index == -1) return;

            _rectangles[index].Center = new Point2D(_rectangles[index].Center.X, value);
            UpdatePanelPosition(index);
            RefreshListItem(index);
            FindCollisions();
            ApplyValidStyle(selectedRectangleYTextBox);
        }

        /// <summary>
        /// Handles MouseLeave on Width TextBox: updates rectangle width.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void selectedRectangleWidthTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (!TryParsePositiveInt(selectedRectangleWidthTextBox.Text, out int value)) return;

            int index = rectangleColListBox.SelectedIndex;
            if (index == -1) return;

            _rectangles[index].Width = value;
            _rectanglePanels[index].Width = value;
            RefreshListItem(index);
            FindCollisions();
            ApplyValidStyle(selectedRectangleWidthTextBox);
        }

        /// <summary>
        /// Handles MouseLeave on Height TextBox: updates rectangle length (height).
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void selectedRectangleHeightTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (!TryParsePositiveInt(selectedRectangleHeightTextBox.Text, out int value)) return;

            int index = rectangleColListBox.SelectedIndex;
            if (index == -1) return;

            _rectangles[index].Length = value;
            _rectanglePanels[index].Height = value;
            RefreshListItem(index);
            FindCollisions();
            ApplyValidStyle(selectedRectangleHeightTextBox);
        }

        /// <summary>
        /// Parses a string as a positive integer.
        /// </summary>
        /// <param name="text">The text to parse.</param>
        /// <param name="value">The parsed value, if successful.</param>
        /// <returns><see langword="true"/> if parsing succeeded and value is positive; otherwise, <see langword="false"/>.</returns>
        private static bool TryParsePositiveInt(string? text, out int value)
        {
            if (int.TryParse(text, out value) && value > 0)
            {
                return true;
            }

            value = 0;
            return false;
        }

        /// <summary>
        /// Creates a Panel control visually representing the specified rectangle.
        /// </summary>
        /// <param name="rectangle">The rectangle to represent.</param>
        /// <returns>A Panel positioned and sized according to the rectangle's properties.</returns>
        private Panel CreatePanelForRectangle(Rectangular rectangle)
        {
            int x = (int)(rectangle.Center.X - rectangle.Width / 2);
            int y = (int)(rectangle.Center.Y - rectangle.Length / 2);

            return new Panel
            {
                Location = new Point(x, y),
                Width = (int)rectangle.Width,
                Height = (int)rectangle.Length,
                BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127), // Semi-transparent green
                BorderStyle = BorderStyle.FixedSingle
            };
        }

        /// <summary>
        /// Updates the position of the panel corresponding to the rectangle at the specified index.
        /// </summary>
        /// <param name="index">Index of the rectangle and panel.</param>
        private void UpdatePanelPosition(int index)
        {
            var rect = _rectangles[index];
            int x = (int)(rect.Center.X - rect.Width / 2);
            int y = (int)(rect.Center.Y - rect.Length / 2);
            _rectanglePanels[index].Location = new Point(x, y);
        }

        /// <summary>
        /// Replaces the item in the ListBox to trigger ToString update.
        /// </summary>
        /// <param name="index">Index of the item to refresh.</param>
        private void RefreshListItem(int index)
        {
            var item = rectangleColListBox.Items[index];
            rectangleColListBox.Items.RemoveAt(index);
            rectangleColListBox.Items.Insert(index, item);
        }

        /// <summary>
        /// Applies error visualization (pink background) to a TextBox.
        /// </summary>
        /// <param name="textBox">The TextBox to style.</param>
        private static void ApplyErrorStyle(TextBox textBox)
        {
            textBox.BackColor = System.Drawing.Color.LightPink;
        }

        /// <summary>
        /// Resets the background color of a TextBox to default (white).
        /// </summary>
        /// <param name="textBox">The TextBox to reset.</param>
        private static void ApplyValidStyle(TextBox textBox)
        {
            textBox.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Detects collisions between all pairs of rectangles and updates their visual appearance.
        /// Colliding rectangles are highlighted in red.
        /// </summary>
        private void FindCollisions()
        {
            foreach (var panel in _rectanglePanels)
            {
                panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127); // Green
            }

            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127); // Red
                        _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127); // Red
                    }
                }
            }
        }

        /// <summary>
        /// Updates the info fields with the specified rectangle's data.
        /// </summary>
        /// <param name="rectangle">The rectangle to display.</param>
        private void UpdateRectangleInfo(Rectangular rectangle)
        {
            selectedRectangleIDTextBox.Text = rectangle.ID.ToString();
            selectedRectangleXTextBox.Text = ((int)rectangle.Center.X).ToString();
            selectedRectangleYTextBox.Text = ((int)rectangle.Center.Y).ToString();
            selectedRectangleWidthTextBox.Text = ((int)rectangle.Width).ToString();
            selectedRectangleHeightTextBox.Text = ((int)rectangle.Length).ToString();
        }

        /// <summary>
        /// Clears all info fields.
        /// </summary>
        private void ClearRectangleInfo()
        {
            selectedRectangleIDTextBox.Clear();
            selectedRectangleXTextBox.Clear();
            selectedRectangleYTextBox.Clear();
            selectedRectangleWidthTextBox.Clear();
            selectedRectangleHeightTextBox.Clear();
        }
    }
}