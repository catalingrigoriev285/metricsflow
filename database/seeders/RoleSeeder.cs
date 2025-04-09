using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using metricsflow.database.contexts;
using metricsflow.app.models;

namespace metricsflow.database.seeders
{
    internal class RoleSeeder
    {
        public static void Seed(RoleContext context)
        {
            if (!context.Roles.Any())
            {
                context.Roles.AddRange(
                    new Role { name = "admin", created_at = DateTime.Now, updated_at = DateTime.Now },
                    new Role { name = "employee", created_at = DateTime.Now, updated_at = DateTime.Now }
                );
                context.SaveChanges();
            }
        }
    }
}
