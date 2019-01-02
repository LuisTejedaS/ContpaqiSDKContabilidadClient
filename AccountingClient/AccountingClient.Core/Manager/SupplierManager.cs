using AccountingClient.Schema;
using System;
using System.Collections.Generic;
using AccountingClient.Core.Schema;


namespace AccountingClient.Core
{

    /// <summary>
    /// 
    /// </summary>
    public class SupplierManager : ISupplierService
    {
        private readonly ISupplierService supplierService;

        public SupplierManager(ISupplierService supplierService)
        {
            this.supplierService = supplierService;
        }

        public Supplier GetSupplierByRFC(Session session, string RFC)
        {
            return supplierService.GetSupplierByRFC(session, RFC);
        }
    }

}