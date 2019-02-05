using System;

namespace DevSchoolHierarchy.Entities.Persons
{
    public abstract class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public DateTime BithDate { get; set; }
    }
}
