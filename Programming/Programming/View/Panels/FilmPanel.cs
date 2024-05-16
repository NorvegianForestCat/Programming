using Programming.Model.Geometry;
using Programming.Model;
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
    /// Custom user control for film panel
    /// </summary>
    public partial class FilmPanel : UserControl
    {
        /// <summary>
        /// Nessesary fields
        /// </summary>
        private Film[] _films;
        private Film _currentFilm;
        private const int _numberOfFilms = 5;
        private Random rand;

        /// <summary>
        /// Constructor
        /// </summary>
        public FilmPanel()
        {
            InitializeComponent();
            _films = new Film[_numberOfFilms]; // Initialize films array
            rand = new Random();


            // Filling films array and "linked" each with filmsListBox element
            for (int i = 0; i < _numberOfFilms; i++)
            {
                string filmTitle = "B:MCS";
                string filmGenre = "Music";
                int filmDuration = rand.Next(600);
                int filmYear = rand.Next(1901, DateTime.Now.Year + 1);
                double filmRating = rand.Next(10) + (rand.NextDouble());

                _films[i] = new Film(filmTitle, filmGenre, filmDuration, filmYear, filmRating);
                filmsListBox.Items.Add($"Film {i + 1}");
            }
        }

        /// <summary>
        /// Event handling filmsListBox_SelectedIndexChanged
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void filmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Fools-check
            if (filmsListBox.SelectedIndex < 0) return;

            // Choose a correct film following selected
            _currentFilm = _films[filmsListBox.SelectedIndex];

            // Filling fields of object
            titleTextBox.Text = _currentFilm.Title;
            genreTextBox.Text = _currentFilm.Genre;
            durationTextBox.Text = _currentFilm.Duration.ToString();
            releaseYearTextBox.Text = _currentFilm.ReleaseYear.ToString();
            ratingTextBox.Text = _currentFilm.Rating.ToString();
        }

        /// <summary>
        /// Event handling filmsListBox_SelectedIndexChanged
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void genreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Genre = genreTextBox.Text; // Collecting genre value
        }

        /// <summary>
        /// Event handling filmsListBox_SelectedIndexChanged
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Title = titleTextBox.Text; // Collecting title value
        }

        /// <summary>
        /// Event handling filmsListBox_SelectedIndexChanged
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void durationTextBox_TextChanged(object sender, EventArgs e)
        {
            // Error-checker
            try
            {
                _currentFilm.Duration = int.Parse(durationTextBox.Text); // Collecting duration value

                // Changing TextBox color to white
                if (durationTextBox.BackColor != ColorTranslator.FromHtml("#FFFFFF"))
                {
                    durationTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                }
            }
            catch
            {
                // Changing TextBox color to LightPink
                durationTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
            }
        }

        /// <summary>
        /// Event handling releaseYearTextBox_TextChanged
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void releaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            // Error-checker
            try
            {
                _currentFilm.ReleaseYear = int.Parse(releaseYearTextBox.Text); // Collecting release year value

                // Changing TextBox color to white
                if (releaseYearTextBox.BackColor != ColorTranslator.FromHtml("#FFFFFF"))
                {
                    releaseYearTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                }
            }
            catch
            {
                // Changing TextBox color to LightPink
                releaseYearTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
            }
        }

        /// <summary>
        /// Event handling ratingTextBox_TextChanged
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void ratingTextBox_TextChanged(object sender, EventArgs e)
        {
            // Error-checker
            try
            {
                _currentFilm.Rating = double.Parse(ratingTextBox.Text); // Collecting rating value

                // Changing TextBox color to white
                if (ratingTextBox.BackColor != ColorTranslator.FromHtml("#FFFFFF"))
                {
                    ratingTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                }
            }
            catch
            {
                // Changing TextBox color to LightPink
                ratingTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
            }
        }

        /// <summary>
        /// Find film with max rating
        /// </summary>
        /// <param name="filmArray">Array of films</param>
        /// <returns>Rating</returns>
        private int FindFilmWithMaxRating(Film[] filmArray)
        {
            double maxRating = filmArray[0].Rating;
            int maxRatingIndex = 0;

            // Finding max rating index
            for (int i = 0; i < filmArray.Length; i++)
            {
                if (filmArray[i].Rating >= maxRating)
                {
                    maxRating = filmArray[i].Rating;
                    maxRatingIndex = i;
                }
            }

            return maxRatingIndex;
        }

        /// <summary>
        /// Event handling filmFindButton_Click
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void filmFindButton_Click(object sender, EventArgs e)
        {
            int maxRatingIndex = FindFilmWithMaxRating(_films); // Found max rating index
            filmsListBox.SelectedIndex = maxRatingIndex; // Changing index of selected element
        }
    }
}
