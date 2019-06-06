using System;

namespace Rhapsody.Entities
{
    public class FullAuditEntity<TPrimaryKey>
        : Entity<TPrimaryKey>,
        IFullAuditEntity<TPrimaryKey>
    {
        public virtual object CreatedBy { get; set; }
        public virtual DateTimeOffset CreatedDate { get; set; }
        public virtual object UpdatedBy { get; set; }
        public virtual DateTimeOffset UpdatedDate { get; set; }
        public virtual object DeletedBy { get; set; }
        public virtual DateTimeOffset DeletedDate { get; set; }
    }

    public class FullAuditEntity
        : FullAuditEntity<long>
    { }
}
