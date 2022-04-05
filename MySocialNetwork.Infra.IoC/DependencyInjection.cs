using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Infra.Data.Context;
using MySocialNetwork.Infra.Data.Repositories;

namespace MySocialNetwork.Infra.IoC
{
    public static class DependencyInjection
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });

            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<IImageRepository, ImageRepository>();
            services.AddScoped<ILikeRepository, LikeRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
