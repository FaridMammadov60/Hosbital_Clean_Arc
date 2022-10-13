using Application.Interfaces.Repository;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Commands.CreateRegistration
{
    public class CreateRegistrationCommand:IRequest<ServiceResponse<Guid>>
    {
        public string Protocol { get; set; }
        public string Pin { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birth { get; set; }
        public int MedicalWorkerId { get; set; } 
        public int CarId { get; set; }      
        public int DiagnosId { get; set; }

        //public class CreateRegistrationCommandHandler : IRequestHandler<CreateRegistrationCommand, ServiceResponse<Guid>>
        //{
        //    IRegistrationRepository registrationRepository;
        //    private IMapper mapper;

        //    public CreateRegistrationCommandHandler(IRegistrationRepository registrationRepository, IMapper mapper)
        //    {
        //        this.registrationRepository = registrationRepository?? throw new ArgumentNullException(nameof(registrationRepository));
        //        this.mapper = mapper;
        //    }

        //    public async Task<ServiceResponse<Guid>>Handle(CreateRegistrationCommand request, CancellationToken cancellationToken)
        //    {
        //        var registr = mapper.Map<Domain.Entities.Registration>(request);
        //        await registrationRepository.AddAsync(registr);
        //        return new ServiceResponse<Guid>(registr.Id);
                
        //    }
        //}


    }
}
