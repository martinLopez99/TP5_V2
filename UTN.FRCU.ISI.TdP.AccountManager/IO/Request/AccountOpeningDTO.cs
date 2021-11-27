using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.FRCU.ISI.TdP.AccountManager.IO.Request
{
    public class AccountOpeningDTO
    {
        public ClientDTO Client { get; set; }

        public AccountDTO Account { get; set; }
    }
}
