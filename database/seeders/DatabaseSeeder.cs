using metricsflow.database.contexts;

namespace metricsflow.database.seeders
{
    internal static class DatabaseSeeder
    {
        public static void Seed()
        {
            using (var context = new RoleContext())
            {
                RoleSeeder.Seed(context);
            }
        }
    }
}