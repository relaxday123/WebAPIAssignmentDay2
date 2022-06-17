using System;
using System.Collections.Generic;
using b2.DTO;
using b2.Entities;
using b2.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace b2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet("/get-all")]
        public List<Person> GetAll()
        {
            return _personService.GetAll();
        }

        [HttpPost]
        public Person Create(PersonDTO person)
        {
            return _personService.Create(person);
        }

        [HttpPut]
        public Person Edit([FromBody] PersonDTO person)
        {
            return _personService.Edit(person);
        }

        [HttpDelete]
        public bool Delete([FromQuery] Guid id)
        {
            return _personService.Delete(id);
        }

        [HttpPost("/filter")]
        public List<Person> GetByFilter([FromBody] FilterPersonDTO filter)
        {
            return _personService.Filter(filter);
        }
    }
}