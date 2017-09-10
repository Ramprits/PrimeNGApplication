using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PrimeNGApplication.Entity
{
    public class ApiResponse
    {
        public bool Status { get; set; }
        public Customer Customer { get; set; }
        public ModelStateDictionary ModelState { get; set; }
    }
}
