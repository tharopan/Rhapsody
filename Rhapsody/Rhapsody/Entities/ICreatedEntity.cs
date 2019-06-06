using System;

namespace Rhapsody.Entities
{
    public interface ICreatedEntity
    {
        object CreatedBy { get; set; }

        DateTimeOffset CreatedDate { get; set; }
    }
}
