using System;

namespace Rhapsody.Entities
{
    public class DeletedEntity : IDeletedEntity
    {
        public virtual object DeletedBy { get; set; }
        public virtual DateTimeOffset DeletedDate { get; set; }
    }
}
