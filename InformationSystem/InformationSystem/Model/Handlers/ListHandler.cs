using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem.Model.Handlers
{
    /// <summary>
    /// Static class that providing list processing methods
    /// </summary>
    internal static class ListHandler
    {
        /// <summary>
        /// Updates <see cref="T:System.Windows.Forms.ListBox"/> with List<Song>
        /// </summary>
        /// <param name="listBox">Updated <see cref="T:System.Windows.Forms.ListBox"/> value</param>
        /// <param name="songList">New list value</param>
        public static void SongsListBoxUpdate(ListBox listBox, List<Song> songList)
        {
            listBox.Items.Clear();
            foreach (Song song in songList)
            {
                listBox.Items.Add(song);
            }
        }

        /// <summary>
        /// <see cref="T:System.Collections.Generic.List<T>"/> sorting
        /// </summary>
        /// <param name="songs">Sorting <see cref="T:System.Collections.Generic.List<T>"/> </param>
        public static void SortingList(List<Song> songs)
        {
            bool isSorted = false; // Sorting flag

            // List sorting
            while (!isSorted)
            {
                isSorted = true;

                for (int i = 0; i < songs.Count - 1; i++)
                {
                    // If different artist names
                    if (!(String.Compare(songs[i].Name, songs[i + 1].Name) <= 0))
                    {
                        isSorted = false;

                        Song dSong = songs[i];
                        songs[i] = songs[i + 1];
                        songs[i + 1] = dSong;
                    }
                    // If different title but same artist name
                    else if (!(String.Compare(songs[i].Title, songs[i + 1].Title) <= 0) && (String.Compare(songs[i].Name, songs[i + 1].Name) == 0))
                    {
                        isSorted = false;

                        Song dSong = songs[i];
                        songs[i] = songs[i + 1];
                        songs[i + 1] = dSong;
                    }
                }
            }
        }
    }
}
