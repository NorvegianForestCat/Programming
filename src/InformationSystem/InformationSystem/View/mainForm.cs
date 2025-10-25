using InformationSystem.Model;
using InformationSystem.Model.Handlers;
using InformationSystem.Model.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace InformationSystem
{
    /// <summary>
    /// Main form for managing a music playlist.
    /// Supports adding, editing, deleting, and persisting songs to disk.
    /// </summary>
    public partial class mainForm : Form
    {
        private List<Song>? _songs;
        private Song? _currentSong;
        private readonly int _durationThreshold = 7200;
        private readonly string _playlistPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="mainForm"/> class.
        /// </summary>
        public mainForm()
        {
            InitializeComponent();

            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            _playlistPath = Path.Combine(appDataPath, "InformationSystem", "playlist.json");

            _songs = new List<Song>();
            genreComboBox.DataSource = Enum.GetValues<Genre>();
        }

        /// <summary>
        /// Handles form load. Asynchronously loads saved playlist from disk if it exists.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private async void mainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(_playlistPath)) return;

            try
            {
                await using FileStream stream = File.OpenRead(_playlistPath);
                var loadedSongs = await JsonSerializer.DeserializeAsync<List<Song>>(stream);

                if (loadedSongs == null) return;

                _songs = loadedSongs;
                ListHandler.UpdateSongsListBox(songsListBox, _songs);
                ListHandler.SortSongsByArtistAndTitle(_songs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to load playlist: {ex.Message}\n" +
                    "A new playlist will be created.",
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                _songs = new List<Song>();
            }
        }

        /// <summary>
        /// Handles form closing. Saves the current playlist to disk asynchronously.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private async void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_songs == null) return;

            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_playlistPath)!);

                await using FileStream stream = File.Create(_playlistPath);
                await JsonSerializer.SerializeAsync(stream, _songs, new JsonSerializerOptions { WriteIndented = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to save playlist: {ex.Message}",
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles changes to the title text box. Validates input length.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateAndLimitText(titleTextBox, Validator.IsValidString);
        }

        /// <summary>
        /// Handles changes to the artist text box. Validates input length.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void artistTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateAndLimitText(artistTextBox, Validator.IsValidString);
        }

        /// <summary>
        /// Handles changes to the duration text box. Ensures value is valid and below threshold.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void durationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(durationTextBox.Text)) return;

            if (int.TryParse(durationTextBox.Text, out int duration))
            {
                if (duration >= 0 && duration < _durationThreshold)
                {
                    ApplyValidStyle(durationTextBox);
                }
                else
                {
                    ApplyErrorStyle(durationTextBox);
                    ShowValidationMessage($"Duration must be between 0 and {_durationThreshold - 1} seconds.");
                }
            }
            else
            {
                ApplyErrorStyle(durationTextBox);
                ShowValidationMessage("Duration must be a valid integer.");
            }
        }

        /// <summary>
        /// Applies validation logic to a TextBox with a string validator.
        /// </summary>
        /// <param name="textBox">The TextBox to validate.</param>
        /// <param name="validator">The validation function.</param>
        private static void ValidateAndLimitText(TextBox textBox, Action<string?> validator)
        {
            if (string.IsNullOrEmpty(textBox.Text)) return;

            try
            {
                validator(textBox.Text);
                ApplyValidStyle(textBox);
            }
            catch (ArgumentException)
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                textBox.SelectionStart = textBox.Text.Length;

                ApplyErrorStyle(textBox);
                ShowValidationMessage("Text must be 50 characters or fewer.");
            }
        }

        /// <summary>
        /// Handles click on the "Add" button. Adds a new song to the list.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (!TryCreateCurrentSong(out _currentSong)) return;

            _songs?.Add(_currentSong);
            UpdateSongList();
        }

        /// <summary>
        /// Handles click on the "Edit" button. Updates the selected song's properties.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void editButton_Click(object sender, EventArgs e)
        {
            if (songsListBox.SelectedIndex == -1 || _currentSong == null || _songs == null) return;

            if (!TryUpdateCurrentSong()) return;

            UpdateSongList();
        }

        /// <summary>
        /// Handles selection change in the songs list. Loads selected song into input fields.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void songsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (songsListBox.SelectedIndex == -1 || _songs == null) return;

            _currentSong = _songs[songsListBox.SelectedIndex];
            LoadSongToUi(_currentSong);
        }

        /// <summary>
        /// Handles click on the "Delete" button. Removes the selected song from the list.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (songsListBox.SelectedIndex == -1 || _songs == null) return;

            _songs.RemoveAt(songsListBox.SelectedIndex);
            UpdateSongList();
            ClearInputFields();
        }

        /// <summary>
        /// Attempts to create a new song from input fields.
        /// </summary>
        /// <param name="song">The created song, if successful.</param>
        /// <returns><see langword="true"/> if song was created; otherwise, <see langword="false"/>.</returns>
        private bool TryCreateCurrentSong(out Song? song)
        {
            song = null;

            if (!ValidateInputs()) return false;

            if (!int.TryParse(durationTextBox.Text, out int duration))
                return false;

            song = new Song(titleTextBox.Text, artistTextBox.Text, duration, (Genre)genreComboBox.SelectedItem);
            return true;
        }

        /// <summary>
        /// Attempts to update the current song with input field values.
        /// </summary>
        /// <returns><see langword="true"/> if update succeeded; otherwise, <see langword="false"/>.</returns>
        private bool TryUpdateCurrentSong()
        {
            if (!ValidateInputs() || _currentSong == null) return false;

            if (!int.TryParse(durationTextBox.Text, out int duration))
                return false;

            _currentSong.Title = titleTextBox.Text;
            _currentSong.Name = artistTextBox.Text;
            _currentSong.Duration = duration;
            _currentSong.Genre = (Genre)genreComboBox.SelectedItem;

            return true;
        }

        /// <summary>
        /// Validates required input fields.
        /// </summary>
        /// <returns><see langword="true"/> if all inputs are valid; otherwise, <see langword="false"/>.</returns>
        private bool ValidateInputs()
        {
            return !string.IsNullOrWhiteSpace(titleTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(artistTextBox.Text) &&
                   genreComboBox.SelectedItem is Genre;
        }

        /// <summary>
        /// Loads a song's data into the input fields.
        /// </summary>
        /// <param name="song">The song to display.</param>
        private void LoadSongToUi(Song song)
        {
            artistTextBox.Text = song.Name ?? string.Empty;
            titleTextBox.Text = song.Title ?? string.Empty;
            durationTextBox.Text = song.Duration.ToString();
            genreComboBox.SelectedItem = song.Genre;
        }

        /// <summary>
        /// Updates the song list by sorting and refreshing the ListBox.
        /// </summary>
        private void UpdateSongList()
        {
            ListHandler.SortSongsByArtistAndTitle(_songs!);
            ListHandler.UpdateSongsListBox(songsListBox, _songs!);
        }

        /// <summary>
        /// Clears all input fields.
        /// </summary>
        private void ClearInputFields()
        {
            artistTextBox.Clear();
            titleTextBox.Clear();
            durationTextBox.Clear();
            genreComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Applies error visual style (pink background) to a TextBox.
        /// </summary>
        /// <param name="textBox">The TextBox to highlight.</param>
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
        /// Shows a validation error message to the user.
        /// </summary>
        /// <param name="message">The message to display.</param>
        private static void ShowValidationMessage(string message)
        {
            MessageBox.Show(message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}