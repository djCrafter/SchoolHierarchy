using System;

namespace DevSchoolHierarchy.Entities.Persons
{
    public class Student : Person
    {
        public decimal Scholarship { get; set; }
        public DateTime YearOfEntry { get; set; }

        public string Study()
        {
            return "Учиться!";
        }
    }
}
