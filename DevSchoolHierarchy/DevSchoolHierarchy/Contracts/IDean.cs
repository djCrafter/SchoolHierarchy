
namespace DevSchoolHierarchy.Contracts
{
     /// <summary>
     /// Декан факультета
     /// </summary>
    public interface IDean : ITeacher
    {
        /// <summary>
        /// Управлять факультетом
        /// </summary>
        string ManageFaculty();
    }
}
