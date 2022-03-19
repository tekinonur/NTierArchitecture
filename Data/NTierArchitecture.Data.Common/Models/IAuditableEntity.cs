namespace NTierArchitecture.Data.Common.Models
{
    public interface IAuditableEntity
    {
        bool Active { get; set; }
        Guid CreatedBy { get; set; }
        DateTime CreatedOn { get; set; }
        Guid? UpdatedBy { get; set; }
        DateTime? UpdatedOn { get; set; }
        Guid? DeletedBy { get; set; }
        DateTime? DeletedOn { get; set; }
    }
}
