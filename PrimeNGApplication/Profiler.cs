using AutoMapper;
using PrimeNGApplication.EmployeeViewModel;
using PrimeNGApplication.Entity;
using PrimeNGApplication.Models;

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
