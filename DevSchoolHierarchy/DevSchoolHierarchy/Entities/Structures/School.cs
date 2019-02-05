using System.Collections.Generic;

using DevSchoolHierarchy.Entities.Persons;

namespace DevSchoolHierarchy.Entities.Structures
{
    public class School
    {
       public Rector SchoolRector { get; set; }

       public string SchoolName { get; set; }

       public List<Faculty> Faculties { get; set; }
    }
}
