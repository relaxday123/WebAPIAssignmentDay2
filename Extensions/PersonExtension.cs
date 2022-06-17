using System;
using b2.DTO;
using b2.Entities;

namespace b2.Extensions
{
    public static class PersonExtension
    {
        public static Person DTOToEntity(this PersonDTO person)
        {
            return new Person
            {
                Id = person.Id.HasValue ? (Guid)person.Id : Guid.NewGuid(),
                FirstName = person.FirstName,
                LastName = person.LastName
            };
        }
        public static PersonDTO EntityToDTO(this Person person)
        {
            return new PersonDTO
            {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName
            };
        }
    }
}