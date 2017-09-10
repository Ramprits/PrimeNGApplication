using PrimeNGApplication.Entity;
using System.Collections.Generic;

namespace PrimeNGApplication.Service
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployee(int employeeId);
        void AddEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        bool EmployeeExists(int employeeId);
        bool Save();
    }
}
