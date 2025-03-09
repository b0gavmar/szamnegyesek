
using Szamnegyes.Backend.Context;

namespace Szamnegyes.Backend.Extensions
{
    public static class BackendExtension
    {
        private static void ConfigureMySqlContext(this IServiceCollection services)
        {
            string connectionString = "server=localhost;userid=root;password=;database=pipeline;port=3306";
            services.AddDbContext<FoursContext>(options => options.UseMySQL(connectionString));
        }
    }
}
