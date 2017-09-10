using AutoMapper;
using PrimeNGApplication.Data;
using PrimeNGApplication.ViewModel.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNGApplication.Infrastructure.AutoMapper
{
    public class AutoMapperProfiler : Profile
    {
        public AutoMapperProfiler()
        {
            CreateMap<Store, StoreVM>().ReverseMap();
        }
    }
}
