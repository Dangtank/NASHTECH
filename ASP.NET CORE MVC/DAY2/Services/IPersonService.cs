using System;
using System.Collections.Generic;
using DAY2.Models;

namespace DAY2.Services
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