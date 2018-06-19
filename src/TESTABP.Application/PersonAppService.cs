using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace TESTABP {
    public class PersonAppService : TESTABPAppServiceBase, IPersonAppService {

        private readonly IRepository<Person> _personRepository;

        public PersonAppService(IRepository<Person> taskRepository) {
            _personRepository = taskRepository;
        }

        public async Task<List<Person>> GetAll() {
            var person = await _personRepository.GetAll().OrderByDescending(t => t.CreationTime)
                .ToListAsync();
            return person;
        }

        public  List<Person> GetPeopleList()
        {
            var people = _personRepository.GetAll().OrderByDescending(t=>t.CreationTime).ToList();
            return people;
        }

        public async Task<Person> GetPersonById(int id)
        {
            var person = await _personRepository.GetAsync(id);
            return person;
        }

        public async Task<Person> EditPersonById(Person input)
        {
            var person = await _personRepository.UpdateAsync(input);
            return person;
        }

        public async Task<Person> CreatePerson(CreatePersonInput input) {
            var person = ObjectMapper.Map<Person>(input);
            await _personRepository.InsertAsync(person);
            return person;
        }

        public async Task<Person> DeletePersonById(int id)
        {
            
            var person = await _personRepository.GetAsync(id);
            if (person!=null)
            {
                await _personRepository.DeleteAsync(id);
            }
            return person;
        }
    }
}
