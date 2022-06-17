using b2.Entities;
using b2.DTO;
using System.Collections.Generic;
using System;

namespace b2.Services.Interfaces
{
    public interface IPersonService
    {
        List<Person> GetAll();
        Person Create(PersonDTO person);
        Person Edit(PersonDTO person);
        bool Delete(Guid id);
        List<Person> Filter(FilterPersonDTO filter);
    }
}