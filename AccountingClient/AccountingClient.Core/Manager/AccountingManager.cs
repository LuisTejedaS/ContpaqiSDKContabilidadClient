using AccountingClient.Schema;
using System;
using System.Collections.Generic;
using AccountingClient.Core.Schema;


namespace AccountingClient.Core
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AccountingClient.Core.ILoginService" />
    /// <seealso cref="AccountingClient.Core.ICompanyService" />
    /// <seealso cref="AccountingClient.Core.IJournalEntryTypeService" />
    /// <seealso cref="AccountingClient.Core.IJournalEntryService" />
    public class AccountingManager : ILoginService,  ICompanyService, IJournalEntryTypeService, IJournalEntryService
    {
        private readonly ILoginService loginService;
        private readonly IJournalEntryTypeService journalEntryTypeService;
        private readonly ICompanyService companyService;
        private readonly IJournalEntryService journalEntryService;


        /// <summary>
        ///   Initializes a new instance of the <see cref="AccountingManager" /> class.
        /// </summary>
        /// <param name="loginService">
        ///   The login service.
        /// </param>
        /// <param name="companyService">
        ///   The company service.
        /// </param>
        /// <param name="journalEntryTypeService">
        ///   The journal entry type service.
        /// </param>
        /// <param name="journalEntryService">
        ///   The journal entry service.
        /// </param>
        public AccountingManager(ILoginService loginService, ICompanyService companyService,
            IJournalEntryTypeService journalEntryTypeService, IJournalEntryService journalEntryService)
        {
            this.loginService = loginService;
            this.journalEntryTypeService = journalEntryTypeService;
            this.companyService = companyService;
            this.journalEntryService = journalEntryService;
        }

        /// <summary>
        /// Does the login.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public Session DoLogin(string username, string password)
        {
            return loginService.DoLogin(username, password);
        }

        /// <summary>
        /// Gets the journal entry types.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <returns></returns>
        public List<JournalEntryType> GetJournalEntryTypes(Session session)
        {
            return journalEntryTypeService.GetJournalEntryTypes(session);
        }

        /// <summary>
        /// Gets the companies.
        /// </summary>
        /// <returns></returns>
        public List<Company> GetCompanies()
        {
            return companyService.GetCompanies( );
        }

        /// <summary>
        /// Opens the company.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="DBName">Name of the database.</param>
        public void OpenCompany(Session session, string DBName)
        {
              companyService.OpenCompany(session, DBName);
        }

        /// <summary>
        /// Gets the journal entry.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        //public List<JournalEntry> GetJournalEntry(Session session, JournalEntryFilterWindowModel filter)
        //{
        //    return journalEntryService.GetJournalEntry(session, filter);
        //}

        /// <summary>
        /// Gets the journal entry movement.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        //public List<JournalEntryMovement> GetJournalEntryMovement(Session session, JournalEntryMovementFilterWindowModel filter)
        //{
        //    return journalEntryService.GetJournalEntryMovement(session, filter);
        //}

        /// <summary>
        /// Gets the journal entry.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="journalEntries"></param>
        public void CreateJournalEntry(Session session, List<JournalEntry> journalEntries)
        {
              journalEntryService.CreateJournalEntry(session, journalEntries);
        }
    }

}