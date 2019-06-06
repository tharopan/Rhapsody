using System;

namespace Rhapsody.Entities
{
    public interface ISoftDeleteEntity
    {
        bool IsDeleted { get; set; }

        DateTimeOffset DeletedDate { get; set; }
    }
}
