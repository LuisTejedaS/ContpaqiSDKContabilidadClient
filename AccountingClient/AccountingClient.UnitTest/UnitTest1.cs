using AccountingClient.Core;
using AccountingClient.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace AccountingClient.UnitTest
{
    public class AccountingManagerUT
    {
        public class DoLogin
        {
            [Fact]
            public void ShouldBeCorrect()
            {
                var username = "SUPERVISOR";
                var password = "";

                ILoginService loginService = new LoginService(new ContpaqLegacySessionProvider());
                ICompanyService companyService = new CompanyService(new ContpaqLegacyCompanyProvider());
                IJournalEntryTypeService journalEntryTypeService = new JournalEntryTypeService(new ContpaqLegacyJournalEntryTypeProvider());
                IJournalEntryService journalEntryService = new JournalEntryService(new ContpaqLegacyJournalEntryProvider());
                AccountingManager accountingManager = new AccountingManager(loginService, companyService,
                    journalEntryTypeService, journalEntryService);

                var session = accountingManager.DoLogin(username, password);
                Assert.True(session.IsValid);

            }
        }

        public class GetCompanies
        {

            [Fact]
            public void ShouldReturnValues()
            {
                ILoginService loginService = new LoginService(new ContpaqLegacySessionProvider());
                ICompanyService companyService = new CompanyService(new ContpaqLegacyCompanyProvider());
                IJournalEntryTypeService journalEntryTypeService = new JournalEntryTypeService(new ContpaqLegacyJournalEntryTypeProvider());
                IJournalEntryService journalEntryService = new JournalEntryService(new ContpaqLegacyJournalEntryProvider());
                AccountingManager accountingManager = new AccountingManager(loginService, companyService,
                    journalEntryTypeService, journalEntryService);

                var companies = accountingManager.GetCompanies();
                Assert.NotEmpty(companies);

            }

        }

        public class OpenCompany
        {

            [Fact]
            public void ShouldOpenCompany()
            {
                var username = "SUPERVISOR";
                var password = "";

                ILoginService loginService = new LoginService(new ContpaqLegacySessionProvider());
                ICompanyService companyService = new CompanyService(new ContpaqLegacyCompanyProvider());
                IJournalEntryTypeService journalEntryTypeService = new JournalEntryTypeService(new ContpaqLegacyJournalEntryTypeProvider());
                IJournalEntryService journalEntryService = new JournalEntryService(new ContpaqLegacyJournalEntryProvider());
                AccountingManager accountingManager = new AccountingManager(loginService, companyService,
                    journalEntryTypeService, journalEntryService);

                var session = accountingManager.DoLogin(username, password);
                Assert.True(session.IsValid);

                var companies = accountingManager.GetCompanies();
                Assert.NotEmpty(companies);

                accountingManager.OpenCompany(session, companies.FirstOrDefault().DBName);

            }

        }

        public class GetJournalEntryTypes
        {

            [Fact]
            public void ShouldNotBeEmpty()
            {
                var username = "SUPERVISOR";
                var password = "";

                ILoginService loginService = new LoginService(new ContpaqLegacySessionProvider());
                ICompanyService companyService = new CompanyService(new ContpaqLegacyCompanyProvider());
                IJournalEntryTypeService journalEntryTypeService = new JournalEntryTypeService(new ContpaqLegacyJournalEntryTypeProvider());
                IJournalEntryService journalEntryService = new JournalEntryService(new ContpaqLegacyJournalEntryProvider());
                AccountingManager accountingManager = new AccountingManager(loginService, companyService,
                    journalEntryTypeService, journalEntryService);

                var session = accountingManager.DoLogin(username, password);
                Assert.True(session.IsValid);

                var companies = accountingManager.GetCompanies();
                Assert.NotEmpty(companies);

                accountingManager.OpenCompany(session, companies.FirstOrDefault().DBName);

                var journalEntryTypes = accountingManager.GetJournalEntryTypes(session);
                Assert.NotEmpty(journalEntryTypes);

            }

        }

        public class Create
        {

            [Fact]
            public void ShouldCreate()
            {
                var username = "SUPERVISOR";
                var password = "";

                ILoginService loginService = new LoginService(new ContpaqLegacySessionProvider());
                ICompanyService companyService = new CompanyService(new ContpaqLegacyCompanyProvider());
                IJournalEntryTypeService journalEntryTypeService = new JournalEntryTypeService(new ContpaqLegacyJournalEntryTypeProvider());
                IJournalEntryService journalEntryService = new JournalEntryService(new ContpaqLegacyJournalEntryProvider());
                AccountingManager accountingManager = new AccountingManager(loginService, companyService,
                    journalEntryTypeService, journalEntryService);

                var session = accountingManager.DoLogin(username, password);
                Assert.True(session.IsValid);

                var companies = accountingManager.GetCompanies();
                Assert.NotEmpty(companies);

                accountingManager.OpenCompany(session, companies.FirstOrDefault().DBName);

                List<JournalEntryMovement> journalEntryMovements = new List<JournalEntryMovement>();

                var journalEntryMovement1 = new JournalEntryMovement()
                {
                    Account = "20101000",
                    Amount = 123,
                    AmountFC = 0,
                    Concept = Guid.NewGuid().ToString() + "Concpept UT",
                    Guid = Guid.NewGuid(),
                    JournalEntryMovementDaily = 0,
                    JournalEntryMovementType = JournalEntryMovementType.DEBITS,
                    Number = 1,
                };

                var journalEntryMovement2 = new JournalEntryMovement()
                {
                    Account = "10201000",
                    Amount = 123,
                    AmountFC = 0,
                    Concept = Guid.NewGuid().ToString() + "Concpept UT",
                    Guid = Guid.NewGuid(),
                    JournalEntryMovementDaily = 0,
                    JournalEntryMovementType = JournalEntryMovementType.CREDITS,
                    Number = 2,
                };

                journalEntryMovements.Add(journalEntryMovement1);
                journalEntryMovements.Add(journalEntryMovement2);

                var journalEntry = new JournalEntry()
                {
                    Type = "6",
                    Date = DateTime.Now,
                    Adjust = false,
                    Affect = true,
                    Daily = 0,
                    Guid = Guid.NewGuid(),
                    Printed = false,
                    SourceSystem = "11",
                    Concept = Guid.NewGuid().ToString() + " desde UT",
                    Number = 2,
                };
                journalEntry.JournalEntryMovement = journalEntryMovements;

                accountingManager.CreateJournalEntry(session, new List<JournalEntry>() { journalEntry });


            }
        }
    }
}
