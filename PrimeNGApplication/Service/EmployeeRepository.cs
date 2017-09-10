using PrimeNGApplication.Entity;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNGApplication.Service
{

    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly PrimengdbContext _context;

        public EmployeeRepository(PrimengdbContext context)
        {
            _context = context;
        }

        public void AddEmployee(Employee employee)
        {
            _context.Add(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            _context.Employee.Remove(employee);
        }

        public bool EmployeeExists(int employeeId)
        {
            return _context.Employee.Any(x => x.EmployeeId == employeeId);
        }

        public Employee GetEmployee(int employeeId)
        {
            return _context.Employee.FirstOrDefault(x => x.EmployeeId == employeeId);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employee.ToList();
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        
    }

}
