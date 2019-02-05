using System.Collections.Generic;
using DevSchoolHierarchy.Entities.Persons;

namespace DevSchoolHierarchy.Entities.Structures
{
    public class Faculty
    {
        public Dean FacultyDean { get; set; }

        public string FacultyName { get; set; }

        public List<Group> Groups { get; set; }
    }
}
