using LinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ListManager.LoadSampleData();

            //people = people.Where(x => x.YearsExperience > 10 && x.Birthday.Month == 3).ToList();

            //foreach (var person in people)
            //{
            //    Console.WriteLine($"{ person.FirstName } { person.LastName } ({ person.Birthday.ToShortDateString() }): Experience { person.YearsExperience }");
            //}

            var yearsTotal = 0;

            yearsTotal = people.Where(x => x.Birthday.Month == 3).Sum(x => x.YearsExperience);

            Console.WriteLine($"Total years of experience of people birth on march is { yearsTotal }");

            Console.ReadLine();
        }
    }
}
