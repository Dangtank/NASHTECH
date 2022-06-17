using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using DAY3.Models;

namespace DAY3.Services
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
                FirstName = "Anh",
                LastName = "Dang Tuan",
                Gender = "Male",
                DateOfBirth = new DateTime(2000, 3, 15),
                PhoneNumber = "",
                BirthPlace = "Ninh Binh",
                IsGraduated = false
            },
            new Person
            {
                FirstName = "Tung",
                LastName = "Nguyen Hoang",
                Gender = "Male",
                DateOfBirth = new DateTime(2001, 3, 15),
                PhoneNumber = "",
                BirthPlace = "Bac Ninh",
                IsGraduated = false
            },
            new Person
            {
                FirstName = "Hai",
                LastName = "Pham Duc",
                Gender = "Male",
                DateOfBirth = new DateTime(1999, 3, 15),
                PhoneNumber = "",
                BirthPlace = "Kien Giang",
                IsGraduated = false
            },
        };

        public List<Person> GetAll()
        {
            return _people;
        }

        public Person Create(Person person)
        {
            _people.Add(person);
            return person;
        }

        public void Delete(int index)
        {
            if (index >= 0 && index < _people.Count)
            {
                _people.RemoveAt(index);
            }
        }

        public Person GetOne(int index)
        {
            return index >= 0 && index < _people.Count ? _people[index] : null;
        }

        public Person Update(int index, Person person)
        {
            if (index >= 0 && index < _people.Count)
            {
                _people[index]= person;

                return person;
            }
            return null;
        }
    }
}
