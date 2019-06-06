using System;

namespace Rhapsody.Entities
{
    public class SoftDeleteEntity : ISoftDeleteEntity
    {
        public virtual bool IsDeleted { get; set; }
        public virtual DateTimeOffset DeletedDate { get; set; }
    }
}
