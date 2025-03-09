using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Szamnegyes.Backend.Context;

namespace Szamnegyes.Backend.Extensions
{
    public static class DatabaseInitializer
    {
        public static void InitializeDatabase(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<FoursContext>();

                context.Database.Migrate();
            }
        }
    }
}
