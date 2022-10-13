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
            CreateMap<Registration, RegistrationCreateDto>().ReverseMap();
            CreateMap<Registration, CreateRegistrationCommand>().ReverseMap();

            CreateMap<RegistrationInfo, RegistrationReturnDto>().ReverseMap();
            CreateMap<RegistrationInfo, RegistrationCreateDto>().ReverseMap()
                .ForMember(d => d.photo, map => map.MapFrom(s => "https://localhost:44369/" + s.Image));
            CreateMap<RegistrationInfo, CreateRegistrationCommand>().ReverseMap();

            CreateMap<RegistrationCreateDto, CreateRegistrationCommand>().ReverseMap();

            CreateMap<CreateRegistrationCommand, RegistrationInfo>().ReverseMap();
        }
    }
}
