using AccountingClient.Core;
using AccountingClient.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace AccountingClient.UnitTest
{
    public class SupplierManagerUT
    {
        public class GetSupplierByRFC
        {
            [Fact]
            public void ShouldReturnValid()
            {
                var username = "SUPERVISOR";
                var password = "";
                var rfcToFind = "CAC840428RH1";

                ILoginService loginService = new LoginService(new ContpaqLegacySessionProvider());
                ICompanyService companyService = new CompanyService(new ContpaqLegacyCompanyProvider());
                IJournalEntryTypeService journalEntryTypeService = new JournalEntryTypeService(new ContpaqLegacyJournalEntryTypeProvider());
                IJournalEntryService journalEntryService = new JournalEntryService(new ContpaqLegacyJournalEntryProvider());
                AccountingManager accountingManager = new AccountingManager(loginService, companyService,
                    journalEntryTypeService, journalEntryService);


                ISupplierService supplierService = new SupplierService(new ContpaqLegacySupplierProvider());
                SupplierManager supplierManager = new SupplierManager(supplierService);

                var session = accountingManager.DoLogin(username, password);

                var companies = accountingManager.GetCompanies();
                Assert.NotEmpty(companies);

                accountingManager.OpenCompany(session, companies.FirstOrDefault().DBName);

                Assert.True(session.IsValid);

                var res = supplierManager.GetSupplierByRFC(session, rfcToFind);
                Assert.NotNull(res);
                Assert.Equal(rfcToFind, res.RFC);

            }
        }
        
    }
}
