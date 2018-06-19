using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace TESTABP
{
    public interface IPersonAppService
    {
        Task<List<Person>> GetAll();
        Task<Person> CreatePerson(CreatePersonInput input);
        List<Person> GetPeopleList();
        Task<Person> GetPersonById(int Id);
        Task<Person> EditPersonById(Person input);
        Task<Person> DeletePersonById(int id);
    }
    public class CreatePersonInput
    {
        public int Id;
        [Required] 
        [MaxLength(Task.MaxTitleLength)]
        public string Name { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
