﻿using AutoMapper;
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
using MySocialNetwork.Domain.ViewModel.Image;
using MySocialNetwork.Domain.ViewModel.Like;
using MySocialNetwork.Domain.ViewModel.Post;
using MySocialNetwork.Domain.ViewModel.User;
using MySocialNetwork.Infra.Data.Context;
using MySocialNetwork.Infra.Data.Identity;
using MySocialNetwork.Infra.Data.Repositories;

namespace MySocialNetwork.Infra.IoC
{
    public class Bootstrap
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), b => b
                .MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
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
                option.AccessDeniedPath = "/social-network/Account/Login"
            );

            services.AddScoped<IAuthenticate, AuthenticateService>();
            services.AddScoped<ISeedUserRoleInitial, SeedUserRoleInitial>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IPostRepository, PostRepository>();

            services.AddScoped<IAddressRepository, AddressRepository>();

            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<ICommentRepository, CommentRepository>();

            services.AddScoped<IImageRepository, ImageRepository>();

            services.AddScoped<ILikeService, LikeService>();
            services.AddScoped<ILikeRepository, LikeRepository>();

            StartAutoMapper(services);
        }

        private static void StartAutoMapper(IServiceCollection services)
        {
            var mapperConfiguration = new MapperConfiguration(config =>
            {
                config.CreateMap<Address, AddressViewModel>().ReverseMap();
                config.CreateMap<Comment, CommentViewModel>().ReverseMap();
                config.CreateMap<Image, ImageViewModel>().ReverseMap();
                config.CreateMap<Like, LikeViewModel>().ReverseMap();
                config.CreateMap<Post, PostViewModel>().ReverseMap();
                config.CreateMap<User, UserViewModel>().ReverseMap();
            });

            IMapper mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
