using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using metricsflow.app.models;

namespace metricsflow.database.contexts;

internal class ModelHasRoleContext : DbContext
{
    public DbSet<Role> Roles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connection = "Server=localhost;user=root1;password=pass123;database=metricsflow";
        var serverVersion = new MySqlServerVersion(new Version(10, 4, 32));

        optionsBuilder.UseMySql(connection, serverVersion);
    }
}
