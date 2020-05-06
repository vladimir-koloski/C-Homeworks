using Homework08.Linq.Enumerations;
using Homework08.Linq.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework08.Linq.Database.Database
{
    public class Database
    {
        protected List<Person> FansArray;
        protected List<Song> Songs;

        public Database()
        {
            FansArray = new List<Person>
            {
            new Person("Jerry", "Tompson", 78, Genre.Rock),
            new Person("Stefan", "Stefanoski", 28, Genre.Techno),
            new Person("Maria", "Campbel", 43, Genre.Classical),
            new Person("Jane", "Doe", 28, Genre.Techno)
            };

            Songs = new List<Song>
            {
            new Song("Bohemian Rhapsody", 367, Genre.Rock),
            new Song("Stairway To Heaven", 480, Genre.Rock),
            new Song("Riders On The Storm", 430, Genre.Rock),
            new Song("Not Fade Away", 108, Genre.Rock),
            new Song("Breaking Glass", 111, Genre.Rock),
            new Song("Welcome To The Jungle", 275, Genre.Rock),
            new Song("Walk Of Life", 266, Genre.Rock),
            new Song("Smoke on the Water", 340, Genre.Rock),
            new Song("93 'til Infinity", 209, Genre.Techno),
            new Song("Fight the Power", 321, Genre.Techno),
            new Song("The Message", 363, Genre.Techno),
            new Song("Butterfly Effect", 213, Genre.Techno),
            new Song("No Fear", 182, Genre.Techno),
            new Song("Hereditary", 340, Genre.Techno),
            new Song("Bounce Back", 226, Genre.Techno),
            new Song("The Four Seasons", 2520, Genre.Classical),
            new Song("Canon in D major", 376, Genre.Classical),
            new Song("Swan Lake", 461, Genre.Classical),
            new Song("Symphony No. 5", 425, Genre.Classical),
            new Song("Ride of the Valkyries", 608, Genre.Classical),
            new Song("The Magic Flute", 458, Genre.Classical),
            new Song("Carmen Suite No.1", 721, Genre.Classical),
            new Song("Planet E", 420, Genre.Techno),
            new Song("Phasor", 368, Genre.Techno),
            new Song("Counting Comets", 242, Genre.Techno),
            new Song("Cold Summer", 358, Genre.Techno),
            new Song("Destroyer", 359, Genre.Techno),
            new Song("Phalanx", 307, Genre.Techno),
            new Song("Vision", 693, Genre.Techno),
            new Song("Chain Reaction", 181, Genre.Techno)
            };
        }
    }    
        
}