using DevSchoolHierarchy.Contracts;

namespace DevSchoolHierarchy.Entities.Persons
{
    public class Rector : Employee, IRector
    {         
        public string ManageFaculty()
        {
            return "Управлять факультетом!";
        }
      
        public string ManageTheSchool()
        {
            return "Управлять учебным заведением!";
        }

        public string Teach()
        {
            return "Преподавать";
        }
    }
} 
