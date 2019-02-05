using DevSchoolHierarchy.Contracts;

namespace DevSchoolHierarchy.Entities.Persons
{
    public class Headmen : Student, IHeadmen
    {
        public string MarkAttendance()
        {
            return "Отмечать посещаемость!";
        }
    }
}
