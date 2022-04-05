using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySocialNetwork.Domain.Entities.PostEntities;

namespace MySocialNetwork.Infra.Data.EntitiesConfiguration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Subtitle).IsRequired();
            builder.HasOne(x => x.User).WithMany(p => p.Posts).HasForeignKey(a => a.UserId);
        }
    }
}
