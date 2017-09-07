using PrimeNGApplication.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
