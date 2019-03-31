using System;
using System.Collections.Generic;
using System.Text;

namespace Rhapsody.Entities
{
    public interface IDeletedEntity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        object DeletedBy { get; set; }

        DateTimeOffset DeletedDate { get; set; }
    }
}
