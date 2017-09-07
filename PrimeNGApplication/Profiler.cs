using AutoMapper;
using PrimeNGApplication.EmployeeViewModel;
using PrimeNGApplication.Entity;
using PrimeNGApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNGApplication
{
    public class Profiler : Profile
    {
        public Profiler()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<CreateEmployee, Employee>().ReverseMap();

            CreateMap<CreateDepartmentDto, Department>().ReverseMap();
            CreateMap<Department, DepartmentDto>().ReverseMap();
            CreateMap<UpdateDepartmentDto, Department>().ReverseMap();
        }
    }
}
