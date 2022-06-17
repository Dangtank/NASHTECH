using System;
using System.Collections.Generic;
using DAY3.Models;

namespace DAY3.Services
{
    public interface IPersonService
    {       
        public List<Person> GetAll();
        public Person GetOne(int Index);
        public Person Create(Person person);
        public Person Update(int index, Person person);
        public void Delete(int index);
    }
}