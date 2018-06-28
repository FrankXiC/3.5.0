using Abp.Domain.Entities;
using Abp.Domain.Repositories;

namespace TESTABP
{
    public interface IPersonRepository:IRepository<Person> {
        Person GetPersonByUserId(string userid);
    }
}