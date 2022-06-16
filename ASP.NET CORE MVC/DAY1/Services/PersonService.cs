using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using DAY1.Models;

namespace DAY1.Services
{
    public class PersonService : IPersonService
    {
        private static List<Person> _people = new List<Person>
        {
            new Person
            {
                FirstName = "Giang",
                LastName = "Vu Hoang",
                Gender = "Male",
                DateOfBirth = new DateTime(2000, 3, 15),
                PhoneNumber = "",
                BirthPlace = "Phu Tho",
                IsGraduated = false
            },
            new Person
            {
                FirstName = "Giang",
                LastName = "Vu Hoang",
                Gender = "Male",
                DateOfBirth = new DateTime(2001, 3, 15),
                PhoneNumber = "",
                BirthPlace = "Phu Tho",
                IsGraduated = false
            },
            new Person
            {
                FirstName = "Giang",
                LastName = "Vu Hoang",
                Gender = "Male",
                DateOfBirth = new DateTime(2002, 3, 15),
                PhoneNumber = "",
                BirthPlace = "Phu Tho",
                IsGraduated = false
            },
            new Person
            {
                FirstName = "Giang",
                LastName = "Vu Hoang",
                Gender = "Male",
                DateOfBirth = new DateTime(1999, 3, 15),
                PhoneNumber = "",
                BirthPlace = "Phu Tho",
                IsGraduated = false
            },
        };

        public List<Person> GetAll()
        {
            return _people;
        }


        public List<string> GetFullName()
        {
            return _people.Select(p => p.FullName).ToList();
        }

        public List<Person> GetMale()
        {
            return _people.Where(p => p.Gender.Equals("Male", StringComparison.CurrentCultureIgnoreCase)).ToList();
        }

        public Person GetOldest()
        {
            var maxAge =  _people.Max(p => p.Age);
            return _people.First(p => p.Age == maxAge);
        }

        public List<Person> GetPeopleByBirthYear(int year)
        {
            return _people.Where(p => p.DateOfBirth.Year == year).ToList();
        }

        public List<Person> GetPeopleByBirthYearGreater(int year)
        {
            return _people.Where(p => p.DateOfBirth.Year > year).ToList();
        }

        public List<Person> GetPeopleByBirthYearLess(int year)
        {
            return _people.Where(p => p.DateOfBirth.Year < year).ToList();
        }
       
        public byte[] GetDataStream()
        {
            using (var memoryStream = new MemoryStream())
            using (var streamWriter = new StreamWriter(memoryStream))
            using (var csWriter = new CsvWriter(streamWriter, CultureInfo.CurrentCulture))
            {
                csWriter.WriteRecords(_people);
                streamWriter.Flush();
                return memoryStream.ToArray();
            }
        }
    }
}
