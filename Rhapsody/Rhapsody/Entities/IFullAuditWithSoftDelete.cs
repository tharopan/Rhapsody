namespace Rhapsody.Entities
{
    public interface IFullAuditWithSoftDelete<TPrimaryKey>
        : IEntity<TPrimaryKey>,
        ICreatedEntity,
        IUpdatedEntity,
        ISoftDeleteEntity
    { }
}
