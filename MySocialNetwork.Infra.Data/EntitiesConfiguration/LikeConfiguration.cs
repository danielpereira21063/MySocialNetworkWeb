using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySocialNetwork.Domain.Entities.PostEntities;

namespace MySocialNetwork.Infra.Data.EntitiesConfiguration
{
    public class LikeConfiguration : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Post).WithMany(a => a.Likes).HasForeignKey(l => l.PostId);
            builder.HasOne(x => x.LikedBy).WithMany(a => a.Likes).HasForeignKey(l => l.LikedById);
        }
    }
}
