
using Microsoft.EntityFrameworkCore;
using MicroRabbitMQ.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore.Design;

namespace MicroRabbitMQ.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {

        public TransferDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<TransferLog> TransferLogs { get; set; }

    }


    public class TransferDbContextFactory : IDesignTimeDbContextFactory<TransferDbContext>
    {
        public TransferDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TransferDbContext>();
            optionsBuilder.UseSqlServer("Server=LAPTOP-TT5P3OP6\\SQLEXPRESS;Database=TransferDB;Trusted_Connection=True;MultipleActiveResultSets=True;");

            return new TransferDbContext(optionsBuilder.Options);
        }
    }
}
