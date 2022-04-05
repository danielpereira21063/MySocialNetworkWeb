using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySocialNetwork.Domain.Entities.PostEntities;

namespace MySocialNetwork.Infra.Data.EntitiesConfiguration
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.File).IsRequired();
            builder.HasOne(x => x.Post).WithMany(a => a.Images).HasForeignKey(x => x.PostId);
        }
    }
}
