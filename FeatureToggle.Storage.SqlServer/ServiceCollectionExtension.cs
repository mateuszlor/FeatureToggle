using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FeatureToggle.Storage.SqlServer
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddFeatureToggleSqlServerDatabase(this IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddDbContext<DatabaseContext>(o => o.UseSqlServer(connectionString));

            return serviceCollection;
        }
    }
}
