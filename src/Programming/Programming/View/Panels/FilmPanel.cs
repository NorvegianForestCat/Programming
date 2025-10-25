using Programming.Model;
using Programming.Model.Geometry;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    /// A user control for managing and displaying a collection of films.
    /// Allows viewing, editing film properties, and finding the film with the highest rating.
    /// </summary>
    public partial class FilmPanel : UserControl
    {
        private readonly Film[] _films;
        private Film _currentFilm = null!;
        private const int NumberOfFilms = 5;
        private readonly Random _random = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilmPanel"/> class.
        /// Populates the film list with random test data.
        /// </summary>
        public FilmPanel()
        {
            InitializeComponent();

            _films = new Film[NumberOfFilms];

            for (int i = 0; i < NumberOfFilms; i++)
            {
                var title = $"B:MCS {i + 1}";
                var genre = GetRandomGenre();
                var duration = _random.Next(60, 180);
                var year = _random.Next(1901, DateTime.Now.Year + 1);
                var rating = Math.Round(_random.NextDouble() * 10, 1);

                _films[i] = new Film(title, genre, duration, year, rating);
                filmsListBox.Items.Add($"Film {i + 1}");
            }

            // Выбираем первый фильм
            filmsListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Handles selection change in the films list. Updates UI fields with selected film's data.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void filmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filmsListBox.SelectedIndex < 0) return;

            _currentFilm = _films[filmsListBox.SelectedIndex];
            UpdateUiFromCurrentFilm();
        }

        /// <summary>
        /// Updates all text boxes to reflect the current film's properties.
        /// </summary>
        private void UpdateUiFromCurrentFilm()
        {
            titleTextBox.Text = _currentFilm.Title ?? string.Empty;
            genreTextBox.Text = _currentFilm.Genre.ToString();
            durationTextBox.Text = _currentFilm.Duration.ToString();
            releaseYearTextBox.Text = _currentFilm.ReleaseYear.ToString();
            ratingTextBox.Text = _currentFilm.Rating.ToString("F1");
        }

        /// <summary>
        /// Handles changes to the title text box. Updates the current film's title.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Title = titleTextBox.Text;
        }

        /// <summary>
        /// Handles changes to the genre text box. Attempts to parse input as <see cref="Genre"/>.
        /// Invalid input is ignored and visual error style is applied.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void genreTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Enum.TryParse<Genre>(genreTextBox.Text, ignoreCase: true, out var genre))
            {
                _currentFilm.Genre = genre;
                ClearErrorStyle(genreTextBox);
            }
            else
            {
                ApplyErrorStyle(genreTextBox);
            }
        }

        /// <summary>
        /// Handles changes to the duration text box. Validates input as positive integer.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void durationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(durationTextBox.Text, out int duration) && duration > 0)
            {
                _currentFilm.Duration = duration;
                ClearErrorStyle(durationTextBox);
            }
            else
            {
                ApplyErrorStyle(durationTextBox);
            }
        }

        /// <summary>
        /// Handles changes to the release year text box. Validates input within reasonable range.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void releaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(releaseYearTextBox.Text, out int year) &&
                year >= 1900 && year <= DateTime.Now.Year + 1)
            {
                _currentFilm.ReleaseYear = year;
                ClearErrorStyle(releaseYearTextBox);
            }
            else
            {
                ApplyErrorStyle(releaseYearTextBox);
            }
        }

        /// <summary>
        /// Handles changes to the rating text box. Validates input between 0.0 and 10.0 inclusive.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void ratingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(ratingTextBox.Text, out double rating) &&
                rating >= 0.0 && rating <= 10.0)
            {
                _currentFilm.Rating = rating;
                ClearErrorStyle(ratingTextBox);
            }
            else
            {
                ApplyErrorStyle(ratingTextBox);
            }
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
        private static void ClearErrorStyle(TextBox textBox)
        {
            textBox.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Finds the index of the film with the highest rating.
        /// </summary>
        /// <param name="filmArray">The array of films to search.</param>
        /// <returns>The index of the film with the maximum rating.</returns>
        /// <exception cref="ArgumentException">Thrown when the array is null or empty.</exception>
        private static int FindFilmWithMaxRating(Film[] filmArray)
        {
            if (filmArray == null || filmArray.Length == 0)
                throw new ArgumentException("Film array cannot be null or empty.", nameof(filmArray));

            return filmArray
                .Select((film, index) => new { film.Rating, index })
                .OrderByDescending(x => x.Rating)
                .First().index;
        }

        /// <summary>
        /// Handles click on the "Find Best Film" button. Selects the film with the highest rating.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void filmFindButton_Click(object sender, EventArgs e)
        {
            int maxRatingIndex = FindFilmWithMaxRating(_films);
            filmsListBox.SelectedIndex = maxRatingIndex;
        }

        /// <summary>
        /// Returns a random value from the <see cref="Genre"/> enumeration.
        /// </summary>
        /// <returns>A random genre.</returns>
        private Genre GetRandomGenre()
        {
            var genres = Enum.GetValues<Genre>();
            return genres[_random.Next(genres.Length)];
        }
    }
}