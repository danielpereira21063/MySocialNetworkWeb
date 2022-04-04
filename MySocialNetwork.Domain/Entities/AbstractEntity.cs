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
        protected int Id { get; set; }
        protected DateTime CreatedAt { get; set; }
        protected DateTime UpdatedAt { get; set; }
    }
}
