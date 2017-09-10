using System;

namespace PrimeNGApplication.ViewModel.Store
{
    public class StoreVM
    {
        public string Name { get; set; }
        public int? SalesPersonId { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
