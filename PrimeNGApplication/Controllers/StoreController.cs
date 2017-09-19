using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using PrimeNGApplication.Infrastructure;
using PrimeNGApplication.Interface;
using AutoMapper;
using Microsoft.Extensions.Logging;
using PrimeNGApplication.ViewModel.Store;
using System;
using PrimeNGApplication.Data;

namespace PrimeNGApplication.Controllers
{
    [Route("api/Store"), EnableCors("AnyGET")]
    public class StoreController : Controller
    {
        private readonly IStoreRepository _repo;
        private readonly IMapper _mapper;
        private readonly ILogger _Logger;
        public StoreController(IStoreRepository repo, IMapper mapper, ILoggerFactory loggerFactory)
        {
            _repo = repo;
            _mapper = mapper;
            _Logger = loggerFactory.CreateLogger(typeof(StoreController));

        }
        [HttpGet, NoCache]
        public async Task<IActionResult> Get()
        {
            try
            {
                var StoreEntity = await _repo.GetStoresAsync();
                return Ok(_mapper.Map<IEnumerable<StoreVM>>(StoreEntity));
            }
            catch (Exception ex)
            {

                _Logger.LogError($"{ex.Message}");
            }
            return BadRequest();

        }
        [HttpGet("{BusinessEntityID}", Name = "GetStore"), NoCache]
        public async Task<IActionResult> GetStore(int BusinessEntityID)
        {
            if (await _repo.StoreExists(BusinessEntityID))
            {
                var getStore = await _repo.GetStoreAsync(BusinessEntityID);
                return Ok(getStore);
            }
            return BadRequest();

        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateStore store)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest($"Server error");
            }
            try
            {
                var InertStoreEntity = _mapper.Map<Store>(store);
                _repo.InsertStoreAsync(InertStoreEntity);
                if (!await _repo.SaveAllAsync())
                {
                    return StatusCode(500, "A problem happened with handling your request.");
                }
                return Created("GetStore", InertStoreEntity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}