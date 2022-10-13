using Application.Dto;
using Application.Interfaces.Repository;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Queries.GetAllRegistration
{
    public class GetAllRegistrationsQuery : IRequest<List<RegistrationReturnDto>>
    {


        public class GetAllRegistrationsQueryHandler : IRequestHandler<GetAllRegistrationsQuery, List<RegistrationReturnDto>>
        {

            private readonly IRegistrationRepository registrationRepository;
            private readonly IMapper mapper;

            public GetAllRegistrationsQueryHandler(IRegistrationRepository registrationRepository, IMapper mapper)
            {
                this.registrationRepository = registrationRepository;
                this.mapper = mapper;
            }

            public async Task<List<RegistrationReturnDto>> Handle(GetAllRegistrationsQuery request, CancellationToken cancellationToken)
            {
                var registrations = await registrationRepository.GetAllAsync();

                var registrationsReturn = mapper.Map<List<RegistrationReturnDto>>(registrations);

                return registrationsReturn;
            }
        }

    }
}
