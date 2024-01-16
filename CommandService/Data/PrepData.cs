using Microsoft.EntityFrameworkCore;

namespace CommandsService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app, bool isProduction)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
            if (context == null)
            {
                return;
            }
            SeedData(context, isProduction);
        }

        private static void SeedData(AppDbContext context, bool isProduction)
        {

            Console.WriteLine("--> Attempting to apply migrations...");
            try
            {
                context.Database.Migrate();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"--> Could not run migrations: {ex.Message}");
            }

            if (!isProduction && !context.Platforms.Any())
            {
                Console.WriteLine("--> Seeding Data...");

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> We already have data");
            }
        }
    }
}