using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimeNGApplication.Service;
using PrimeNGApplication.Entity;
using Microsoft.Extensions.Logging;
using AutoMapper;
using PrimeNGApplication.Models;
using Microsoft.AspNetCore.Cors;
using PrimeNGApplication.Infrastructure;
using PrimeNGApplication.EmployeeViewModel;

namespace PrimeNGApplication.Controllers
{
    [Route("api/[controller]"), EnableCors("AnyGET")]
    public class DepartmentsController : Controller
    {
        private IDepartmentRepository _repo;
        private ILogger<DepartmentsController> _logger;
        private readonly IMapper _mapper;

        public DepartmentsController(IDepartmentRepository repo,
            ILogger<DepartmentsController> logger, IMapper mapper)
        {
            _repo = repo;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [NoCache]
        [ProducesResponseType(typeof(List<Department>), 200)]
        public async Task<IActionResult> Get()
        {
            var getDepartmentAsync = await _repo.GetDepartmentAsync();
            return Ok(_mapper.Map<IEnumerable<DepartmentDto>>(getDepartmentAsync));
        }

        [HttpGet("{departmentId}", Name = "GetDepartment")]
        public async Task<IActionResult> GetDepartment(int departmentId)
        {
            var getDepartmentAsync = await _repo.GetDepartmentAsync(departmentId);

            return Ok(getDepartmentAsync);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateDepartmentDto department)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest($"There are server error");
            }
            if (department == null)
            {
                return NotFound();
            }
            try
            {
                var insertDepartment = _mapper.Map<Department>(department);
                if (insertDepartment == null) return NotFound();
                _repo.InsertDepartmentAsync(insertDepartment);
                if (await _repo.SaveAllAsync())
                {
                    return Created("GetDepartment", insertDepartment);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Threw exception while saving Camp: {ex}");
            }
            return BadRequest();

        }

        [HttpPut("{departmentId}")]
        public async Task<IActionResult> Put(int departmentId, [FromBody]UpdateDepartmentDto department)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                var DepartmentEntity = await _repo.GetDepartmentAsync(departmentId);
                _mapper.Map(department, DepartmentEntity);
                if (await _repo.SaveAllAsync())
                {
                    return Ok();
                }
            }
            catch (Exception exp)
            {
                _logger.LogError(exp.Message);
                return BadRequest();
            }
            return BadRequest();
        }

        [HttpDelete("{departmentId}")]
        [NoCache]
        public async Task<ActionResult> Delete(int departmentId)
        {
            try
            {
                var status = await _repo.DeleteDepartmentAsync(departmentId);
                if (!status)
                {
                    return BadRequest();
                }
                return Ok();
            }
            catch (Exception exp)
            {
                _logger.LogError(exp.Message);
                return BadRequest();
            }

        }
    }
}
