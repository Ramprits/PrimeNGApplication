using System;

namespace PrimeNGApplication.ViewModel.Store
{
    public class CreateStore
    {
        public string Name { get; set; }
        public int? SalesPersonId { get; set; }
        public string Demographics { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}