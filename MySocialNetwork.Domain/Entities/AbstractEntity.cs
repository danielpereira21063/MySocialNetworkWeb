using System.ComponentModel.DataAnnotations.Schema;

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

        [Column(TypeName = "INT UNSIGNED")]
        public int Id { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }
    }
}
