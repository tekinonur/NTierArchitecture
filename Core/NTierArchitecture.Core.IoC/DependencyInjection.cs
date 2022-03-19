using NTierArchitecture.Data;
using NTierArchitecture.Data.IRepositories;
using NTierArchitecture.Data.Repositories;
using NTierArchitecture.Service;
using NTierArchitecture.Service.IServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Data.SqlClient;

namespace NTierArchitecture.Core.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            //IDbConnection IDbTransaction IoC
            services.RegisterDbCon(configuration);

            //Repository IoC
            services.RegisterRepositories();

            //Service IoC
            services.RegisterServices();

            //Auto Mapper IoC
            services.RegisterMapper();

            //Identity IoC
            services.RegisterIdentity(configuration);

            return services;
        }

        public static IServiceCollection RegisterDbCon(this IServiceCollection services, IConfiguration configuration)
        {
            //IDbConnection IDbTransaction IoC
            services.AddScoped<IDbConnection>((s) => new SqlConnection(configuration.GetConnectionString("Default")));
            services.AddScoped<IDbTransaction>(s =>
            {
                IDbConnection conn = s.GetRequiredService<IDbConnection>();
                conn.Open();
                return conn.BeginTransaction();
            });

            return services;
        }

        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            #region Repository IoC
            //NTierArchitecture.Data.Common | NTierArchitecture.Data.Repositories
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IMuhitRepository, MuhitRepository>();
            #endregion

            #region UnitOfWork IoC
            //NTierArchitecture.Data
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            #endregion

            return services;
        }

        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            //NTierArchitecture.Service.IServices | NTierArchitecture.Service
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IMuhitService, MuhitService>();

            return services;
        }

        public static IServiceCollection RegisterMapper(this IServiceCollection services)
        {
            //NTierArchitecture.Service.Common.Mappings.AutoMapperProfile
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }

        public static IServiceCollection RegisterIdentity(this IServiceCollection services, IConfiguration configuration)
        {
            //services.Configure<AuthenticationSettings>(configuration.GetSection(nameof(AuthenticationSettings)));
            //services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}
