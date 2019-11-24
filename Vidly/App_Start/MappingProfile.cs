using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        //MapperConfiguration mapFromConfigToDto = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerDto>());
        //MapperConfiguration mapFromDtoToConfig = new MapperConfiguration(cfg => cfg.CreateMap<CustomerDto, Customer>());

        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
        }
    }
}