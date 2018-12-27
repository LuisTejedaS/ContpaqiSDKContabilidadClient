using AccountingClient.Schema; 
using SDKCONTPAQNGLib;
using System;
using System.Collections.Generic;
using AccountingClient.Core.Schema;


namespace AccountingClient.Core
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AccountingClient.Core.ICompanyService" />
    public class ContpaqLegacyCompanyProvider : ICompanyService
    {
        /// <summary>
        /// Gets the companies.
        /// </summary>
        /// <returns></returns>
        public List<Company> GetCompanies()
        {
            List<Company> companies = new List<Company>();
            TSdkListaEmpresas tSdkListaEmpresas = new TSdkListaEmpresas();
            if (tSdkListaEmpresas.buscaPrimero() != 0)
            {
                Company company = new Company()
                {
                    Id = tSdkListaEmpresas.Id,
                    Name = tSdkListaEmpresas.Nombre,
                    DBName = tSdkListaEmpresas.NombreBDD,
                    DataPath = tSdkListaEmpresas.RutaDatos,
                    BackupPath = tSdkListaEmpresas.RutaResp,
                    LastRestore = tSdkListaEmpresas.UltimaRestauracion,
                    LastRestoreFile = tSdkListaEmpresas.UltimoArchivoRespaldo,
                    LastBackup = tSdkListaEmpresas.UltimoRespaldo,
                };
                companies.Add(company);

                while (true)
                {
                    int id = tSdkListaEmpresas.buscaSiguiente();
                    if (id == 0)
                    {
                        break;
                    }
                    company = new Company()
                    {
                        Id = tSdkListaEmpresas.Id,
                        Name = tSdkListaEmpresas.Nombre,
                        DBName = tSdkListaEmpresas.NombreBDD,
                        DataPath = tSdkListaEmpresas.RutaDatos,
                        BackupPath = tSdkListaEmpresas.RutaResp,
                        LastRestore = tSdkListaEmpresas.UltimaRestauracion,
                        LastRestoreFile = tSdkListaEmpresas.UltimoArchivoRespaldo,
                        LastBackup = tSdkListaEmpresas.UltimoRespaldo,
                    };
                    companies.Add(company);
                }
            }
            return companies;
        }

        /// <summary>
        /// Opens the company.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="DBName">Name of the database.</param>
        public void OpenCompany(Session session, string DBName)
        {
            session.LegacySession.abreEmpresa(DBName);
        }
    }
}
