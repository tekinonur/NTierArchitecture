using NTierArchitecture.Data.Common.Models;

namespace NTierArchitecture.Data.Model
{
    public class Muhit : AuditableEntity
    {
        public string Name { get; set; }
        public int ListOrder { get; set; }
    }
}
