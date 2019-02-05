using System.Collections.Generic;
using DevSchoolHierarchy.Entities.Persons;

namespace DevSchoolHierarchy.Entities.Structures
{
    public class Group
    {
        public Headmen GroupHeadmen { get; set; }

        public string GroupName { get; set; }

        public List<Student> Students { get; set; } 
    }
}
