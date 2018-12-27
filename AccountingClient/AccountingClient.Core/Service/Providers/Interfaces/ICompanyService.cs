using AccountingClient.Schema;
using System.Collections.Generic;
using AccountingClient.Core.Schema;

namespace AccountingClient.Core
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICompanyService
    {
        /// <summary>
        /// Gets the companies.
        /// </summary>
        /// <returns></returns>
        List<Company> GetCompanies();

        /// <summary>
        /// Opens the company.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="DBName">Name of the database.</param>
        void OpenCompany(Session session, string DBName);

    }
}