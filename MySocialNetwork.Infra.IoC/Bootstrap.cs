using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySocialNetwork.Application.Interfaces;
using MySocialNetwork.Application.Services;
using MySocialNetwork.Domain.Account;
using MySocialNetwork.Domain.Entities.PostEntities;
using MySocialNetwork.Domain.Entities.UserEntities;
using MySocialNetwork.Domain.Interfaces;
using MySocialNetwork.Domain.ViewModel.Address;
using MySocialNetwork.Domain.ViewModel.Comment;
using MySocialNetwork.Domain.ViewModel.Post;
using MySocialNetwork.Domain.ViewModel.User;
using MySocialNetwork.Infra.Data.Context;
using MySocialNetwork.Infra.Data.Identity;
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

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            }).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(option =>
                option.AccessDeniedPath = "/Account/Login"
            );

            services.AddScoped<IAuthenticate, AuthenticateService>();
            services.AddScoped<ISeedUserRoleInitial, SeedUserRoleInitial>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IPostRepository, PostRepository>();

            services.AddScoped<IAddressRepository, AddressRepository>();

            services.AddScoped<ICommentRepository, CommentRepository>();

            services.AddScoped<IImageRepository, ImageRepository>();

            services.AddScoped<ILikeRepository, LikeRepository>();




            _StartAutoMapper(services);
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
    }
}
