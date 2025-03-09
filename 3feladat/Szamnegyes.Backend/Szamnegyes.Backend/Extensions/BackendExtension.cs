
using Microsoft.EntityFrameworkCore;
using Szamnegyes.Backend.Context;

namespace Szamnegyes.Backend.Extensions
{
    public static class BackendExtension
    {
        public static void ConfigureMySqlContext(this IServiceCollection services)
        {
            string connectionString = "server=localhost;userid=root;password=;database=szamnegyesprojekt;port=3306";
            services.AddDbContext<FoursContext>(options => options.UseMySQL(connectionString));
        }

        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(option =>
                option.AddPolicy(name: "FoursCors",
                    policy =>
                    {
                        policy.WithOrigins("http://localhost:5173")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                    }
                )
           );
        }
    }
}
