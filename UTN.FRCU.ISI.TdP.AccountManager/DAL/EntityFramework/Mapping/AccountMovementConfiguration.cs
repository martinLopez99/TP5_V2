using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UTN.FRCU.ISI.TdP.AccountManager.Domain;

namespace UTN.FRCU.ISI.TdP.AccountManager.DAL.EntityFramework.Mapping
{
    class AccountMovementConfiguration :  IEntityTypeConfiguration<AccountMovement> 
    {

        public void Configure(EntityTypeBuilder<AccountMovement> builder)
        {
            builder.HasKey(pAccountMovement => pAccountMovement.Id);

            builder.Property(pAccountMovement => pAccountMovement.Id).ValueGeneratedOnAdd();
                
            builder.Property(pAccountMovement => pAccountMovement.Date)
                .IsRequired();

            builder.Property(pAccountMovement => pAccountMovement.Description)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(pAccountMovement => pAccountMovement.Amount)
                .IsRequired();
        }
    }
}
