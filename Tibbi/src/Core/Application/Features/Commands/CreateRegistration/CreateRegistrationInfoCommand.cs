using Application.Interfaces.Repository;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Commands.CreateRegistration
{
    public class CreateRegistrationInfoCommand : IRequest<ServiceResponse<int>>
    {
        public int RegistrationId { get; set; }
        public int CallResultId { get; set; }
        public string photo { get; set; }
        public bool IsHospitalization { get; set; }

    }
    public class CreateRegistrationInfoCommandHandler : IRequestHandler<CreateRegistrationInfoCommand, ServiceResponse<int>>
    {
        IRegistrationInfoRepository registrationRepository;
        private IMapper mapper;

        public CreateRegistrationInfoCommandHandler(IRegistrationInfoRepository registrationRepository, IMapper mapper)
        {
            this.registrationRepository = registrationRepository ?? throw new ArgumentNullException(nameof(registrationRepository));
            this.mapper = mapper;

        }

        public async Task<ServiceResponse<int>> Handle(CreateRegistrationInfoCommand request, CancellationToken cancellationToken)
        {
            var registr = mapper.Map<RegistrationInfo>(request);

            await registrationRepository.AddAsync(registr);

            return new ServiceResponse<int>(registr.Id);

        }
    }
}
