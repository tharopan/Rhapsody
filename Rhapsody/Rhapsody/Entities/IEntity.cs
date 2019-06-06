﻿namespace Rhapsody.Entities
{
    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }

    public interface IEntity
        : IEntity<long>
    { }
}
