using AccountingClient.Core.Schema;
using AccountingClient.Schema;
using SDKCONTPAQNGLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingClient.Core
{

    /// <summary>
    /// 
    /// </summary>
    public class ContpaqLegacyClientProvider : IClientService
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        /// <param name="RFC"></param>
        /// <returns></returns>
        public Client GetClientByRFC(Session session, string RFC)
        {
            TSdkSesion sdkSession = session.LegacySession;

            TSdkCliente sdkCliente = new TSdkCliente();
            sdkCliente.setSesion(sdkSession);

            sdkCliente.consultaPorRFC_buscaPorLlave(RFC);

            Client client = new Client()
            {
                Name = sdkCliente.Nombre,
                RFC = sdkCliente.RFC,
                ProvissionAccount = sdkCliente.CodigoCuenta,
                ComplementaryProvissionAccount = sdkCliente.CodigoCtaComplementaria,
            };


            return client;
        }

    }
}
