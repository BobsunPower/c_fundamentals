using System;
using System.Collections.Generic;

namespace x03.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); List<Song> songs = new List<Song>();
            for (int i = 0; i < n; i++) {string[] cmd = Console.ReadLine().Split("_");
                string type = cmd[0]; string name = cmd[1]; string time = cmd[2]; Song newSong = new Song(type, name, time);
                songs.Add(newSong);}
            string playlist = Console.ReadLine();
            if (playlist == "all") {
                foreach (var song in songs) {Console.WriteLine(song.Name);}}
            else {List<Song> filteredSongs = songs.FindAll(song => song.TypeList == playlist);
                foreach (var song in filteredSongs) {Console.WriteLine(song.Name);}}}
    }
    class Song
    {
        public Song(string type, string name, string time)
        {
            this.TypeList = type; this.Name = name; this.Time = time;
        }
        public string TypeList {get;set;}
        public string Name {get; set;}
        public string Time {get; set;}
    }
}
