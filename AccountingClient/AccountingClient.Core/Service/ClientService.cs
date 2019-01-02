using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingClient.Core.Schema;
using AccountingClient.Schema;

namespace AccountingClient.Core 
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AccountingClient.Core.IJournalEntryTypeService" />
    public class ClientService : IClientService
    {
        private readonly IClientService clientService;

        public ClientService(IClientService clientService)
        {
            this.clientService = clientService;

        }

        public Client GetClientByRFC(Session session, string RFC)
        {
            return clientService.GetClientByRFC(session, RFC);
        }

     
    }
}
