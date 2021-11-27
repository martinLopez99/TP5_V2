using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTN.FRCU.ISI.TdP.AccountManager.Domain
{
    [NotMapped]
    public class Document
    {
        public DocumentType Type { get; set; }

        public String Number { get; set; }

    }
}
