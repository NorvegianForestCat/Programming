using System;
using System.Collections.Generic;
using System.Linq;

namespace InformationSystem.Model.Handlers
{
    /// <summary>
    /// Provides static methods for processing and managing collections of <see cref="Song"/>.
    /// Includes operations for updating UI controls and sorting lists.
    /// </summary>
    internal static class ListHandler
    {
        /// <summary>
        /// Updates the specified ListBox with items from the song list.
        /// Clears existing items and adds each song using its <see cref="object.ToString()"/> representation.
        /// </summary>
        /// <param name="listBox">The ListBox to update. Must not be <see langword="null"/>.</param>
        /// <param name="songList">The list of songs to display. Must not be <see langword="null"/>.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="listBox"/> or <paramref name="songList"/> is <see langword="null"/>.
        /// </exception>
        public static void UpdateSongsListBox(ListBox listBox, List<Song> songList)
        {
            if (listBox == null)
                throw new ArgumentNullException(nameof(listBox));
            if (songList == null)
                throw new ArgumentNullException(nameof(songList));

            listBox.Items.Clear();
            foreach (var song in songList)
            {
                listBox.Items.Add(song);
            }
        }

        /// <summary>
        /// Sorts the specified list of songs by artist name, then by title (alphabetically).
        /// Uses stable ascending sort order.
        /// </summary>
        /// <param name="songs">The list of songs to sort. Must not be <see langword="null"/>.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="songs"/> is <see langword="null"/>.
        /// </exception>
        public static void SortSongsByArtistAndTitle(List<Song> songs)
        {
            if (songs == null)
                throw new ArgumentNullException(nameof(songs));

            var sortedArray = songs
                .OrderBy(s => s.Name ?? string.Empty, StringComparer.OrdinalIgnoreCase)
                .ThenBy(s => s.Title ?? string.Empty, StringComparer.OrdinalIgnoreCase)
                .ToArray();

            songs.Clear();
            songs.AddRange(sortedArray);
        }
    }
}