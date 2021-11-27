
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UTN.FRCU.ISI.TdP.AccountManager.Domain;

namespace UTN.FRCU.ISI.TdP.AccountManager.DAL.EntityFramework.Mapping
{
    class ClientConfiguration : IEntityTypeConfiguration<Client>
    {

        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(pClient => pClient.Id);

            builder.Property(pClient => pClient.Id).ValueGeneratedOnAdd();                                            

            builder.Property(pClient => pClient.FirstName)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(pClient => pClient.LastName)
                .HasMaxLength(30)
                .IsRequired();

            builder.HasOne(pClient => pClient.Document);

            builder.HasMany(pClient => pClient.Accounts);
               
        }
    }
}
