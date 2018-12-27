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
    /// <seealso cref="AccountingClient.Core.IJournalEntryTypeService" />
    public class ContpaqLegacyJournalEntryTypeProvider : IJournalEntryTypeService
    {
        /// <summary>
        /// Gets the journal entry types.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <returns></returns>
        public List<JournalEntryType> GetJournalEntryTypes(Session session)
        {
            TSdkSesion sdkSession = session.LegacySession;
            List<JournalEntryType> journalEntryTypes = new List<JournalEntryType>();
            ITSdkTipoPoliza tSdkTipoPoliza = new TSdkTipoPoliza();
            tSdkTipoPoliza.setSesion(sdkSession);

            tSdkTipoPoliza.consultaPorNumero_buscaPrimero(1);
            JournalEntryType tipopol = new JournalEntryType()
            {
                Name = tSdkTipoPoliza.Nombre,
                Number = tSdkTipoPoliza.Numero,
                Id = tSdkTipoPoliza.Id
            };
            journalEntryTypes.Add(tipopol);
            while (true)
            {
                tSdkTipoPoliza.consultaPorNumero_buscaSiguiente(1);
                if (tSdkTipoPoliza.Id == 0)
                {
                    return journalEntryTypes;
                }
                tipopol = new JournalEntryType()
                {
                    Name = tSdkTipoPoliza.Nombre,
                    Number = tSdkTipoPoliza.Numero,
                    Id = tSdkTipoPoliza.Id
                };
                journalEntryTypes.Add(tipopol);

            }
        }
    }
}
