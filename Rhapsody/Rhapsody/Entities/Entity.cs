namespace Rhapsody.Entities
{
    public class Entity<TPrimaryKey>
        : IEntity<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
    }

    public class Entity
        : Entity<long>, IEntity
    { }
}
