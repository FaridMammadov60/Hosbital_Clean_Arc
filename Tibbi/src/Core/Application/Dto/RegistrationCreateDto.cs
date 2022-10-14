using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;

namespace Application.Dto
{
    public class RegistrationCreateDto
    {
        public int Id { get; set; }
        public string Protocol { get; set; }
        public string Pin { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birth { get; set; }
        public int IsActive { get; set; } = 1;
        public string InsertUser { get; set; }
        public int MedicalWorkerId { get; set; }
        public int CarId { get; set; }
        public int DiagnosId { get; set; }

        public int CallResultId { get; set; }
        public IFormFile Image { get; set; }
        public bool IsHospitalization { get; set; }
        public int RegistrationId { get; set; }
    }

    public class RegistrationCreateDtoValidator : AbstractValidator<RegistrationCreateDto>
    {
        public RegistrationCreateDtoValidator()
        {
            RuleFor(c => c.Name).Empty().WithMessage("bosh olmaz").MaximumLength(100).WithMessage("100den cox ola bilmez");
            RuleFor(c => c.Surname).Empty().WithMessage("bosh olmaz").MaximumLength(100).WithMessage("100den cox ola bilmez");
            RuleFor(c => c.Pin).MinimumLength(7).WithMessage("Pin 7 herfli olmalidi");
        }


    }

}
