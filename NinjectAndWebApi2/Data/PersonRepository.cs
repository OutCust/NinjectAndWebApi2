using NinjectAndWebApi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjectAndWebApi2.Data
{
    public interface IPersonRepository
    {
        int Save(Person person);
        Person Retrieve(int Id);
        void Delete(int Id);
    }

    public class PersonRepository : IPersonRepository
    {
        public int Save(Person person)
        {
            // save a person somewhere
            return 1;
        }

        public Person Retrieve(int Id)
        {
            // get the person from somewhere
            return new Person { Id = 1, Name = "Fred", DateOfBirth = new DateTime(1970, 01, 01) };
        }

        public void Delete(int Id)
        {
            // delete the person with id.
        }
    }
}