using DevSchoolHierarchy.Contracts;

namespace DevSchoolHierarchy.Entities.Persons
{
    public class Teacher : Employee, ITeacher
    {
        public string Teach()
        {
            return "Преподавать";
        }
    }
}
