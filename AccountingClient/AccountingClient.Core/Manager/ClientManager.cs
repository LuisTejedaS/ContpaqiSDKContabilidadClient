using AccountingClient.Schema;
using System;
using System.Collections.Generic;
using AccountingClient.Core.Schema;


namespace AccountingClient.Core
{

    /// <summary>
    /// 
    /// </summary>
    public class ClientManager : IClientService
    {
        private readonly IClientService ClientService;

        public ClientManager(IClientService ClientService)
        {
            this.ClientService = ClientService;
        }

        public Client GetClientByRFC(Session session, string RFC)
        {
            return ClientService.GetClientByRFC(session, RFC);
        }
    }

}