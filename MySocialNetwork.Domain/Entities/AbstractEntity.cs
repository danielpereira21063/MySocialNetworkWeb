namespace MySocialNetwork.Domain.Entities
{
    public abstract class AbstractEntity
    {
        public AbstractEntity()
        {
            if (Id <= 0)
            {
                CreatedAt = DateTime.Now;
                UpdatedAt = DateTime.Now;
            }
        }

        protected int Id { get; set; }
        protected DateTime CreatedAt { get; set; }
        protected DateTime UpdatedAt { get; set; }
    }
}
