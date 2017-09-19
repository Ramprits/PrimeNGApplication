using AutoMapper;
using PrimeNGApplication.Data;
using PrimeNGApplication.ViewModel.EmployeeViewModel;
using PrimeNGApplication.ViewModel.Models;
using PrimeNGApplication.ViewModel.Store;

namespace PrimeNGApplication.Infrastructure.AutoMapper
{
    public class AutoMapperProfiler : Profile
    {
        public AutoMapperProfiler()
        {
            CreateMap<Store, StoreVM>().ReverseMap();
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<CreateEmployee, Employee>().ReverseMap();
            CreateMap<CreateDepartmentDto, Department>().ReverseMap();
            CreateMap<Department, DepartmentDto>().ReverseMap();
            CreateMap<UpdateDepartmentDto, Department>().ReverseMap();
            CreateMap<CreateStore,Store>().ReverseMap();
        }
    }
}
