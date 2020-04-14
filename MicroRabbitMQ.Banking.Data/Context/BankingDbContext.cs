using MicroRabbitMQ.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MicroRabbitMQ.Banking.Data.Context
{
    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Account> Accounts{ get; set; }
    }

    public class BankingContextFactory : IDesignTimeDbContextFactory<BankingDbContext>
    {
        public BankingDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BankingDbContext>();
            optionsBuilder.UseSqlServer("Server=LAPTOP-TT5P3OP6\\SQLEXPRESS;Database=BankingDB;Trusted_Connection=True;MultipleActiveResultSets=True;");

            return new BankingDbContext(optionsBuilder.Options);
        }
    }

}

