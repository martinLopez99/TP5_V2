using System;
using UTN.FRCU.ISI.TdP.AccountManager.IO.Request;

namespace UTN.FRCU.ISI.TdP.AccountManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var accountOpeningRequest = new AccountOpeningDTO
                {
                    Client = new IO.ClientDTO { FirstName = "Leandro", LastName = "Paredes", Type = Domain.DocumentType.DNI, Number = "33333333" },
                    Account = new IO.AccountDTO { Name = "Cuenta Principal" }
                };

                new Bank().AccountOpening(accountOpeningRequest);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
