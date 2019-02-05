using System;

namespace DevSchoolHierarchy.Entities.Persons
{
    public class Employee : Person
    {
        public decimal Salary { get; set; }
        public string Characteristic { get; set; }
        public string Education { get; set; }
        public DateTime WorkSince { get; set; }
    }
}
