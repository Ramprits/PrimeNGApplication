using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PrimeNGApplication.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace PrimeNGApplication.Service
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private PrimengdbContext _primengdbContext;
        private readonly ILogger _Logger;

        public DepartmentRepository(PrimengdbContext primengdbContext, ILoggerFactory loggerFactory)
        {
            _primengdbContext = primengdbContext;
            _Logger = loggerFactory.CreateLogger("CustomersRepository");
        }
        public async Task<bool> DeleteDepartmentAsync(int departmentId)
        {
            var customer = await _primengdbContext.Department
                                .SingleOrDefaultAsync(c => c.DepartmentId == departmentId);
            _primengdbContext.Remove(customer);
            try
            {
                return (await _primengdbContext.SaveChangesAsync() > 0 ? true : false);
            }
            catch (System.Exception exp)
            {
                _Logger.LogError($"Error in {nameof(DeleteDepartmentAsync)}: " + exp.Message);
            }
            return false;
        }

        public async Task<IEnumerable<Department>> GetDepartmentAsync()
        {
            return await _primengdbContext.Department.ToListAsync();
        }

        public async Task<Department> GetDepartmentAsync(int departmentId)
        {
            return await _primengdbContext.Department.FirstOrDefaultAsync(x => x.DepartmentId == departmentId);
        }

        public async void InsertDepartmentAsync(Department department)
        {
            await _primengdbContext.Department.AddAsync(department);
        }

        public async Task<bool> SaveAllAsync()
        {
            return (await _primengdbContext.SaveChangesAsync()) > 0;
        }

        public async Task<bool> UpdateDepartmentAsync(Department department)
        {
            _primengdbContext.Department.Attach(department);
            _primengdbContext.Entry(department).State = EntityState.Modified;
            try
            {
                return (await _primengdbContext.SaveChangesAsync() > 0 ? true : false);
            }
            catch (Exception exp)
            {
                _Logger.LogError($"Error in {nameof(UpdateDepartmentAsync)}: " + exp.Message);
            }
            return false;
        }
    }
}
