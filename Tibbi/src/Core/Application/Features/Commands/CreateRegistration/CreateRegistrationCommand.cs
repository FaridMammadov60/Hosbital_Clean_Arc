using Application.Dto;
using Application.Interfaces.Repository;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Commands.CreateRegistration
{
    public class CreateRegistrationCommand : IRequest<ServiceResponse<int>>
    {
        public string Pin { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birth { get; set; }
        public int MedicalWorkerId { get; set; }
        public int CarId { get; set; }
        public int DiagnosId { get; set; }
        public int CallResultId { get; set; }
        public string photo { get; set; }
        public bool IsHospitalization { get; set; }       



        public class CreateRegistrationCommandHandler : IRequestHandler<CreateRegistrationCommand, ServiceResponse<int>>
        {
            IRegistrationRepository registrationRepository;
            private IMapper mapper;
            IRegistrationInfoRepository registrationInfoRepository;

            public CreateRegistrationCommandHandler(IRegistrationRepository registrationRepository, IMapper mapper, IRegistrationInfoRepository registrationInfoRepository)
            {
                this.registrationRepository = registrationRepository ?? throw new ArgumentNullException(nameof(registrationRepository));
                this.mapper = mapper;
                this.registrationInfoRepository = registrationInfoRepository;
            }

            public async Task<ServiceResponse<int>> Handle(CreateRegistrationCommand request, CancellationToken cancellationToken)
            {
                var registrdto = mapper.Map<RegistrationCreateDto>(request);
                registrdto.Protocol = Protocol(registrdto.Birth);
                var registr = mapper.Map<Registration>(registrdto);
                await registrationRepository.AddAsync(registr);
                RegistrationInfo registrInfo = new RegistrationInfo();
                registrdto.RegistrationId = registr.Id;
                registrInfo = mapper.Map<RegistrationInfo>(registrdto);
                
                await registrationInfoRepository.AddAsync(registrInfo);

                return new ServiceResponse<int>(registr.Id);

            }

            static string Protocol(DateTime data)
            {

                StringBuilder result = new StringBuilder();
                string date = data.ToString("dd/MM/yyyy");


                for (int i = 0; i < date.Length; i++)
                {
                    if (date[i] == '/' || date[i] == '-')
                    {
                        continue;
                    }
                    var b = date[i];
                    result.Append(b);
                }
                Random rnd = new Random();
                int num = rnd.Next(1000, 9999);
                result.Append(num);

                string protocol=result.ToString();
                return protocol;
            }
        }


    }
}
