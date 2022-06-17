using System.Collections.Generic;
using b2.Entities;

namespace b2.DataContext
{
    public class PersonContext
    {
        public static List<Person> Person = new List<Person>{
            new Person
            {
                FirstName = "Nguyen",
                LastName = "Hoang Anh",
                Gender = "Male",
                BirthPlace = "Hai Phong"
            },
            new Person
            {
                FirstName = "Nguyen",
                LastName = "Van A",
                Gender = "Male",
                BirthPlace = "Ha Noi"
            }
        };
    }
}