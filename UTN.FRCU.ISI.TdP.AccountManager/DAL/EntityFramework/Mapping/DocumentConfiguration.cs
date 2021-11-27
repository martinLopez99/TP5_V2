using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.FRCU.ISI.TdP.AccountManager.Domain;

namespace UTN.FRCU.ISI.TdP.AccountManager.DAL.EntityFramework.Mapping
{
    internal class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.HasKey(pDocument => new { pDocument.Type, pDocument.Number });

            builder.Property(pDocument => pDocument.Type);

            builder.Property(pDocument => pDocument.Number);

        }
    }
}
