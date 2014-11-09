using NinjectAndWebApi2.Data;
using NinjectAndWebApi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NinjectAndWebApi2.Controllers
{
    public class PersonController : ApiController
    {
        private IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public Person Get(int id)
        {
            return _personRepository.Retrieve(id);
        }

        public int Put(Person person)
        {
            return _personRepository.Save(person);
        }

        public int Post(Person person)
        {
            return _personRepository.Save(person);
        }

        public void Delete(int id)
        {
            _personRepository.Delete(id);
        }

    }
}
