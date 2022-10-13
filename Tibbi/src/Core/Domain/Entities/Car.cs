using Domain.Common;

namespace Domain.Entities
{
    public class Car : BaseEntity
    {
        public string Brand { get; set; }
        public string LicensePlate { get; set; }
    }
}
