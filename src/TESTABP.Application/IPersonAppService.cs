using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace TESTABP {
    public interface IPersonAppService {
        Task<List<Person>> GetAll();
        Task<Person> CreatePerson(Person input);
        List<Person> GetPeopleList();
        Task<Person> GetPersonById(int Id);
        Task<Person> EditPersonById(Person input);
        Person GetPersonByUserId(string userid);
        Task<Person> DeletePersonById(int id);
    }
    public class CreatePersonInput {
        public int Id;
        [Required]
        [MaxLength(Task.MaxTitleLength)]
        public string Name { get; set; }
        public DateTime CreationTime { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
