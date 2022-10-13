using Application.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Data;
using Persistance.Repository;

namespace Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection servicecollection)
        {
            servicecollection.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(@"Server=.\DB;Database=Ambulance;Trusted_Connection=True;MultipleActiveResultSets=true"));
            servicecollection.AddTransient<IRegistrationRepository, RegistrationRepository>();
        }
    }
}
