﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Services;

namespace Programming.Model
{
    class Song
    {
        int _durationInSeconds;
        string? _songName;
        string? _artistName;

        // string SongName, any string value
        public string? SongName { get; set; }
        //string ArtistName, any string value
        public string? ArtistName { get; set; }
        // int DurationInSeconds, int value above 0. In another cases - ArgumentException
        public int DurationInSeconds
        {
            get 
            { 
                return _durationInSeconds; 
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Duration");
                _durationInSeconds = value;                
            }
        }

        // Base constructor without arguments
        public Song()
        {
            SongName = "Wind of Changes";
            ArtistName = "Scorpions";

            DurationInSeconds = 311;
        }

        // Constructor with arguments
        public Song(string songName, string artistName, int duration)
        {
            SongName = songName;
            ArtistName = artistName;

            DurationInSeconds = duration;
        }
    }
}
