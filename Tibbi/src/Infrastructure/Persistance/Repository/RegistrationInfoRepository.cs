using Application.Interfaces.Repository;
using Domain.Entities;
using Persistance.Data;

namespace Persistance.Repository
{
    public class RegistrationInfoRepository : GenericRepository<RegistrationInfo>, IRegistrationInfoRepository
    {
        public RegistrationInfoRepository(AppDbContext context) : base(context)
        {

        }
    }
}
