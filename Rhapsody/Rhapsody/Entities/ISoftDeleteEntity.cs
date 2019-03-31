using System;
using System.Collections.Generic;
using System.Text;

namespace Rhapsody.Entities
{
    public interface ISoftDeleteEntity<TPrimaryKey> : IUpdatedEntity<TPrimaryKey>
    {
    }
}
