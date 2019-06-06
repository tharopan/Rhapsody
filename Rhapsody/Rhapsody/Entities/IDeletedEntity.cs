using System;

namespace Rhapsody.Entities
{
    public interface IDeletedEntity
    {
        object DeletedBy { get; set; }

        DateTimeOffset DeletedDate { get; set; }
    }
}
