using InformationSystem.Model;
using InformationSystem.Model.Service;
using InformationSystem.Model.Handlers;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace InformationSystem
{
    /// <summary>
    /// Main form class
    /// </summary>
    public partial class mainForm : Form
    {
        List<Song>? songs;
        Song? currentSong;
        int durationThreshold;
        string appDataPath;

        /// <summary>
        /// Main form constructor
        /// </summary>
        public mainForm()
        {
            InitializeComponent();

            songs = new List<Song>();
            currentSong = null;
            durationThreshold = 7200;
            // Path to %APPDATA%
            appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            genreComboBox.DataSource = Enum.GetValues(typeof(Genre));
        }

        /// <summary>
        /// Asynchronic load form method
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        /// <exception cref="NullReferenceException">throw if serializer returns null</exception>
        private async void mainForm_Load(object sender, EventArgs e)
        {
            // Check if file exists. If yes then read onto it
            if (File.Exists(appDataPath + @"\playlist.json"))
            {
                using FileStream readStream = new FileStream(appDataPath + @"\playlist.json", FileMode.OpenOrCreate);
                var deserializedPlaylist = await JsonSerializer.DeserializeAsync<List<Song>>(readStream);

                if (deserializedPlaylist == null || songs == null) throw new NullReferenceException();

                foreach (Song song in deserializedPlaylist)
                {
                    songsListBox.Items.Add(song);
                    songs.Add(song);
                }
            }
            // If file doesn`t exist create it
            else
            {
                using (FileStream readStream = File.Create(appDataPath + @"\playlist.json")) { }
            }
        }

        /// <summary>
        /// Form closing method
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            using FileStream writeStream = File.Create(appDataPath + @"\playlist.json");
            JsonSerializer.SerializeAsync(writeStream, songs);
        }

        /// <summary>
        /// titleTextBox changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            // Empty string checker
            if (titleTextBox.Text == string.Empty) return;

            // Validation
            try
            {
                Validator.IsValidString(titleTextBox.Text);
            }
            catch (ArgumentException ex)
            {
                titleTextBox.Text = titleTextBox.Text.Remove(titleTextBox.Text.Length - 1);
                MessageBox.Show($"ArgumentException: {ex.Message}");
            }
        }

        /// <summary>
        /// artistTextBox changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void artistTextBox_TextChanged(object sender, EventArgs e)
        {
            // Empty string checker
            if (artistTextBox.Text == string.Empty) return;

            // Validation
            try
            {
                Validator.IsValidString(artistTextBox.Text);
            }
            catch (ArgumentException argumentException)
            {
                artistTextBox.Text = artistTextBox.Text.Remove(artistTextBox.Text.Length - 1);
                MessageBox.Show($"ArgumentException: {argumentException.Message}");

                return;
            }
        }

        /// <summary>
        /// durationTextBox changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void durationTextBox_TextChanged(object sender, EventArgs e)
        {
            // Empty string checker
            if (durationTextBox.Text == string.Empty) return;

            // Validation
            try
            {
                Validator.IsLessThan(int.Parse(durationTextBox.Text), durationThreshold);
            }
            catch (FormatException formatException)
            {
                durationTextBox.Text = string.Empty;

                MessageBox.Show($"FormatException: {formatException.Message}");

                return;
            }
            catch (ArgumentException argumentException)
            {
                durationTextBox.Text = string.Empty;

                MessageBox.Show($"ArgumentException: {argumentException.Message}");

                return;
            }
        }

        /// <summary>
        /// Adding new song instance event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void addButton_Click(object sender, EventArgs e)
        {
            // Empty string checker and null-pointer checker
            if (durationTextBox.Text == string.Empty || artistTextBox.Text == string.Empty || titleTextBox.Text == string.Empty || songs == null) return;

            // new song instance
            currentSong = new Song(titleTextBox.Text, artistTextBox.Text, int.Parse(durationTextBox.Text), (Genre)genreComboBox.SelectedItem);
            songs.Add(currentSong);

            // Processing list of songs
            ListHandler.SortingList(songs);
            ListHandler.SongsListBoxUpdate(songsListBox, songs);
        }

        /// <summary>
        /// Editing song instance info evnt
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void editButton_Click(object sender, EventArgs e)
        {
            // Empty string checker and null-pointer checker and negative-pointer checker
            if (songsListBox.SelectedIndex == -1 || durationTextBox.Text == string.Empty ||
                artistTextBox.Text == string.Empty || titleTextBox.Text == string.Empty ||
                currentSong == null || songs == null) return;

            // Editing current song instance
            currentSong.Name = artistTextBox.Text;
            currentSong.Title = titleTextBox.Text;
            currentSong.Duration = int.Parse(durationTextBox.Text);
            currentSong.Genre = (Genre)genreComboBox.SelectedItem;

            // Processing list of songs
            ListHandler.SortingList(songs);
            ListHandler.SongsListBoxUpdate(songsListBox, songs);
        }

        /// <summary>
        /// Changed selected index of songsListBox event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void songsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Null-pointer checker and negative-pointer checker
            if (songsListBox.SelectedIndex == -1 || songs == null) return;

            currentSong = songs[songsListBox.SelectedIndex];

            // Showing song info
            artistTextBox.Text = currentSong.Name;
            titleTextBox.Text = currentSong.Title;
            durationTextBox.Text = currentSong.Duration.ToString();
            genreComboBox.SelectedItem = currentSong.Genre;

        }

        /// <summary>
        /// Deleting song instance event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Null-pointer checker and negative-pointer checker
            if (songsListBox.SelectedIndex == -1 || songs == null) return;

            // Deleting song instance
            songs.RemoveAt(songsListBox.SelectedIndex);

            // Processing list of songs
            ListHandler.SortingList(songs);
            ListHandler.SongsListBoxUpdate(songsListBox, songs);
        }
    }
}