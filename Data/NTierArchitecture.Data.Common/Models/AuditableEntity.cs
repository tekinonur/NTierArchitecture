namespace NTierArchitecture.Data.Common.Models
{
    public abstract class AuditableEntity : BaseEntity, IAuditableEntity
    {
        public virtual bool Active { get; set; }
        public virtual Guid CreatedBy { get; set; }
        public virtual DateTime CreatedOn { get; set; }
        public virtual Guid? UpdatedBy { get; set; }
        public virtual DateTime? UpdatedOn { get; set; }
        public virtual Guid? DeletedBy { get; set; }
        public virtual DateTime? DeletedOn { get; set; }
    }
}
