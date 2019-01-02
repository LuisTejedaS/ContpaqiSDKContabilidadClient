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
    public class ContpaqLegacySupplierProvider : ISupplierService
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        /// <param name="RFC"></param>
        /// <returns></returns>
        public Supplier GetSupplierByRFC(Session session, string RFC)
        {
            TSdkSesion sdkSession = session.LegacySession;

            TSdkProveedor sdkProveedor = new TSdkProveedor();
            sdkProveedor.setSesion(sdkSession);

            sdkProveedor.consultaPorRFC_buscaPorLlave(RFC);

            Supplier sup = new Supplier()
            {
                Name = sdkProveedor.Nombre,
                RFC = sdkProveedor.RFC,
                Account = sdkProveedor.CodigoCuenta,
                ComplementaryAccount = sdkProveedor.CodigoCtaComplementaria,
                ComplementaryExpenseAccount = sdkProveedor.CodigoCtaGastosComplementaria,
                ExpenseAccount = sdkProveedor.CodigoCtaGastos,
            };

            return sup;
        }

    }
}
