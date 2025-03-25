using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using metricsflow.app.Models;
using Microsoft.EntityFrameworkCore;

namespace metricsflow.app.Data
{
    internal class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = "Server=localhost;user=root1;password=pass123;database=metricsflow";
            var serverVersion = new MySqlServerVersion(new Version(10, 4, 32));

            optionsBuilder.UseMySql(connection, serverVersion);
        }
    }
}
