using System;
using System.Collections.Generic;
using System.Linq;
using b2.DataContext;
using b2.DTO;
using b2.Entities;
using b2.Extensions;
using b2.Services.Interfaces;

namespace b2.Services
{
    public class PersonService : IPersonService
    {
        public List<Person> GetAll()
        {
            return PersonContext.Person;
        }

        public Person Create(PersonDTO person)
        {
            var newPerson = person.DTOToEntity();
            PersonContext.Person.Add(newPerson);

            return newPerson;
        }

        public Person Edit(PersonDTO person)
        {
            var editPerson = PersonContext.Person.Find(p => p.Id == person.Id);
            if (editPerson != null)
            {
                editPerson.FirstName = person.FirstName;
                editPerson.LastName = person.LastName;

                return editPerson;
            }

            return null;
        }

        public bool Delete(Guid id)
        {
            var editPerson = PersonContext.Person.Find(p => p.Id == id);
            if (editPerson != null)
            {
                PersonContext.Person.Remove(editPerson);

                return true;
            }

            return false;
        }

        public List<Person> Filter(FilterPersonDTO filter)
        {
            return PersonContext.Person.Where(p => (p.Name == filter.Name)
                    || (string.IsNullOrEmpty(p.Gender) && p.Gender.ToLower() == filter.Gender.ToLower())
                    || (string.IsNullOrEmpty(p.Gender) && p.BirthPlace.ToLower() == filter.BirthPlace.ToLower())).ToList();
        }
    }
}