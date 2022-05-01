using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Infra.Data.Identity;

namespace MySocialNetwork.Infra.Data.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Post>? Posts { get; set; }
        public DbSet<Image>? Images { get; set; }
#pragma warning disable CS0114 // 'ApplicationDbContext.Users' hides inherited member 'IdentityUserContext<ApplicationUser, string, IdentityUserClaim<string>, IdentityUserLogin<string>, IdentityUserToken<string>>.Users'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.
        public DbSet<User>? Users { get; set; }
#pragma warning restore CS0114 // 'ApplicationDbContext.Users' hides inherited member 'IdentityUserContext<ApplicationUser, string, IdentityUserClaim<string>, IdentityUserLogin<string>, IdentityUserToken<string>>.Users'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.
        public DbSet<Comment>? Comments { get; set; }
        public DbSet<Like>? Likes { get; set; }
        public DbSet<Address>? Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
