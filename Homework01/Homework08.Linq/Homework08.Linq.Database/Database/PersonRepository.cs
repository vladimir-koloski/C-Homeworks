using Homework08.Linq.Enumerations;
using Homework08.Linq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework08.Linq.Database.Database
{
    public class PersonRepository : Database
    {

        public List<Person> GetAllPersons()
        {
            return FansArray;
        }
        public void AddAllSongsThatStartWithLetterBToPersonJerry()
        {
            var person1 = FansArray.FirstOrDefault(person => person.FirstName == "Jerry");
            person1.FavoriteSongs = Songs.Where(song => song.Title.StartsWith("B")).ToList();
            
        }

        public void AddAllSongsLongerThanSixMinutesToPersonMaria()
        {
            var person1 = FansArray.FirstOrDefault(person => person.FirstName == "Maria");
            person1.FavoriteSongs = Songs.Where(song => song.Length >= 360).ToList();
        }

        public void AddAllRockSongsToPersonJane()
        {
            var person1 = FansArray.FirstOrDefault(person => person.FirstName == "Jane");
            person1.FavoriteSongs = Songs.Where(song => song.Genre == Genre.Rock).ToList();
        }

        public void AddAllHipHopSongsShortThan3MinToPersonStefan()
        {
            var person1 = FansArray.FirstOrDefault(person => person.FirstName == "Stefan");
            person1.FavoriteSongs = Songs.Where(song => song.Genre == Genre.Hip_Hop && song.Length <= 180).ToList();
        }

        public List<Person> GetAllPersonWithMoreThan4Songs()
        {
            return FansArray
                .Where(person => person.FavoriteSongs.Count >= 4)
                .ToList();
            
        }


    }
}
