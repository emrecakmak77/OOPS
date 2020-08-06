namespace OOPS.Core.Entities
{
    public abstract class Entity<T> : EntityBase, IEntity<T> where T : struct
    {
        public virtual T Id { get; set; }
    }
}
