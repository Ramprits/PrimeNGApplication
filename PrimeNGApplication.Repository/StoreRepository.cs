using PrimeNGApplication.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrimeNGApplication.Data;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace PrimeNGApplication.Repository
{
    public class StoreRepository : IStoreRepository
    {
        private readonly AdventureworksContext _context;
        private readonly ILogger _Logger;
        public StoreRepository(AdventureworksContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _Logger = loggerFactory.CreateLogger(typeof(StoreRepository));

        }

        public async Task<bool> DeleteStoreAsync(int storeId)
        {
            var deleteStoreAsync = _context.Store.
                                    SingleOrDefaultAsync(x => x.BusinessEntityId == storeId);
            _context.Remove(deleteStoreAsync);
            try
            {
                return (await SaveAllAsync() ? true : false);
            }
            catch (Exception ex)
            {

                _Logger.LogError($"Error in {nameof(DeleteStoreAsync)}: " + ex.Message);
            }
            return false;
        }

        public async Task<IEnumerable<Store>> GetStoresAsync()
        {
            return await _context.Store.Include(x => x.Customer).Include(x => x.SalesPerson).ToListAsync();
        }

        public async Task<Store> GetStoreAsync(int storeId)
        {
            return await _context.Store.Include(x => x.Customer).Include(x => x.SalesPerson).FirstOrDefaultAsync(x => x.BusinessEntityId == storeId);
        }

        public void InsertStoreAsync(Store store)
        {
            store.Rowguid = new Guid();
            _context.Store.AddAsync(store);
        }

        public async Task<bool> SaveAllAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<bool> StoreExists(int storeId)
        {
            return (await _context.Store.AnyAsync(x => x.BusinessEntityId == storeId));
        }

        public async Task<bool> UpdateStoreAsync(Store store)
        {
            _context.Store.Attach(store);
            _context.Entry(store).State = EntityState.Modified;
            try
            {
                return (await SaveAllAsync() ? true : false);
            }
            catch (Exception exp)
            {
                _Logger.LogError($"Error in {nameof(UpdateStoreAsync)}: " + exp.Message);
            }
            return false;
        }

        public async Task<IEnumerable<Customer>> GetCustomersForStoresAsync(int storeId)
        {
            return await _context.Customer.Where(x => x.StoreId == storeId).ToListAsync();
        }

        public async Task<Customer> GetCustomersForStoreAsync(int storeId, int customerId)
        {
            return await _context.Customer.Where(x => x.StoreId == storeId && x.CustomerId == customerId).FirstOrDefaultAsync();
        }

        public async Task<bool> CustomerExists(int customerId)
        {
            return (await _context.Customer.AnyAsync(x => x.CustomerId == customerId));
        }

        public async Task<IEnumerable<SalesOrderHeader>> GetCustomersForStoreForSalesOrderHeaderAsync(int customerId)
        {
            return await _context.SalesOrderHeader.Where(x => x.CustomerId == customerId).OrderByDescending(x => x.SalesOrderId).ToListAsync();
        }
    }
}
