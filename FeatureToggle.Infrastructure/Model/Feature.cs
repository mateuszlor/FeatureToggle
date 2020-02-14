namespace FeatureToggle.Infrastructure.Model
{
    public class Feature
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public PermissionConfiguration Configuration { get; set; }
    }
}
