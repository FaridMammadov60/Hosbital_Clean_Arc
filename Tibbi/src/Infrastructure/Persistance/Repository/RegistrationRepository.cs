using Application.Interfaces.Repository;
using Domain.Entities;
using Persistance.Data;

namespace Persistance.Repository
{
    public class RegistrationRepository : GenericRepository<Registration>, IRegistrationRepository
    {
        public RegistrationRepository(AppDbContext context) : base(context)
        {

        }
    }
}
