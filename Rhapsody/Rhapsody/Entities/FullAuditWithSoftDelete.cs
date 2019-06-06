using System;

namespace Rhapsody.Entities
{
    public class FullAuditWithSoftDelete<TPrimaryKey>
        : Entity<TPrimaryKey>,
        IFullAuditWithSoftDelete<TPrimaryKey>
    {
        public virtual object CreatedBy { get; set; }
        public virtual DateTimeOffset CreatedDate { get; set; }
        public virtual object UpdatedBy { get; set; }
        public virtual DateTimeOffset UpdatedDate { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual DateTimeOffset DeletedDate { get; set; }
    }
}
