using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySocialNetwork.Domain.Entities.PostEntities;

namespace MySocialNetwork.Infra.Data.EntitiesConfiguration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Text).IsRequired();
            builder.HasOne(x => x.Post).WithMany(c => c.Comments).HasForeignKey(p => p.PostId);
            builder.HasOne(x => x.User).WithMany(c => c.Comments).HasForeignKey(u => u.UserId);
        }
    }
}
