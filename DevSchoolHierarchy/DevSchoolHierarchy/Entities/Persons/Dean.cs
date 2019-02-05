using DevSchoolHierarchy.Contracts;

namespace DevSchoolHierarchy.Entities.Persons
{
   public class Dean : Employee, IDean
    {
        public string ManageFaculty()
        {
            return "Управлять факультетом!";
        }

        public string Teach()
        {
            return "Преподавать";
        }
    }
}
