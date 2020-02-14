using System;

namespace FeatureToggle.Infrastructure.Model
{
    public class Permission
    {
        public long Id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }
        public string UserName { get; set; }
        public string UserClaim { get; set; }
        public bool AlwaysEnabled { get; set; }

    }
}
