using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TESTABP.EntityFrameworkCore;

namespace TESTABP
{
    public class PersonRepository : TESTABPRepositoryBase<Person>,IPersonRepository {
        private static  DbContextOptions<TESTABPDbContext> _DbContextOptions;
        public PersonRepository(IDbContextProvider<TESTABPDbContext> dbContextProvider):base(dbContextProvider)
        {
        }

        public Person GetPersonByUserId(string userid)
        {
            var personList = GetAll().ToList();
            var person = personList.Find(t => t.UserId == userid);
            return person;
        }
    }
}
