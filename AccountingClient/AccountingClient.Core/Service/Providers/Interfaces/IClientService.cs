using AccountingClient.Core.Schema;
using AccountingClient.Schema;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingClient.Core
{
    public interface IClientService
    {
        Client GetClientByRFC(Session session, string RFC);

    }
}
