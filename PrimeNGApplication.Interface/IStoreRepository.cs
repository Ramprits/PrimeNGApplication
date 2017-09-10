using PrimeNGApplication.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrimeNGApplication.Interface
{
    public interface IStoreRepository
    {
        Task<IEnumerable<Store>> GetStoresAsync();
        Task<Store> GetStoreAsync(int storeId);
        void InsertStoreAsync(Store store);
        Task<bool> UpdateStoreAsync(Store store);
        Task<bool> DeleteStoreAsync(int storeId);
        Task<bool> StoreExists(int storeId);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<Customer>> GetCustomersForStoresAsync(int storeId);
        Task<Customer> GetCustomersForStoreAsync(int storeId, int customerId);
        Task<bool> CustomerExists(int customerId);
        Task<IEnumerable<SalesOrderHeader>> GetCustomersForStoreForSalesOrderHeaderAsync(int customerId);
    }
}
