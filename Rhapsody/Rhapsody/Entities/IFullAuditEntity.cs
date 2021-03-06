﻿namespace Rhapsody.Entities
{
    public interface IFullAuditEntity<TPrimaryKey>
        : IEntity<TPrimaryKey>,
        ICreatedEntity,
        IUpdatedEntity,
        IDeletedEntity
    { }
}
