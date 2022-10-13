using Application.Dto;
using Application.Features.Commands.CreateRegistration;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping
{
    public class GeneralMappings : Profile
    {
        public GeneralMappings()
        {
            CreateMap<Registration, RegistrationReturnDto>().ReverseMap();
            CreateMap<Registration, CreateRegistrationCommand>().ReverseMap();
        }
    }
}
