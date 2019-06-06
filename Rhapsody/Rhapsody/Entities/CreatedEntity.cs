using System;

namespace Rhapsody.Entities
{
    public class CreatedEntity : ICreatedEntity
    {
        public virtual object CreatedBy { get; set; }
        public virtual DateTimeOffset CreatedDate { get; set; }
    }
}
