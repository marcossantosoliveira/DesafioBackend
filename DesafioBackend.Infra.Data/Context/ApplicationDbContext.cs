using DesafioBackend.Domain.Entities;
using DesafioBackend.Infra.Data.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBackend.Infra.Data
{
    public class ApplicationDbContext : DbContext
    {



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opcoes) : base(opcoes)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:desafiobackendsql.database.windows.net,1433;Initial Catalog=DesafioBackendBd;" +
                    "                         Persist Security Info=False;User ID=desafioBackendsql;Password=abc@12345;" +
                    "                         MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }      

        public DbSet<Clientes> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ClienteConfiguracao());
        }
    }
}
