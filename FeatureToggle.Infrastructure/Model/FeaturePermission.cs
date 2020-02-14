namespace FeatureToggle.Infrastructure.Model
{
    public class FeaturePermission
    {
        public long FeatureId { get; set; }
        public Feature Feature { get; set; }
        public long PermissionId { get; set; }
        public Permission Permission { get; set; }
    }
}
