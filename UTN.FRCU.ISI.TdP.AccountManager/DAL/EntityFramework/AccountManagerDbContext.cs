using Microsoft.EntityFrameworkCore;
using UTN.FRCU.ISI.TdP.AccountManager.DAL.EntityFramework.Mapping;
using UTN.FRCU.ISI.TdP.AccountManager.Domain;

namespace UTN.FRCU.ISI.TdP.AccountManager.DAL.EntityFramework
{
    public class AccountManagerDbContext : DbContext
    {

        public DbSet<Client> Clients { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<AccountMovement> AccountMovements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new AccountMovementConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new DocumentConfiguration());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=AccountManagerNet5;Trusted_Connection=True;");
        }

    }
}
