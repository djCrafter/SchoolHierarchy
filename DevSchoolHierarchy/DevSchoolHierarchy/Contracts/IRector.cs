
namespace DevSchoolHierarchy.Contracts
{
    /// <summary>
    /// Ректор учебного заведения
    /// </summary>
    public interface IRector : IDean
    {
        /// <summary>
        /// Управлять учебным заведением
        /// </summary>
        string ManageTheSchool();
    }
}
