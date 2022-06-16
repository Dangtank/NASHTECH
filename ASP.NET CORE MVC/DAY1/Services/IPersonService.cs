using System;
using System.Collections.Generic;
using DAY1.Models;

namespace DAY1.Services
{
    public interface IPersonService
    {
        public List<Person> GetMale();
        public List<Person> GetAll();
        public Person GetOldest();
        public List<String> GetFullName();
        public List<Person> GetPeopleByBirthYear(int year);
        public List<Person> GetPeopleByBirthYearGreater(int year);
        public List<Person> GetPeopleByBirthYearLess(int year);
        public byte[] GetDataStream();
    }
}