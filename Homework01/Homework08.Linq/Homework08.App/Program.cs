using Homework08.Linq.Database.Database;
using System;
using System.Collections.Generic;

namespace Homework08.Linq.App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var personRepository = new PersonRepository();

            personRepository.AddAllSongsThatStartWithLetterBToPersonJerry();
            var allPersons = personRepository.GetAllPersons();
            allPersons[0].GetFavSongs();

            Console.WriteLine("-------------");
            personRepository.AddAllSongsLongerThanSixMinutesToPersonMaria();
            allPersons[2].GetFavSongs();

            Console.WriteLine("-------------");
            personRepository.AddAllRockSongsToPersonJane();
            allPersons[3].GetFavSongs();

            Console.WriteLine("-------------");
            personRepository.AddAllHipHopSongsShortThan3MinToPersonStefan();
            allPersons[1].GetFavSongs();

            Console.WriteLine("-------------");
            var personList = personRepository.GetAllPersonWithMoreThan4Songs();
            foreach(var p in personList)
            {
                Console.WriteLine($"Name: {p.FirstName}");
            }

            Console.ReadLine();
        }
    }
}
