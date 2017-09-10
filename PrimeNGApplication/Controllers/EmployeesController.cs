using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PrimeNGApplication.Service;
using AutoMapper;
using PrimeNGApplication.Entity;
using Microsoft.AspNetCore.Cors;
using PrimeNGApplication.ViewModel.EmployeeViewModel;

namespace PrimeNGApplication.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [EnableCors("AnyGET")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepository _repository;
        private readonly IMapper _mapper;
        public EmployeesController(IEmployeeRepository repo, IMapper mapper)
        {
            _repository = repo;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var employeeEntity = _repository.GetEmployees();
            return Ok(_mapper.Map<IEnumerable<EmployeeDto>>(employeeEntity));
        }

        [HttpGet("{employeeId}", Name = "getEmployee")]
        [ProducesResponseType(typeof(Employee), 200),
            ProducesResponseType(typeof(Employee), 400)]
        public IActionResult Get(int employeeId)
        {
            var employeeEntity = _repository.GetEmployee(employeeId);
            if (employeeEntity == null)
            {
                return BadRequest();
            }
            return Ok(_mapper.Map<EmployeeDto>(employeeEntity));
        }

        [HttpPost]
        [ProducesResponseType(typeof(Employee), 201),
            ProducesResponseType(typeof(Employee), 400)]
        public IActionResult Post([FromBody] CreateEmployee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if (employee == null)
            {
                return BadRequest();
            }
            try
            {
                var employeeEntity = _mapper.Map<Employee>(employee);
                if (employeeEntity != null)
                {
                    _repository.AddEmployee(employeeEntity);
                }
                if (!_repository.Save())
                {
                    throw new Exception($"Creating  Employee is failed!");
                }
                return Created("getEmployee", employeeEntity);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }
    }
}