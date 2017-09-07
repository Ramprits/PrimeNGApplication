using PrimeNGApplication.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrimeNGApplication.Service
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartmentAsync();
        Task<Department> GetDepartmentAsync(int departmentId);
        void InsertDepartmentAsync(Department department);
        Task<bool> UpdateDepartmentAsync(Department department);
        Task<bool> DeleteDepartmentAsync(int departmentId);
        Task<bool> SaveAllAsync();

    }
}
