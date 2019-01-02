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
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierService supplierService;

        public SupplierService(ISupplierService supplierService)
        {
            this.supplierService = supplierService;

        }

        public Supplier GetSupplierByRFC(Session session, string RFC)
        {
            return supplierService.GetSupplierByRFC(session, RFC);
        }
    }
}
