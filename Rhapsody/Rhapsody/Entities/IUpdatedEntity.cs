using System;

namespace Rhapsody.Entities
{
    public interface IUpdatedEntity
    {
        object UpdatedBy { get; set; }

        DateTimeOffset UpdatedDate { get; set; }
    }
}
