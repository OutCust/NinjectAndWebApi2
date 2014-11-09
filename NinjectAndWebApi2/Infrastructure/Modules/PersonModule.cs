using Ninject.Modules;
using NinjectAndWebApi2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjectAndWebApi2.Infrastructure.Modules
{
    public class PersonModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonRepository>().To<PersonRepository>();
        }
    }
}