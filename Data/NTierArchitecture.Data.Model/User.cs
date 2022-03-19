using NTierArchitecture.Data.Common.Models;

namespace NTierArchitecture.Data.Model
{
    /// <summary>
    /// TODO pluralize or singularize karar verilecek
    /// </summary>
    public class User : AuditableEntity
    {
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
    }
}
