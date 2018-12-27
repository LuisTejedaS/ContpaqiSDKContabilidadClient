using AccountingClient.Schema;
using System;
using System.Collections.Generic;
using AccountingClient.Core.Schema;


namespace AccountingClient.Core 
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AccountingClient.Core.ICompanyService" />
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyService companyService;

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyService"/> class.
        /// </summary>
        /// <param name="companyProvider">The company provider.</param>
        public CompanyService(ICompanyService companyProvider)
        {
            this.companyService = companyProvider;
        }

        /// <summary>
        /// Gets the companies.
        /// </summary>
        /// <returns></returns>
        public List<Company> GetCompanies()
        {
            return this.companyService.GetCompanies();
        }

        /// <summary>
        /// Opens the company.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="DBName">Name of the database.</param>
        public void OpenCompany(Session session, string DBName)
        {
            this.companyService.OpenCompany(session, DBName);
        }
    }
}
