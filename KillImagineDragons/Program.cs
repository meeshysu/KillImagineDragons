using System;
using System.Collections.Generic;
using System.Linq;

namespace KillImagineDragons
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodSongs = new List<Song>();
            var allSongs = new List<Song>()
            {
                new Song("Imagine Dragons", "Bleeding Out"),
                new Song("Imagine Dragons", "Whatever It Takes"),
                new Song("Imagine Dragons", "Friction"),
                new Song("Imagine Dragons", "Amsterdam"),
                new Song("Imagine Dragons", "Shots"),
                new Song("The Midnight", "Gloria"),
                new Song("Bastille", "Happier"),
                new Song("311", "Crack the Code"),
                new Song("Incubus", "The Warmth"),
                new Song("Imagine Dragons", "Whatever It Takes"),
                new Song("Florence + The Machine", "No Light, No Light"),
                new Song("K/DA", "Popstar"),
            };

            goodSongs = allSongs.Where(song => song.Artist != "Imagine Dragons").ToList();

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist}, {song.Name} is much better than Imagine Dragons.");
            }

            Console.ReadLine();
        }
    }
}
