using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.FRCU.ISI.TdP.AccountManager.Domain;

namespace UTN.FRCU.ISI.TdP.AccountManager.IO
{
    public class ClientDTO
    {
        public int Id { get; set; }

        public DocumentType Type { get; set; }

        public String Number { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

    }
}
