using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySocialNetwork.Application.Interfaces;
using MySocialNetwork.Application.Services;
using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Domain.ViewModel.Address;
using MySocialNetwork.Domain.ViewModel.Comment;
using MySocialNetwork.Domain.ViewModel.Post;
using MySocialNetwork.Domain.ViewModel.User;
using MySocialNetwork.Infra.Data.Context;
using MySocialNetwork.Infra.Data.Repositories;

namespace MySocialNetwork.Infra.IoC
{
    public static class Bootstrap
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

            services.AddScoped<IUserService, UserService>();

            _StartAutoMapper(services);

            _ConfigureIdentity();
        }

        private static void _StartAutoMapper(IServiceCollection services)
        {
            var mapperConfiguration = new MapperConfiguration(config =>
            {
                config.CreateMap<User, UserViewModel>().ReverseMap();
                config.CreateMap<Address, AddressViewModel>().ReverseMap();
                config.CreateMap<Post, PostViewModel>().ReverseMap();
                config.CreateMap<Comment, CommentViewModel>().ReverseMap();
            });

            IMapper mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);
        }

        private static void _ConfigureIdentity()
        {

        }
    }
}
