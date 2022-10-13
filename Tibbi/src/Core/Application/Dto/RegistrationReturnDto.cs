using System;

namespace Application.Dto
{
    public class RegistrationReturnDto
    {
        public int Id { get; set; }
        public string Protocol { get; set; }
        public string Pin { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birth { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int IsActive { get; set; } = 1;
        public string InsertUser { get; set; }
        public string? UpdateUser { get; set; }
        public int MedicalWorkerId { get; set; }
        public int CarId { get; set; }
        public int DiagnosId { get; set; }
    }
}
