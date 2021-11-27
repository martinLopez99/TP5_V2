using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UTN.FRCU.ISI.TdP.AccountManager.Domain;

namespace UTN.FRCU.ISI.TdP.AccountManager.DAL.EntityFramework.Mapping
{
    class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(pAccount => pAccount.Id);

            builder.Property(pAccount => pAccount.Id).ValueGeneratedOnAdd();                

            builder.Property(pAccount => pAccount.Name)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(pAccount => pAccount.OverdraftLimit)
                .IsRequired();

            builder.HasOne(pAccount => pAccount.Client);

            builder.HasMany(pClient => pClient.Movements);
                
        }


    }
}
