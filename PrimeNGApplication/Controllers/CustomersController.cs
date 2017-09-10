using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimeNGApplication.Interface;
using AutoMapper;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrimeNGApplication.Controllers
{
    [Route("api/Store/{BusinessEntityID}/customers")]
    public class CustomersController : Controller
    {
        private readonly IStoreRepository _repo;
        private readonly IMapper _mapper;
        private readonly ILogger _Logger;
        public CustomersController(IStoreRepository repo, IMapper mapper, ILoggerFactory loggerFactory)
        {
            _repo = repo;
            _mapper = mapper;
            _Logger = loggerFactory.CreateLogger(typeof(CustomersController));

        }

        [HttpGet]
        public async Task<IActionResult> Get(int BusinessEntityID)
        {
            if (!await _repo.StoreExists(BusinessEntityID))
            {
                return NotFound();
            }
            var getStoreForCustomers = await _repo.GetCustomersForStoresAsync(BusinessEntityID);
            return Ok(getStoreForCustomers);
        }
        [HttpGet("{customerId}")]
        public async Task<IActionResult> Get(int BusinessEntityID, int customerId)
        {
            if (!await _repo.StoreExists(BusinessEntityID))
            {
                return NotFound();
            }
            if (!await _repo.CustomerExists(customerId))
            {
                return NotFound();
            }
            var getStoreForCustomers = await _repo.GetCustomersForStoreAsync(BusinessEntityID,customerId);
            return Ok(getStoreForCustomers);
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
