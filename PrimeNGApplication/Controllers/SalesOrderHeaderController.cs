using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimeNGApplication.Interface;
using Microsoft.Extensions.Logging;
using AutoMapper;

namespace PrimeNGApplication.Controllers
{
    [Produces("application/json")]
    [Route("api/customers/{customerId}/SalesOrderHeader")]
    public class SalesOrderHeaderController : Controller
    {
        private readonly IStoreRepository _repo;
        private readonly IMapper _mapper;
        private readonly ILogger _Logger;
        public SalesOrderHeaderController(IStoreRepository repo, IMapper mapper, ILoggerFactory loggerFactory)
        {
            _repo = repo;
            _mapper = mapper;
            _Logger = loggerFactory.CreateLogger(typeof(SalesOrderHeaderController));

        }

        [HttpGet]
        public async Task<IActionResult> Get(int customerId)
        {
            var getCustomerForSalesOrderHeader = await _repo.GetCustomersForStoreForSalesOrderHeaderAsync(customerId);

            return Ok(getCustomerForSalesOrderHeader);
        }
    }
}