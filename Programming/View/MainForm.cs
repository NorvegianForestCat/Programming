using Programming.Model;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Windows.Markup;
using System.Drawing;
using System.Drawing.Design;

namespace Programming
{
    public partial class MainForm : Form
    {
        private Rectangular[] _rectangles;
        private Rectangular _currentRectangle;
        private Film[] _films;
        private Film _currentFilm;
        private const int _numberOfFilms = 5;
        private const int _numberOfRectangles = 5;

        public MainForm()
        {
            InitializeComponent();

            weekdayValidLabel.Text = String.Empty; // Clear the label for selected weekday
            enumsListBox.SelectedIndex = 0; // Set a base element for enums list

            chooseSeasonComboBox.DataSource = Enum.GetValues(typeof(Season)); // Filling a season ComboBox

            _rectangles = new Rectangular[_numberOfRectangles]; // Initialize rectangulars array
            _films = new Film[_numberOfFilms]; // Initialize films array

            Random rand = new Random(); // Create a Random object

            // Filling rectangular array and "linked" each with rectangleListBox element
            for (int i = 0; i < _numberOfRectangles; i++)
            {
                _rectangles[i] = new Rectangular(rand.Next(), rand.Next(), "White");
                rectangleListBox.Items.Add($"Rectangular {i + 1}");
            }

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

        // Filling a values list
        private void InitializeValueListBox(Enum selectedEnum)
        {
            valueListBox.Items.Clear(); // Clear values list from existed values

            // Filling values list by new values from selectedEnum
            foreach (Enum enumElement in Enum.GetValues(selectedEnum.GetType()))
            {
                valueListBox.Items.Add(enumElement);
            }
        }

        private void valueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Writing an int representation of selected enum element
            intValueTextBox.Text = ((int)valueListBox.SelectedItem).ToString();
        }

        private void parseWeekdayButton_Click(object sender, EventArgs e)
        {
            // Fool-check
            if (weekdayValueTextBox.Text == String.Empty) return;

            // Validating entered text in WeekdayValuetextBox by occurence in Weekday enum
            if (Enum.TryParse(weekdayValueTextBox.Text, out Weekday enteredDay) && Enum.IsDefined(typeof(Weekday), enteredDay))
            {
                // Changing a text according to entered day
                weekdayValidLabel.Text = $"��� ���� ������ ({enteredDay.ToString()} = {(int)enteredDay})";
            }
            else
            {
                // "This object does not exist" message
                weekdayValidLabel.Text = "��� ������ ��� ������";
            }
        }

        private void chooseSeasonButton_Click(object sender, EventArgs e)
        {
            // Fool-check
            if (chooseSeasonComboBox.SelectedItem == null) return;

            // Performing some operations according to selected season 
            switch (chooseSeasonComboBox.SelectedItem)
            {
                case Season.Summer:
                    // Showing a message box with some text (���! ������!)
                    MessageBox.Show("���! ������!");
                    break;
                case Season.Winter:
                    // Showing a message box with some text (����! �������!)
                    MessageBox.Show("����! �������!");
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

        private void rectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Fools-check
            if (rectangleListBox.SelectedIndex > rectangleListBox.Items.Count) return;

            // Choose a correct rectangle following selected
            _currentRectangle = _rectangles[rectangleListBox.SelectedIndex];

            // Filling fields of object
            lengthTextBox.Text = _currentRectangle.Length.ToString();
            widthTextBox.Text = _currentRectangle.Width.ToString();
            rectColorTextBox.Text = _currentRectangle.Color.ToString();
        }

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

        private void rectColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = rectColorTextBox.Text; // Collecting color value
        }
        
        // Finding index of rectangular with max width
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

        private void rectFindButton_Click(object sender, EventArgs e)
        {
            int maxWidthIndex = FindRectangleWithMaxWidth(_rectangles); // Found max width index
            rectangleListBox.SelectedIndex = maxWidthIndex; // Changing index of selected element
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Title = titleTextBox.Text; // Collecting title value
        }

        private void filmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Fools-check
            if (filmsListBox.SelectedIndex > filmsListBox.Items.Count) return;

            // Choose a correct film following selected
            _currentFilm = _films[filmsListBox.SelectedIndex];

            // Filling fields of object
            titleTextBox.Text = _currentFilm.Title;
            genreTextBox.Text = _currentFilm.Genre;
            durationTextBox.Text = _currentFilm.Duration.ToString();
            releaseYearTextBox.Text = _currentFilm.ReleaseYear.ToString();
            ratingTextBox.Text = _currentFilm.Rating.ToString();
        }

        private void genreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Genre = genreTextBox.Text; // Collecting genre value
        }

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

        // Finding index of film with max rating
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

        private void filmFindButton_Click(object sender, EventArgs e)
        {
            int maxRatingIndex = FindFilmWithMaxRating(_films); // Found max rating index
            filmsListBox.SelectedIndex = maxRatingIndex; // Changing index of selected element
        }
    }
}