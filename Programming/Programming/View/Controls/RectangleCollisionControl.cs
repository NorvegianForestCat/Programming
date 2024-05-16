using Programming.Model.Services;
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

namespace Programming.View.Controls
{
    /// <summary>
    /// Custom user control for third tab
    /// </summary>
    public partial class RectangleCollisionControl : UserControl
    {
        /// <summary>
        /// Nessesary fields
        /// </summary>
        private List<Panel> _rectanglePanels;
        private List<Rectangular> _rectangles;
        private bool dtFlag;

        /// <summary>
        /// Constructor
        /// </summary>
        public RectangleCollisionControl()
        {
            InitializeComponent();
            _rectangles = new List<Rectangular>();
            _rectanglePanels = new List<Panel>();
            dtFlag = true;
        }

        /// <summary>
        /// Event handling addRectangleButton click
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void addRectangleButton_Click(object sender, EventArgs e)
        {
            _rectangles.Add(RectangleFactory.Randomize());
            rectangleColListBox.Items.Add(_rectangles[_rectangles.Count - 1]);
            var newPanel = new Panel();

            newPanel.Location = new Point((int)_rectangles[_rectangles.Count - 1].Center.X - (int)_rectangles[_rectangles.Count - 1].Width / 2,
            (int)_rectangles[_rectangles.Count - 1].Center.Y - (int)_rectangles[_rectangles.Count - 1].Length / 2);

            newPanel.Width = (int)_rectangles[_rectangles.Count - 1].Width;
            newPanel.Height = (int)_rectangles[_rectangles.Count - 1].Length;
            newPanel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            newPanel.BorderStyle = BorderStyle.FixedSingle;

            _rectanglePanels.Add(newPanel);
            rectangleCanvasPanel.Controls.Add(newPanel);

            FindCollision();
        }

        /// <summary>
        /// Event handling removeRectangleButton click
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void removeRectangleButton_Click(object sender, EventArgs e)
        {
            if (_rectangles == null || rectangleColListBox.SelectedIndex == -1) return;
            int index = rectangleColListBox.SelectedIndex;

            _rectangles.RemoveAt(index);
            rectangleColListBox.Items.RemoveAt(index);
            rectangleCanvasPanel.Controls.Remove(_rectanglePanels[index]);
            _rectanglePanels.RemoveAt(index);

            FindCollision();
        }

        /// <summary>
        /// Event handling rectangleColListBox changed selected index
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void rectangleColListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (rectangleColListBox.SelectedIndex == -1)
            {
                ClearRectangleInfo();
            }
            else
            {
                if (dtFlag)
                {
                    var index = rectangleColListBox.SelectedIndex;
                    UpdateRectangleInfo(_rectangles[index]);
                }
            }
        }

