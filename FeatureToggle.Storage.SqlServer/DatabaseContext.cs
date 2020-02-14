using FeatureToggle.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;

namespace FeatureToggle.Storage.SqlServer
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Feature> Feature { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<FeaturePermission> FeaturePermission { get; set; }
    }
}
