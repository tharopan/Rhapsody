using System;
using System.Collections.Generic;
using System.Text;

namespace Rhapsody.Entities
{
    public class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
    }
}
