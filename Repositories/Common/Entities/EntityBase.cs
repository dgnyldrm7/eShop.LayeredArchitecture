namespace App.Core.Common.Entities
{
    public abstract class EntityBase<T>
    {
        public T? Id { get; set; }
        public DateTime? CreatedAt { get; set; }

        protected EntityBase()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
}