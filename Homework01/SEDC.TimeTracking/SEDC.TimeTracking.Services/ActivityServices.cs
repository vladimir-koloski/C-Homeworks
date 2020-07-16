﻿using SEDC.TimeTracking.Domain.Entities;
using SEDC.TimeTracking.Domain.Enums;
using SEDC.TimeTracking.Services.Helpers;
using SEDC.TimeTracking.Services.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.TimeTracking.Services
{
    public class ActivityServices<T> where T : BaseActivity
    {
        public static Menu menus = new Menu();
        public void TrackingTime(ActivityType activity, User user)
        {
            Console.Clear();
            switch (activity)
            {
                case ActivityType.Reading:
                    var reading = new Reading();
                    reading.TrackTime();
                    Console.WriteLine("Please enter how many pages you've read and what kind Of book you were reading:");
                    Console.Write("Pages: ");
                    reading.Pages = ValidationHelpers.TryParseNumber(Console.ReadLine(), int.MaxValue);
                    reading.ReadingType = (ReadingType)menus.ShowBookTypes();
                    MessageHelpers.Message("Activity is succesfully tracked!", ConsoleColor.Green);
                    user.ListOfActivities.Add(reading);
                    break;
                case ActivityType.Exercising:
                    var exercising = new Exercising();
                    exercising.TrackTime();
                    Console.WriteLine("Please enter what kind of workout did you do");
                    exercising.ExercisingType = (ExercisingType)menus.ShowExercise();
                    MessageHelpers.Message("Activity is succesfully tracked!", ConsoleColor.Green);
                    user.ListOfActivities.Add(exercising);
                    break;
                case ActivityType.Working:
                    var working = new Working();
                    working.TrackTime();
                    Console.WriteLine("Where were you working from?");
                    working.WorkingType = (WorkingType)menus.ShowWorkingPlace();
                    MessageHelpers.Message("Activity is succesfully tracked!", ConsoleColor.Green);
                    user.ListOfActivities.Add(working);
                    break;
                case ActivityType.OtherHobbies:
                    var otherHobbies = new OtherHobbies();
                    otherHobbies.TrackTime();
                    Console.WriteLine("Please enter the name of the hobby");
                    otherHobbies.HobbyName = Console.ReadLine();
                    MessageHelpers.Message("Activity is succesfully tracked!", ConsoleColor.Green);
                    user.ListOfActivities.Add(otherHobbies);
                    break;
                default:
                    break;
            }
        }

        public void ReadingStatistics(User user)
        {
            Console.Clear();

            var allReadingAc = user.ListOfActivities.OfType<Reading>().ToList();

            if (!ValidationHelpers.CheckIfListIsEmpty(allReadingAc, "reading statistics")) return;

            var totalaReadingHours = allReadingAc.Sum(hours => hours.TrackedTime.Minutes);
            var averageReading = allReadingAc.Average(min => min.TrackedTime.Minutes);
            var totalPages = allReadingAc.Sum(pages => pages.Pages);

            // Favourite type

            int bellesLetters = allReadingAc.Where(x => x.ReadingType == ReadingType.BellesLettres).Count();
            int fiction = allReadingAc.Where(x => x.ReadingType == ReadingType.Fiction).Count();
            int profesionlLit = allReadingAc.Where(x => x.ReadingType == ReadingType.ProfessionalLiterature).Count();

            var readingDictionary = new Dictionary<ReadingType, int>()
            {
                {ReadingType.BellesLettres, bellesLetters },
                {ReadingType.Fiction, fiction },
                {ReadingType.ProfessionalLiterature, profesionlLit },
            };
            var favoritetype = readingDictionary.FirstOrDefault(type => type.Value == readingDictionary.Values.Max()).Key.ToString();

            StringBuilder sb = new StringBuilder();
            sb.Append($"Total reading hours: {totalaReadingHours}\n")
              .Append($"Average time spent reading: {averageReading} min\n")
              .Append($"Total number of read pages: {totalPages}\n")
              .Append($"Favourite type: {favoritetype}\n");

            Console.WriteLine(sb.ToString());
        }

        public void WorkingStatistics(User user)
        {
            Console.Clear();

            var allWorkingAc = user.ListOfActivities.OfType<Working>().ToList();

            if (!ValidationHelpers.CheckIfListIsEmpty(allWorkingAc, "working statistics")) return;

            var totalWorkingHours = allWorkingAc.Sum(hours => hours.TrackedTime.Minutes);
            var averageWorking = allWorkingAc.Average(min => min.TrackedTime.Minutes);
            var homeWorking = allWorkingAc.Where(working => working.WorkingType == WorkingType.FromHome)
                                            .Sum(hours => hours.TrackedTime.Hours);
            var officeWorking = allWorkingAc.Where(working => working.WorkingType == WorkingType.AtTheOffice)
                                            .Sum(hours => hours.TrackedTime.Hours);

            // Favourite type

            int home = allWorkingAc.Where(x => x.WorkingType == WorkingType.FromHome).Count();
            int office = allWorkingAc.Where(x => x.WorkingType == WorkingType.AtTheOffice).Count();

            var workingDictionary = new Dictionary<WorkingType, int>()
            {
                {WorkingType.FromHome, home },
                {WorkingType.AtTheOffice, office },
            };
            var favoritetype = workingDictionary.FirstOrDefault(type => type.Value == workingDictionary.Values.Max()).Key.ToString();

            StringBuilder sb = new StringBuilder();
            sb.Append($"Total working hours: {totalWorkingHours}\n")
              .Append($"Average time spent working: {averageWorking} min.\n")
              .Append($"Home worknig hours: {homeWorking}\n")
              .Append($"Office working hours {officeWorking}\n")
              .Append($"Favourite type: {favoritetype}\n");

            Console.WriteLine(sb.ToString());
        }

        public void ExercisingStatistics(User user)
        {
            Console.Clear();

            var allExercisingAc = user.ListOfActivities.OfType<Exercising>().ToList();

            if (!ValidationHelpers.CheckIfListIsEmpty(allExercisingAc, "exercising statistics")) return;

            var totalalExercisingHours = allExercisingAc.Sum(hours => hours.TrackedTime.Minutes);
            var averageExercising = allExercisingAc.Average(min => min.TrackedTime.Minutes);

            // Favourite type

            int running = allExercisingAc.Where(x => x.ExercisingType == ExercisingType.Running).Count();
            int general = allExercisingAc.Where(x => x.ExercisingType == ExercisingType.General).Count();
            int sport = allExercisingAc.Where(x => x.ExercisingType == ExercisingType.Sport).Count();

            var exercisingDictionary = new Dictionary<ExercisingType, int>()
            {
                {ExercisingType.Running, running },
                {ExercisingType.General, general },
                {ExercisingType.Sport, sport },
            };
            var favoritetype = exercisingDictionary.FirstOrDefault(type => type.Value == exercisingDictionary.Values.Max()).Key.ToString();

            StringBuilder sb = new StringBuilder();
            sb.Append($"Total exercising hours: {totalalExercisingHours}\n")
              .Append($"Average time spent exercising: {averageExercising} min.\n")
              .Append($"Favourite type: {favoritetype}\n");

            Console.WriteLine(sb.ToString());
        }

        public void OtherHobbiesStatistics(User user)
        {
            Console.Clear();

            var allOtherHobbies = user.ListOfActivities.OfType<OtherHobbies>().ToList();

            if (!ValidationHelpers.CheckIfListIsEmpty(allOtherHobbies, "other hobbies statistics")) return;

            var totalOtherHobbiesHours = allOtherHobbies.Sum(hours => hours.TrackedTime.Minutes);
            var namesOfHobbies = allOtherHobbies.Select(names => names.HobbyName).ToList();

            Console.WriteLine($"Total hours spent in your hobbies: {totalOtherHobbiesHours}");
            Console.WriteLine("Your hobbies:");
            foreach (var hobby in namesOfHobbies.Distinct())
            {
                Console.WriteLine($"-{hobby}");
            }
        }

        public void GeneralStatistics(User user)
        {
            Console.Clear();

            var totalTimeOfAllAc = user.ListOfActivities.Sum(hours => hours.TrackedTime.Minutes);

            // Favourite Activity

            int reading = user.ListOfActivities.Where(x => x.ActivityType == ActivityType.Reading).Count();
            int working = user.ListOfActivities.Where(x => x.ActivityType == ActivityType.Working).Count();
            int exercising = user.ListOfActivities.Where(x => x.ActivityType == ActivityType.Exercising).Count();
            int otherHobbies = user.ListOfActivities.Where(x => x.ActivityType == ActivityType.OtherHobbies).Count();

            var activitiesDictionary = new Dictionary<ActivityType, int>()
            {
                {ActivityType.Reading, reading },
                {ActivityType.Working, working },
                {ActivityType.Exercising, exercising },
                {ActivityType.OtherHobbies, otherHobbies },
            };

            var favoriteActivity = activitiesDictionary.FirstOrDefault(type => type.Value == activitiesDictionary.Values.Max()).Key.ToString();

            Console.WriteLine($" Total time of all your activities: {totalTimeOfAllAc}\n Favorite activity: {favoriteActivity}");
        }

    }
}
