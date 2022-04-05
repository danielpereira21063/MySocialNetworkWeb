using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySocialNetwork.Domain.Entities.UserEntities;

namespace MySocialNetwork.Infra.Data.EntitiesConfiguration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Street).IsRequired();
            builder.Property(x => x.Number).IsRequired();
            builder.Property(x => x.State).IsRequired();
            builder.Property(x => x.Complement).IsRequired();
            builder.Property(x => x.City).IsRequired();
            builder.Property(x => x.PostalCode).IsRequired();
            builder.HasOne(x => x.User).WithMany(a => a.Addresses).HasForeignKey(x => x.UserId);
        }
    }
}