        /// <summary>
        /// Event handling selectedRectangleIDTextBox text changed
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void selectedRectangleIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (rectangleColListBox.SelectedIndex == -1) return;
            var value = _rectangles[rectangleColListBox.SelectedIndex].ID;
            selectedRectangleIDTextBox.Text = value.ToString();
        }

        /// <summary>
        /// Event handling selectedRectangleXTextBox mouse leave
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void selectedRectangleXTextBox_MouseLeave(object sender, EventArgs e)
        {
            // Error-checker
            try
            {
                var value = int.Parse(selectedRectangleXTextBox.Text);

                var index = rectangleColListBox.SelectedIndex;
                Validator.AssertOnPositiveValue(value, selectedRectangleXTextBox.ToString());

                dtFlag = false;
                _rectangles[index].Center.X = value;

                _rectanglePanels[index].Location = new Point(value - (int)_rectangles[index].Width / 2, (int)_rectangles[index].Center.Y - (int)_rectangles[index].Length / 2);

                rectangleColListBox.Items.RemoveAt(index);
                rectangleColListBox.Items.Insert(index, _rectangles[index]);

                dtFlag = true;

                FindCollision();
                // Changing TextBox color to white
                if (selectedRectangleXTextBox.BackColor != ColorTranslator.FromHtml("#FFFFFF"))
                {
                    selectedRectangleXTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                }
            }
            catch
            {
                // Changing TextBox color to LightPink
                selectedRectangleXTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
            }
        }

        /// <summary>
        /// Event handling selectedRectangleYTextBox mouse leave
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void selectedRectangleYTextBox_MouseLeave(object sender, EventArgs e)
        {
            // Error-checker
            try
            {
                var value = int.Parse(selectedRectangleYTextBox.Text);

                var index = rectangleColListBox.SelectedIndex;
                Validator.AssertOnPositiveValue(value, selectedRectangleYTextBox.ToString());

                dtFlag = false;

                _rectangles[index].Center.Y = value;
                _rectanglePanels[index].Location = new Point((int)_rectangles[index].Center.X - (int)_rectangles[index].Length / 2, value - (int)_rectangles[index].Width / 2);

                rectangleColListBox.Items.RemoveAt(index);
                rectangleColListBox.Items.Insert(index, _rectangles[index]);

                dtFlag = true;
                FindCollision();

                // Changing TextBox color to white
                if (selectedRectangleYTextBox.BackColor != ColorTranslator.FromHtml("#FFFFFF"))
                {
                    selectedRectangleYTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                }
            }
            catch
            {
                // Changing TextBox color to LightPink
                selectedRectangleYTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
            }
        }

        /// <summary>
        /// Event handling selectedRectangleWidthTextBox mouse leave
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void selectedRectangleWidthTextBox_MouseLeave(object sender, EventArgs e)
        {
            // Error-checker
            try
            {
                var value = int.Parse(selectedRectangleWidthTextBox.Text);
                var index = rectangleColListBox.SelectedIndex;

                Validator.AssertOnPositiveValue(value, selectedRectangleWidthTextBox.ToString());

                dtFlag = false;

                _rectangles[index].Width = value;
                _rectanglePanels[index].Width = value;

                rectangleColListBox.Items.RemoveAt(index);
                rectangleColListBox.Items.Insert(index, _rectangles[index]);

                dtFlag = true;
                FindCollision();

                // Changing TextBox color to white
                if (selectedRectangleWidthTextBox.BackColor != ColorTranslator.FromHtml("#FFFFFF"))
                {
                    selectedRectangleWidthTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                }
            }
            catch
            {
                // Changing TextBox color to LightPink
                selectedRectangleWidthTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
            }
        }

        /// <summary>
        /// Event handling selectedRectangleHeightTextBox mouse leave
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void selectedRectangleHeightTextBox_MouseLeave(object sender, EventArgs e)
        {
            // Error-checker
            try
            {
                var value = int.Parse(selectedRectangleHeightTextBox.Text);
                var index = rectangleColListBox.SelectedIndex;

                Validator.AssertOnPositiveValue(value, selectedRectangleHeightTextBox.ToString());

                dtFlag = false;

                _rectangles[index].Length = value;
                _rectanglePanels[index].Height = value;

                rectangleColListBox.Items.RemoveAt(index);
                rectangleColListBox.Items.Insert(index, _rectangles[index]);

                dtFlag = true;
                FindCollision();

                // Changing TextBox color to white
                if (selectedRectangleHeightTextBox.BackColor != ColorTranslator.FromHtml("#FFFFFF"))
                {
                    selectedRectangleHeightTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                }
            }
            catch
            {
                // Changing TextBox color to LightPink
                selectedRectangleHeightTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
            }
        }

        /// <summary>
        /// Update collisions
        /// </summary>
        private void FindCollision()
        {
            foreach (Panel panel in _rectanglePanels)
            {
                panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            }
            for (int i = 0; i < _rectanglePanels.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectanglePanels.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }

        /// <summary>
        /// Update rectangle information
        /// </summary>
        /// <param name="rectangle"></param>

        private void UpdateRectangleInfo(Rectangular rectangle)
        {
            selectedRectangleIDTextBox.Text = rectangle.ID.ToString();
            selectedRectangleXTextBox.Text = rectangle.Center.X.ToString();
            selectedRectangleYTextBox.Text = rectangle.Center.Y.ToString();
            selectedRectangleWidthTextBox.Text = rectangle.Width.ToString();
            selectedRectangleHeightTextBox.Text = rectangle.Length.ToString();
        }

        /// <summary>
        /// Clear rectangle information
        /// </summary>
        private void ClearRectangleInfo()
        {
            selectedRectangleIDTextBox.Text = String.Empty;
            selectedRectangleXTextBox.Text = String.Empty;
            selectedRectangleYTextBox.Text = String.Empty;
            selectedRectangleWidthTextBox.Text = String.Empty;
            selectedRectangleHeightTextBox.Text = String.Empty;
        }
    }
}
